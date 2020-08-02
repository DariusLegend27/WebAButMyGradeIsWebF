using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class productDetail
    {
        //int variables
        [Key]
        public int productDetailId { get; set; }

        //Decimal Variables
        public decimal weightAmount { get; set; }
        public decimal price { get; set; }

        //String variables
        public string weightUnit { get; set; }

        //Relations
        public Brand Brand { get; set; }
        public Product Product {get; set;}
    }
}
