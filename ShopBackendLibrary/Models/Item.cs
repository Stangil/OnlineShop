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
        public Guid ItemId { get; set; }
        public Guid CategoryId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }

    }
}
