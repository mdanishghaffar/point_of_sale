using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_product.DL;
using customer_product.BL;

namespace customer_product.UI
{
    class CustomerUI
    {
        public static ProductBL takeCustomerInput()
        {
            ProductBL xyz = new ProductBL();
            Console.WriteLine("Enter name of the product you want to buy:");
            xyz.setName(Console.ReadLine());
            string name = Console.ReadLine();
            if (ProductDL.isAvailableBool(xyz.getName()))
            {
                return xyz;
            }
            return null;
        }
        public static void viewAllProductsBuy(List<ProductBL> listProductsBuy)
        {
            for (int i = 0; i < listProductsBuy.Count; i++)
            {
                Console.WriteLine("Item:{0}{1}", i + 1, listProductsBuy[i].getName());
            }
        }
        public static void printInvoice(float x,float y,float z) {

            viewAllProductsBuy(CustomerDL.getProductBuyList());
            Console.WriteLine("Price: {0}",x);
            Console.WriteLine("GST: {0}", y);
            Console.WriteLine("Total Price: {0}", z);
        }

    }
}
