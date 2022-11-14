using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApp.Models
{
    public class Equipment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string StatusName { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int Quantity { get; set; }
        public string TypeName { get; set; }
    }
}
