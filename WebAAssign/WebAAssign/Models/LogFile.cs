using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cloudinary;
namespace WebAAssign.Models
{   //Observe that the class inherits the ImageFile class which is
    //residing inside the Cloudinary namespace.
    public class LogFile : ImageFile
    {
        /// <summary>
        /// Primary key of the database table
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        public string Description { get; set; } //To describe the purpose of the file
    }//End of LogFile class
}//End of namespace
