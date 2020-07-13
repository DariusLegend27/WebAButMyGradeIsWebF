using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class Brand
    {
        //int variables
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int brandId { get; set; }
        public int? numOfProd { get; set; }
        public int? deleted { get; set; }

        //DateTime Variables
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public DateTime? deletedAt { get; set; }

        //String variables
        public string brandName { get; set; }
        public string brandImgUrl { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
        public string deletedBy { get; set; }

        //Relations
        public List<Product> Products { get; set; }
        public List<CategoryBrand> categoryBrands { get; set; }
    }
}
