using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterCompany.Type.Company.Models
{
    internal class Product 
    {
        [Key]
        public int Id { get; set; }

        [Required] 
        public string Type { get; set; }

        [Required]
        public string Size { get; set; }

        [Required]
        public string Description { get; set; }

        public string Color { get; set; }

        [Required]
        public string Model { get; set; }
    }
}
