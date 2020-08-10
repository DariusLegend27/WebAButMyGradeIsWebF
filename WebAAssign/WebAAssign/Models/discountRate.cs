using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class discountRate
    {
        //int variables
        [Key]
        public int discId { get; set; }

        //Decimal Variables
        public decimal discRate { get; set; }

        //String variables
        public string discName { get; set; }

        //Relations
        public List<productDiscountRate> productDiscountRates { get; set; }
        //public productDetail {get; set;}
    }
}
