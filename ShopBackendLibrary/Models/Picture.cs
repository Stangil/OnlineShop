using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBackendLibrary.Models
{
    public class Picture
    {
        public Guid PictureID { get; set; }
        public Guid ItemID { get; set; }
        public string? ImagePath { get; set; } = string.Empty; 
    }
}
