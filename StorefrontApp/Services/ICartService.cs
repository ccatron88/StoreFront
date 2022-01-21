using System;
using StorefrontApp.Models;

namespace StorefrontApp.Services
{
	public interface ICartService
	{
		IList<Product> Cart { get; }
		double Total { get; set; }
		event Action OnChange;
		void AddProduct(Product product);
		void DeleteProduct(Product product);
	}
}

