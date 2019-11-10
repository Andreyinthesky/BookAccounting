using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BookAccounting.FilterBuilder;
using BookAccounting.FilterBuilder.FilterParameters;

namespace BookAccounting.CustomControls
{
    public sealed class FiltersDataGridView : DataGridView, IFilterProvider
    {
        private DataGridViewCheckBoxColumn UsedFilterTableColumn = new DataGridViewCheckBoxColumn();
        private DataGridViewComboBoxColumn OperatorFilterTableColumn = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn FieldFilterTableColumn = new DataGridViewComboBoxColumn();
        private DataGridViewComboBoxColumn ConditionFilterTableColumn = new DataGridViewComboBoxColumn();
        private DataGridViewTextBoxColumn ValueFilterTableColumn = new DataGridViewTextBoxColumn();

        public string[] StringConditionValues => stringValueToCondition.Keys.Take(3).ToArray();
        public string[] NumberConditionValues => stringValueToCondition.Keys.Skip(3).ToArray();

        private readonly Dictionary<string, Condition> stringValueToCondition = new Dictionary<string, Condition>
        {
            {"Содержит", Condition.Contains},
            {"Не содержит", Condition.DoesNotContains},
            {"Начинается с", Condition.StartsWith},
            
            {">=", Condition.GreaterOrEqual},
            {">", Condition.Greater},
            {"=", Condition.Equal},
            {"<=", Condition.LessOrEqual},
            {"<", Condition.Less},
        };
        
        private readonly Dictionary<string, Operator> stringValueToOperator = new Dictionary<string, Operator>
        {
            {"И", Operator.And},
            {"ИЛИ", Operator.Or},
        };

        public FiltersDataGridView()
        {
            AllowUserToAddRows = false;
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Columns.AddRange(new DataGridViewColumn[]
            {
                UsedFilterTableColumn,
                OperatorFilterTableColumn,
                FieldFilterTableColumn,
                ConditionFilterTableColumn,
                ValueFilterTableColumn
            });
            Dock = DockStyle.Fill;
            Location = new System.Drawing.Point(3, 3);
            MultiSelect = false;
            Name = "dataGridViewFilters";
            RowTemplate.Height = 24;
            Size = new System.Drawing.Size(994, 181);
            TabIndex = 1;

            // 
            // UsedFilterTableColumn
            // 
            UsedFilterTableColumn.Frozen = true;
            UsedFilterTableColumn.HeaderText = "Включен";
            UsedFilterTableColumn.Name = "UsedFilterTableColumn";
            // 
            // OperatorFilterTableColumn
            // 
            OperatorFilterTableColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            OperatorFilterTableColumn.Frozen = true;
            OperatorFilterTableColumn.HeaderText = "Связь";
            OperatorFilterTableColumn.Items.AddRange(stringValueToOperator.Keys.ToArray());
            OperatorFilterTableColumn.Name = "OperatorFilterTableColumn";
            // 
            // FieldFilterTableColumn
            // 
            FieldFilterTableColumn.Frozen = true;
            FieldFilterTableColumn.HeaderText = "Поле";
            FieldFilterTableColumn.Name = "FieldFilterTableColumn";
            FieldFilterTableColumn.Width = 200;
            // 
            // ConditionFilterTableColumn
            // 
            ConditionFilterTableColumn.Frozen = true;
            ConditionFilterTableColumn.HeaderText = "Условие";
            ConditionFilterTableColumn.Name = "ConditionFilterTableColumn";
            // 
            // ValueFilterTableColumn
            // 
            ValueFilterTableColumn.Frozen = true;
            ValueFilterTableColumn.HeaderText = "Значение";
            ValueFilterTableColumn.Name = "ValueFilterTableColumn";
            ValueFilterTableColumn.Resizable = DataGridViewTriState.True;
            ValueFilterTableColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ValueFilterTableColumn.Width = 200;
        }

        public IEnumerable<FilterStatement> GetFilters()
        {
            var result = new List<FilterStatement>();
            
            foreach (DataGridViewRow row in Rows)
            {
                var isUsedRow = row.Cells["UsedFilterTableColumn"].Value;
                if (isUsedRow == null || (bool) isUsedRow != true) continue;
                
                var condition = stringValueToCondition[row.Cells["ConditionFilterTableColumn"].Value.ToString()];
                var @operator = stringValueToOperator[row.Cells["OperatorFilterTableColumn"].Value.ToString()];
                    
                result.Add(new FilterStatement()
                {
                    Condition = condition,
                    Property = row.Cells["FieldFilterTableColumn"].Value.ToString(),
                    Operator = @operator,
                    Value = row.Cells["ValueFilterTableColumn"].Value
                });
            }

            return result;
        }
    }
}