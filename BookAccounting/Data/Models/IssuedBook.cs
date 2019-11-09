namespace BookAccounting.Data.Models
{
    public class IssuedBook
    {
        public int Id { get; set; }
        public int IdReader { get; set; }
        public int IdBook { get; set; }
        public System.DateTime DateIssue { get; set; }
        public System.DateTime DateReturn { get; set; }
    
        public Book Book { get; set; }
        public Reader Reader { get; set; }
    }
}