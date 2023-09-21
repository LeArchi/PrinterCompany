using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterCompany.Type.Company.Models
{
    internal class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal CostUSD { get; set; }

        [Required]
        public decimal CostUAH { get; set; }

        [Required]
        public decimal PrepaymentUSD { get; set; }

        [Required]
        public decimal PrepaymentExchangeRate { get; set; }

        [Required]
        public decimal PrepaymentUAH { get; set; }

        [Required]
        public decimal LeftoverUSD { get; set; }

        [Required]
        public decimal LeftoverUAH { get; set; }

        [Required]
        public decimal LeftoverExchangeRate { get; set; }

        public decimal Discount { get; set; }

        public decimal Debt { get; set; }
    }
}
