using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pie.Models
{
    public class ShoppingCart
    {
        [Key]
        public int CartItem { get; set; }
        public Product product { get; set; }
        public int Amount { get; set; }
        public string CartId { get; set; }
    }
}  
