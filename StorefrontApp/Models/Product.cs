using System;
namespace StorefrontApp.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }

		public Product()
		{
		}
	}
}

