using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class CategoryBrand
    {
        //int variables
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int cbId { get; set; }
        public int catId { get; set; }
        public int brandId { get; set; }

        //Relations
        public Category category { get; set; }
        public Brand brand { get; set; }
    }
}
