using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_product.BL;

namespace customer_product.UI
{
    class ProductUI
    {
        
        public static ProductBL takeUserInput() {
            ProductBL product = new ProductBL();
            Console.WriteLine("Enter Product Name:");
            product.setName(Console.ReadLine());
            Console.WriteLine("Enter Product Category:");
            product.setCategory(Console.ReadLine());
            Console.WriteLine("Enter Product Price:");
            product.setPrice(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Available Stock Quantity:");
            product.setAvailableStock(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Minimun Stock Threshold:");
            product.setMinStock(int.Parse(Console.ReadLine()));
            return product;

        }
        public static void viewProducts(List<ProductBL> listProducts)
        {
            for(int i=0;i<listProducts.Count;i++)
            {
                Console.WriteLine("Item:{0}{1}",i+1,listProducts[i].getName());
            }
        }
        public static void printString(string x)
        {
            Console.WriteLine("Item: {0}",x);
        }
        public static void printFloat(float y)
        {
            Console.WriteLine(y);
        }
    }
}
