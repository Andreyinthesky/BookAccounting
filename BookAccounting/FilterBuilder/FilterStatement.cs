using BookAccounting.FilterBuilder.FilterParameters;

namespace BookAccounting.FilterBuilder
{
    public class FilterStatement
    {
        public Operator Operator { get; set; }
        public string Property { get; set; }
        public Condition Condition { get; set; }
        public object Value { get; set; }
    }
}
