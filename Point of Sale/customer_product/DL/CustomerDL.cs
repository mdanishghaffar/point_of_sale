using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_product.BL;
using customer_product.DL;

namespace customer_product.DL
{
    class CustomerDL
    {
        public static List<ProductBL> ListProductBuy = new List<ProductBL>();
        public static void decreaseStock(ProductBL x)
        {
            x.setAvailableStock(x.getAvailableStock() -1);
        }
        public static void buyProduct(ProductBL name)
        {
            ListProductBuy.Add(name);
            decreaseStock(name);
        }
        public static float taxOnAllProductsCust()
        {
            float taxOnAllProducts = 0;
            for (int i = 0; i < ListProductBuy.Count; i++)
            {
                if (ProductDL.isAvailableBool(ListProductBuy[i].getName()))
                {
                    taxOnAllProducts = taxOnAllProducts + ListProductBuy[i].calculatetax();
                }
                }
            return taxOnAllProducts;
        }
        public static float priceOfAllProductsCust()
        {
            float price = 0;
            for (int i = 0; i < ListProductBuy.Count; i++)
            {
                price = price + ListProductBuy[i].getPrice();
            }
            return price;
        }
        public static float totalBill()
        {
            float total = priceOfAllProductsCust() - taxOnAllProductsCust();
            return total;
        }
        public static List<ProductBL> getProductBuyList()
        {
            return ListProductBuy;
        }
    }
}
