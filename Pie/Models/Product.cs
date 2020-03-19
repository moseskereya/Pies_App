using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ThumbNail { get; set; }
        public string Imgurl { get; set; }
        public Category Category { get; set; }
    }
}
