using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class Product
    {
        //int variables
        [Key]
        public int prodId { get; set; }
        public int brandId { get; set; }
        public int? published { get; set; }
        public int? minQty { get; set; }
        public int? prodQty { get; set; }
        public int? deleted { get; set; }

        //DateTime Variables
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public DateTime? deletedAt { get; set; }

        //String variables
        public string prodName { get; set; }
        public string prodCode { get; set; }
        public string prodImgUrl { get; set; }
        public string prodDesc { get; set; }
        public string prodIngredients { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
        public string deletedBy { get; set; }
        public string guaranteedAnalysis { get; set; }

        //Relations
        public Brand Brand { get; set; }
        public List<productDiscountRate> productDiscountRates {get; set;}
        public List<productDetail> productDetails { get; set; }
    }
}
