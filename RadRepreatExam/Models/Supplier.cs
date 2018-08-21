using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadRepreatExam.Models
{

    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "SupplierID")]
        public int supplierID { get; set; }

        [Display(Name = "SupplierName")]
        public string supplierName { get; set; }

        [Display(Name = "SupplierAddressLineOne")]
        public string supplierAddressLineOne{ get; set; }

        [Display(Name = "SupplierAddressLineTwo")]
        public string supplierAddressLineTwo { get; set; }

        public virtual ICollection<SupplierProduct> SuppliersProducts { get; set; }
        //used to create a collection
        //Supplier HAS products

    }
}