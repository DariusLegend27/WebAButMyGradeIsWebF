using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class Category
    {
        //int variables
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int catId { get; set; }
        public int? parentCatId { get; set; }
        public int? specialCat { get; set; }
        public int visId { get; set; }
        public int deleted { get; set; }

        //DateTime Variables
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public DateTime? deletedAt { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }

        //String variables
        public string catName { get; set; }
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
        public string deletedBy { get; set; }

        //Relations
        public List<CategoryBrand> categoryBrands { get; set; }
        public Visibility visibility { get; set; }
    }
}
