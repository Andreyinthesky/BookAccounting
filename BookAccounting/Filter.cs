namespace BookAccounting
{
    public class Filter
    {
        public string Operator { get; set; }
        public string Field { get; set; }
        public string Condition { get; set; }
        public object Value { get; set; }
    }
}
