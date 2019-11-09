using System.Collections.Generic;

namespace BookAccounting.Data.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    
        public IEnumerable<IssuedBook> IssuedBooks { get; set; }
    }
}