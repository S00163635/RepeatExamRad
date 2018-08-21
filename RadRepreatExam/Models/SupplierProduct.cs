using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadRepreatExam.Models
{
    [Table("SupplierProduct")]
    public class SupplierProduct
    {
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "SupplierID")]
        public int supplierID { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("ProductID")]
        public int? productID { get; set; }

        [Key, Column(Order = 3)]
        [ForeignKey("BookID")]
        public int? bookID { get; set; }


        public virtual Supplier SupplierID { get; set; }
        public virtual Product ProductID { get; set; }
        //(this line is used to connect the categoryID with the two tables Supplier & Product (FK + PK)

    }
}