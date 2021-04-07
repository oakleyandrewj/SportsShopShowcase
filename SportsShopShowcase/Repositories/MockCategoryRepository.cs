using SportsShopShowcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShopShowcase.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
            new Category{CategoryId=1, CategoryName="Kits", Description="Kits from your favourite teams"},
            new Category{CategoryId=2, CategoryName="Footwear", Description="Footwear for all sports"},
            new Category{CategoryId=3, CategoryName="Balls", Description="Balls for all sports"}
            };
    }
}
