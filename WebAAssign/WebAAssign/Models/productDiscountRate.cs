using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class productDiscountRate
    {
        //int variables
        [Key]
        public int Id { get; set; }
        public int discountId { get; set; }
        public int prodId { get; set; }

        //Relations
        public discountRate discountRate { get; set; }
        public Product Product {get; set;}
    }
}
