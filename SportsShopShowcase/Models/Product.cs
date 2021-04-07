using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShopShowcase.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public string ImageThumbnailURL { get; set; }
        public bool IsOnPromotion { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }
    }


    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Pies { get; set; }
    }
}
