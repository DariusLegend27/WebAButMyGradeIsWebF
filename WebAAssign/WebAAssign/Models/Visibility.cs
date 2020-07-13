using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class Visibility
    {
        //int variables
        [Key]
        public int visId { get; set; }

        //String variables
        public string visRole { get; set; }

        //Relations
        public List<Category> categories { get; set; }
    }
}
