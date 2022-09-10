using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_product.BL
{
    class ProductBL
    {
        private string name;
        private string category;
        private int price;
        private int AvailableStock;
        private int minStock;
        

        public ProductBL() { }
        public ProductBL(string name,string category,int price,int AvailableStock,int minStock)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.AvailableStock = AvailableStock;
            this.minStock = minStock;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setCategory(string category)
        {
            this.category = category;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setAvailableStock(int AvailableStock)
        {
            this.AvailableStock = AvailableStock;
        }
        public void setMinStock(int minStock)
        {
            this.minStock = minStock;
        }
        public string getName()
        {
            return name;
        }
        public string getCategory()
        {
            return category;
        }
        public int getPrice()
        {
            return price;
        }
        public int getAvailableStock()
        {
            return AvailableStock;
        }
        public int getMinStock()
        {
            return minStock;
        }
        public float calculatetax()
        {
            if (category == "grocery") return (float)(0.10 * price);
            else if (category == "fruit") return (float)(0.5 * price);
            else return (float)(0.15 * price);
        }

    }
}
