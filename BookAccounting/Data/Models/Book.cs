using System.Collections.Generic;

namespace BookAccounting.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string BookName { get; set; }
        public string PublishingOfficeName { get; set; }
        public string Theme { get; set; }
        public int? Year { get; set; }
        public int? PageCount { get; set; }
        public string ISBN { get; set; }
        public int Count { get; set; }
        public string CabinetName { get; set; }
        public string RackName { get; set; }
    
        public IEnumerable<IssuedBook> IssuedBooks { get; set; }
    }
}