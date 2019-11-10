namespace BookAccounting.FilterBuilder.FilterParameters
{
    public enum Condition
    {
        // number
        Greater = 0,
        GreaterOrEqual,
        Less,
        LessOrEqual,
        Equal,
        
        // string
        StartsWith,
        Contains,
        DoesNotContains,
    }
}