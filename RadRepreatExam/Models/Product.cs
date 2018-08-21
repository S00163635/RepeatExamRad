using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadRepreatExam.Models
{

    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ProductID")]
        public int productID { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }

        [Display(Name = "QuantityInStock")]
        public int quantityInStock { get; set; }

        [Display(Name = "UnitPrice")]
        public float unitPrice { get; set; }

        [ForeignKey("CategoryID")]
        public int? categoryID { get; set; }

        public virtual Category CategoryID { get; set; }


    }
}