using SportsShopShowcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShopShowcase.Repositories
{
	public interface IProductRepository
	{
		IEnumerable<Product> AllProducts { get; }
		IEnumerable<Product> ProductsOfTheWeek { get; }
		Product GetProductById(int productId);
	}

}
