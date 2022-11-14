using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApp.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Comment { get; set; }
    }
}
