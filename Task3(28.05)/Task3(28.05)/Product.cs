using System;
namespace task3
{
	public class Product
	{
		public string ProductType;
		public string Code;
		public string Name;
		public double Price;
		public double DiscountedPrice;
		public int TotalCount = 0;
		public int codeOrder = 1000;

        
        public Product(string producttype, string productname, double price, int order, int counter)
		{
			ProductType = producttype;
			codeOrder += order;
			Code = producttype[0].ToString() + codeOrder.ToString();
			Name = productname;
			Price = price;
            DiscountedPrice = Price - (Price / 10);
            if(producttype == "Bakery")
			{
				Price = DiscountedPrice;
			}
        }
	}
}