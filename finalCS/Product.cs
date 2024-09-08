﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalCS
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [Required, Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
