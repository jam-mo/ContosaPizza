using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosaPizza.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!; // non-nullable strings, EF knows when it created the table, these columns shouldnt allow nulls
        public string LastName { get; set; } = null!;

        public string? Address { get; set; } // nullable strings, will allow null in these columns
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public ICollection<Order> Orders { get; set; } = null!; // navigation property, user may have 0 or 1 orders

    }
}
