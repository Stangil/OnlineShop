using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBackendLibrary.Models
{
    public class Item
    {
        [Key]
        public Guid ItemID { get; set; }
        public int CategoryID { get; set; }
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public decimal? ItemPrice { get; set; }

    }
}
