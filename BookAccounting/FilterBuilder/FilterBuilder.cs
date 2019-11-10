using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using BookAccounting.Extensions;
using BookAccounting.FilterBuilder.FilterParameters;

namespace BookAccounting.FilterBuilder
{
    public class FilterBuilder<TEntity>
        where TEntity : class
    {
        private static HashSet<Condition> stringConditions = new HashSet<Condition>
        {
            Condition.Contains,
            Condition.StartsWith,
            Condition.DoesNotContains
        };

        private static HashSet<Condition> numberConditions = new HashSet<Condition>
        {
            Condition.Less,
            Condition.LessOrEqual,
            Condition.Equal,
            Condition.GreaterOrEqual,
            Condition.Greater
        };

        private readonly List<FilterStatement> statements = new List<FilterStatement>();

        public List<FilterStatement> Statements
        {
            get { return statements; }
        }

        public FilterBuilder()
        {
        }

        public FilterBuilder(IEnumerable<FilterStatement> filterStatements)
        {
            foreach (var statement in filterStatements)
            {
                this.By(statement.Property, statement.Condition, statement.Value, statement.Operator);                
            }
        }
        
        public static implicit operator Func<TEntity, bool>(FilterBuilder<TEntity> filter)
        {
            return ((Expression<Func<TEntity, bool>>) filter).Compile();
        }

        public static implicit operator Expression<Func<TEntity, bool>>(FilterBuilder<TEntity> filter)
        {
            if (filter.statements.Count == 0)
                return (t) => true;

            return BuildExpression(filter.statements);
        }

        public void By(string propertyName, Condition condition,
            object value, Operator op = Operator.And)
        {
            var entityType = typeof(TEntity);
            var propType = entityType.GetProperty(propertyName).PropertyType;

            if (propType == typeof(int) || propType == typeof(int?) || propType == typeof(DateTime))
            {
                if (!numberConditions.Contains(condition))
                    throw new ArgumentException($"Unsupported condition: {condition}");
            }
            else if (propType == typeof(string))
            {
                if (!stringConditions.Contains(condition))
                    throw new ArgumentException($"Unsupported condition: {condition}");
            }
            else
            {
                throw new ArgumentException($"Unsupported property type: {propType}");
            }

            statements.Add(new FilterStatement
            {
                Operator = op,
                Condition = condition,
                Property = propertyName,
                Value = value,
            });
        }

        public void Clear()
        {
            statements.Clear();
        }

        private static Expression<Func<TEntity, bool>> BuildExpression(List<FilterStatement> filters)
        {
            Expression predicate = null;
            var param = Expression.Parameter(typeof(TEntity), "b");
            foreach (var filter in filters)
            {
                var propertyName = filter.Property;
                var property = Expression.Property(param, propertyName);

                if (predicate == null)
                {
                    predicate = GetOperand(property, filter.Condition, filter.Value);
                }
                else
                {
                    predicate = filter.Operator == Operator.Or
                        ? Expression.Or(predicate, GetOperand(property, filter.Condition, filter.Value))
                        : Expression.And(predicate, GetOperand(property, filter.Condition, filter.Value));
                }
            }

            return predicate == null
                ? Expression.Lambda<Func<TEntity, bool>>(Expression.Constant(true), param)
                : Expression.Lambda<Func<TEntity, bool>>(predicate, param);
        }

        private static Expression GetOperand(MemberExpression property,
            Condition condition, object value)
        {
            Expression operand = null;
            if (property.Type == typeof(int))
            {
                if (value == null)
                    value = default(int);
                else
                    value = int.TryParse(value.ToString(), out var temp) ? temp : default(int);
            }
            else if (property.Type == typeof(int?))
            {
                value = int.TryParse(value.ToString(), out var temp) ? temp : default(int?);
            }
            else if (property.Type == typeof(DateTime))
            {
                value = ((DateTime) value).Date;
            }
            else
            {
                value = value ?? "";
            }

            switch (condition)
            {
                case Condition.Less:
                    operand = Expression.LessThan(property, Expression.Constant(value, property.Type));
                    break;
                case Condition.LessOrEqual:
                    operand = Expression.LessThanOrEqual(property, Expression.Constant(value, property.Type));
                    break;
                case Condition.Equal:
                    operand = Expression.Equal(property, Expression.Constant(value, property.Type));
                    break;
                case Condition.GreaterOrEqual:
                    operand = Expression.GreaterThanOrEqual(property, Expression.Constant(value, property.Type));
                    break;
                case Condition.Greater:
                    operand = Expression.GreaterThan(property, Expression.Constant(value, property.Type));
                    break;
                case Condition.Contains:
                    operand = Expression.Call(typeof(StringExtensions).GetMethod("Contains"), property,
                        Expression.Constant(value), Expression.Constant(StringComparison.OrdinalIgnoreCase));
                    break;
                case Condition.DoesNotContains:
                    operand = Expression.IsFalse(Expression.Call(typeof(StringExtensions).GetMethod("Contains"),
                        property, Expression.Constant(value), Expression.Constant(StringComparison.OrdinalIgnoreCase)));
                    break;
                case Condition.StartsWith:
                    operand = Expression.Call(
                        property,
                        typeof(string).GetMethod("StartsWith", new[] {typeof(string), typeof(StringComparison)}),
                        Expression.Constant(value), Expression.Constant(StringComparison.OrdinalIgnoreCase));
                    break;
            }

            return operand;
        }
    }
}