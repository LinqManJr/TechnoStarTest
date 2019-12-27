using System;

namespace Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int AuthorId { get; set; }        
    }
}
