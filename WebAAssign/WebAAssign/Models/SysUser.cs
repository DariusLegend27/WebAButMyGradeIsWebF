using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAAssign.Models
{
    public class SysUser
    {
        //int variables
        [Key]
        public int userId { get; set; }

        //String variables
        public string userName { get; set; }
        public string userPassHash { get; set; }
        public string userPassSalt { get; set; }
    }
}
