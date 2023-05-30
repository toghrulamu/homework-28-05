namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            creatProduct();
            

            #region creatProd
            //    Console.WriteLine("Enter ProductType:");

            //    foreach (var item in Enum.GetValues(typeof(productType)))
            //    {
            //        Console.WriteLine($"{(byte)item} {item}");
            //    }
            //getnum:
            //    string numStr = Console.ReadLine();
            //    byte num;

            //    while (!byte.TryParse(numStr, out num))
            //    {
            //        Console.WriteLine("enter correct type:");
            //        numStr = Console.ReadLine();
            //    }
            //    if (num <= 0 && 4 > num)
            //    {
            //        Console.WriteLine("number must be between 1 and 4:");
            //        goto getnum;
            //    }
            #endregion
            

            Console.ReadLine();
        }
        static void creatProduct()
        {
            Product[] products = new Product[1];
            int totalProduct = 0;
            for (int i = 0; i < products.Length; i++)
            {

                Console.WriteLine("Enter ProductType:");

                foreach (var item in Enum.GetValues(typeof(productType)))
                {
                    Console.WriteLine($"{(byte)item} {item}");
                }
            getnum:
                string numStr = Console.ReadLine();
                byte num;

                while (!byte.TryParse(numStr, out num))
                {
                    Console.WriteLine("enter correct type:");
                    numStr = Console.ReadLine();
                }
                if (num <= 0 || num > 4)
                {
                    Console.WriteLine("number must be between 1 and 4:");
                    goto getnum;
                }
                Console.WriteLine("Enter product name:");
                string prodName = Console.ReadLine();

                Console.WriteLine("Enter Product Price:");
                getprice:
                string priceStr = Console.ReadLine();
                double price;

                while (!double.TryParse(priceStr, out price))
                {
                    Console.WriteLine("enter correct type:");
                    goto getprice;
                }
                

                Product product = new Product($"{(productType)num}", prodName, price, i, i);
                totalProduct++;
                product.TotalCount = totalProduct;
                products[i] = product;
                Console.WriteLine("Do you want to add product\ny/n");
                string checker = Console.ReadLine();
                if (checker == "n")
                {
                    break;
                }
                Array.Resize(ref products, products.Length + 1);
            }

            //Console.WriteLine(products[0].Code + products[0].Name + products[0].ProductType + products[0].Price);
            //Console.WriteLine(products[1].Code + products[1].Name + products[1].ProductType + products[1].Price);

            
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Code:{products[i].Code} Type:{products[i].ProductType} Name:{products[i].Name} Price:{products[i].Price}");
            }
            Console.WriteLine($"Total Product: {products[products.Length - 1].TotalCount}");
        }
        
    }
}