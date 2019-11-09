using BookAccounting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using BookAccounting.Data.Models;

namespace BookAccounting
{
    public static class FilterController
    {
        public static Dictionary<string, string> filterTableColumnsNames = Localization.localNamesBook;
        public static string[] stringConditions = new[] { "Содержит", "Не содержит", "Начинается с" };
        public static string[] numberConditions = new[] { "<", "<=", "=", ">=", ">" };
        

        public static object ApplyFilters(LibraryDbContext db, Type entityType, List<Filter> filters)
        {
            if (entityType == typeof(Book))
            {
                return db.Books.Where(filters).ToList();
            }
            else if(entityType == typeof(Reader))
            {
                return db.Readers.Where(filters).ToList();
            }
            else if (entityType == typeof(IssuedBook))
            {
                return db.IssuedBooks.Where(filters).ToList();
            }
            return null;
        }

        public static List<Filter> GetFilters(DataGridView filtersTable)
        {
            var result = new List<Filter>();
            foreach (DataGridViewRow row in filtersTable.Rows)
            {
                var isUsedRow = row.Cells["UsedFilterTableColumn"].Value;
                if (isUsedRow != null && (bool)isUsedRow == true)
                {
                    result.Add(new Filter()
                    {
                        Condition = row.Cells["ConditionFilterTableColumn"].Value.ToString(),
                        Field = row.Cells["FieldFilterTableColumn"].Value.ToString(),
                        Operator = row.Cells["OperatorFilterTableColumn"].Value.ToString(),
                        Value = row.Cells["ValueFilterTableColumn"].Value                       
                    });
                }
            }
            return result;
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, List<Filter> filters)
        {
            Expression predicate = null;
            var param = Expression.Parameter(typeof(T), "b");
            foreach (var filter in filters)
            {
                var propertyName = filter.Field;
                var property = Expression.Property(param, filterTableColumnsNames[propertyName]);
                if (predicate == null)
                {
                    predicate = GetOperand(property, filter.Condition, filter.Value);
                }
                else
                {
                    if (filter.Operator.Equals("ИЛИ"))
                    {
                        predicate = Expression.Or(predicate, GetOperand(property, filter.Condition, filter.Value));
                    }
                    else
                    {
                        predicate = Expression.And(predicate, GetOperand(property, filter.Condition, filter.Value));
                    }
                }
            }
            var enumerableType = typeof(Enumerable);
            var enumerableMethods = enumerableType.GetMethods(BindingFlags.Public | BindingFlags.Static);
            var whereMethod = enumerableMethods.Where(m => m.Name == "Where" && m.GetParameters().Count() == 2).First();
            whereMethod = whereMethod.MakeGenericMethod(typeof(T));
            var lambda = predicate == null ? 
                Expression.Lambda<Func<T, bool>>(Expression.Constant(true), param).Compile() : 
                Expression.Lambda<Func<T, bool>>(predicate, param).Compile();
            return (IEnumerable<T>)whereMethod.Invoke(null, new object[] { source, lambda });
        }

        private static Expression GetOperand(MemberExpression property, string condition, object value)
        {
            Expression operand = null;
            if (property.Type == typeof(int))
            {
                int temp;
                if (value == null)
                    value = default(int);
                else
                    value = int.TryParse(value.ToString(), out temp) ? temp : default(int);
            }
            else if (property.Type == typeof(int?))
            {
                int temp;
                if (value == null)
                    value = default(int?);
                else
                    value = int.TryParse(value.ToString(), out temp) ? temp : default(int?);
            }
            else if (property.Type == typeof(DateTime))
            {
                value = ((DateTime)value).Date;
            }
            else
            {
                value = value ?? "";
            }
            switch (condition)
            {
                case "<": operand = Expression.LessThan(property, Expression.Constant(value, property.Type)); break;
                case "<=": operand = Expression.LessThanOrEqual(property, Expression.Constant(value, property.Type)); break;
                case "=": operand = Expression.Equal(property, Expression.Constant(value, property.Type)); break;
                case ">=": operand = Expression.GreaterThanOrEqual(property, Expression.Constant(value, property.Type)); break;
                case ">": operand = Expression.GreaterThan(property, Expression.Constant(value, property.Type)); break;
                case "Содержит":
                    operand = Expression.Call(typeof(StringExtensions).GetMethod("Contains"), property, Expression.Constant(value), Expression.Constant(StringComparison.OrdinalIgnoreCase)); break;
                case "Не содержит":
                    operand = Expression.IsFalse(Expression.Call(typeof(StringExtensions).GetMethod("Contains"), property, Expression.Constant(value), Expression.Constant(StringComparison.OrdinalIgnoreCase))); break;
                case "Начинается с":
                    operand = Expression.Call(
                        property, 
                        typeof(string).GetMethod("StartsWith", new[] { typeof(string), typeof(StringComparison) }), Expression.Constant(value), Expression.Constant(StringComparison.OrdinalIgnoreCase)); break;
            }
            return operand;
        }
    }
}
