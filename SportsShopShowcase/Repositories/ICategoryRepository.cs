using SportsShopShowcase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShopShowcase.Repositories
{
	public interface ICategoryRepository
	{ 
		IEnumerable<Category> AllCategories { get; }
	}
}
