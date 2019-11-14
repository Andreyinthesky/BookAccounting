namespace BookAccounting.Data.Models
{
    public class IssuedBookView
    {
        public int Id { get; set; }
        public int IdBook { get; set; }
        public string BookAuthorName { get; set; }
        public string BookName { get; set; }
        public System.DateTime DateIssue { get; set; }
        public System.DateTime DateReturn { get; set; }
        public int IdReader { get; set; }
        public string ReaderName { get; set; }
        public string ReaderSurname { get; set; }
        public string ReaderPatronymic { get; set; }
    }
}