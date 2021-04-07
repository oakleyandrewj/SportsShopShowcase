using SportsShopShowcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShopShowcase.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
            new Product {ID = 1, Name="Wigan Athletic Shirt", Price=39.99M, ShortDescription="Lorem Ipsum", LongDescription="Wigan Athletic kit description", Category = _categoryRepository.AllCategories.ToList()[0],ImageURL="", InStock=true, IsOnPromotion=false, ImageThumbnailURL=""},
            new Product {ID = 1, Name="Manchester United Shirt", Price=49.99M, ShortDescription="Lorem Ipsum", LongDescription="Manchester United kit description", Category = _categoryRepository.AllCategories.ToList()[0],ImageURL="", InStock=true, IsOnPromotion=false, ImageThumbnailURL=""},
            new Product {ID = 1, Name="Football Boots", Price=89.99M, ShortDescription="Lorem Ipsum", LongDescription="Football boot description", Category = _categoryRepository.AllCategories.ToList()[1],ImageURL="", InStock=true, IsOnPromotion=true, ImageThumbnailURL=""},
            new Product {ID = 1, Name="Cricket Ball", Price=9.99M, ShortDescription="Lorem Ipsum", LongDescription="Cricket Ball description", Category = _categoryRepository.AllCategories.ToList()[2],ImageURL="", InStock=true, IsOnPromotion=false, ImageThumbnailURL=""}
            };

        public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int ProductId)
        {
            return AllProducts.FirstOrDefault(p => p.ID == ProductId);
        }
    }
}
