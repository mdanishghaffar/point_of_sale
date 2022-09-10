using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_product.BL;
using System.IO;


namespace customer_product.DL
{
    class ProductDL
    {
        public static List<ProductBL> ListProduct = new List<ProductBL>();
        public static void addNewProduct(ProductBL x)
        {
            ListProduct.Add(x);
        }
        public static List<ProductBL> productsToBeOrdered()
        {
            List<ProductBL> productsToBeOrdered = new List<ProductBL>();
            foreach(ProductBL x in ListProduct)
            {
                if(x.getAvailableStock() <= x.getMinStock())
                {
                    productsToBeOrdered.Add(x);
                }
            }
            return productsToBeOrdered;
        }
        public static List<ProductBL> getProductList()
        {
            return ListProduct;
        }
        public static string findProductWithHighestPrice()
        {
            int max = ListProduct[0].getPrice();
            string nameOfMax = null;
            for(int i = 0; i < ListProduct.Count; i++)
            {
                if(ListProduct[i].getPrice() > max)
                {
                    max = ListProduct[i].getPrice();
                    nameOfMax = ListProduct[i].getName();
                }

            }
            return nameOfMax;
        }
        public static ProductBL isAvailable(ProductBL name)
        {
            for(int i = 0; i < ListProduct.Count; i++)
            {
                if(name.getName() == ListProduct[i].getName())
                {
                    return name;
                }
            }
            return null;
        }
        public static bool isAvailableBool(string name)
        {
            for (int i = 0; i < ListProduct.Count; i++)
            {
                if (name == ListProduct[i].getName())
                {
                    return true;
                }
            }
            return false;
        }
        public static float taxOnAllProducts()
        {
            float taxOnAllProducts = 0;
            for(int i = 0; i < ListProduct.Count; i++)
            {
                taxOnAllProducts = taxOnAllProducts + ListProduct[i].calculatetax();
            }
            return taxOnAllProducts;
        }
        public static void store()
        {
            StreamWriter file = new StreamWriter("products.txt");
            foreach(var v in ListProduct)
            {
                file.WriteLine(v.getName() + "," + v.getCategory() + "," + v.getPrice() + "," + v.getAvailableStock() + "," + v.getMinStock());
            }
            file.Flush();
            file.Close();
        }
        public static void load()
        {
            StreamReader file = new StreamReader("products.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                ProductBL temp = new ProductBL(record[0],record[1],int.Parse(record[2]),int.Parse(record[3]),int.Parse(record[4]));
                ListProduct.Add(temp);
            }
            file.Close();
        }
        
    }
}
