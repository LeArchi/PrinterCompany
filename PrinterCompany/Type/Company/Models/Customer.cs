using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterCompany.Type.Company.Models
{
    internal class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        public string Middlename { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public string ContactLink { get; set; }
    }
}
