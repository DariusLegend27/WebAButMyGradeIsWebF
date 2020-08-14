using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloudinary
{
    public class ImageFile
    {
        /// <summary>
        /// The public id used by Cloudinary
        /// </summary>
        public string PublicCloudinaryId { get; set; }
        /// <summary>
        /// File upload version
        /// </summary>
        public int Version { get; set; }
        /// <summary>
        /// The width of the uploaded image
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// The height of the uploaded image
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Image format: JPEG, JPG, PNG
        /// </summary>
        public string Format { get; set; }
        /// <summary>
        /// The size of the uploaded image in bytes
        /// </summary>
        public int ImageSize { get; set; }
        /// <summary>
        /// URL to access the image [HTTP]
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// URL to access the image [HTTPs]
        /// </summary>
        public string SecureUrl { get; set; }
		public DateTime CreatedAt { get; set; }
        /// <summary>
        /// ResourceType can be either image or raw
        /// </summary>
        public string ResourceType { get; set; }
        /// <summary>
        /// FileExtention property stores string information
        /// such as docx pptx xlsx txt etc.
        /// </summary>
        public string FileExtension { get; set; }
        /// <summary>
        /// FileExtention property stores file name
        /// </summary>
        public string FileName { get; set; }
    }
      
}
