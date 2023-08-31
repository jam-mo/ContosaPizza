using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosaPizza.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!; // counter to .net6 enabling all nulls by default

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
