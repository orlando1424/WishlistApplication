using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishlistApplication.Models
{
    public class Wishlist
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal Cost { get; set; }
    }
}
