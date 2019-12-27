using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dto
{
    public class AuthorResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CountryName { get; set; }
    }
}
