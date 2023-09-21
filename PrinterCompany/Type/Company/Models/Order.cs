using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterCompany.Type.Company.Models
{
    internal class Order
    {
        [Key]
        public int Id { get; set; }

        [Timestamp]
        public Byte[] TimeCreated { get; set; }

        [Required]
        public DateOnly DueDate { get; set; }

        [Required]
        [ForeignKey("Customer")] 
        public int CustomerId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey("Payment")]
        public int PaymentId { get; set; }

        [Required]
        public bool IsSent { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public decimal DeliveryCost { get; set; }

        public string DeliveryTrackingNumber { get; set; }
    }
}
