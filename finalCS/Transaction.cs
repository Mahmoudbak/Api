using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalCS
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Quantity { get; set; }

        [ MaxLength(50)]
        public string? Type { get; set; } // "Purchase" or "Sale"

        [MaxLength(255)]
        public string? Notes { get; set; }

        public int? CustomerID { get; set; }

        [ForeignKey("ProductID")]
        public Product? Product { get; set; }

        [ForeignKey("CustomerID")]
        public Customer? Customer { get; set; }
    }
}
