using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RadRepreatExam.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "CategoryID")]
        public int categoryID { get; set; }


        public virtual ICollection<Product> ProductsInCategory { get; set; }
        //used to create a collection
        //Category CONTAINS products
    }
}