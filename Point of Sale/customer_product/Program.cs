using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_product.UI;
using customer_product.BL;
using customer_product.DL;

namespace customer_product
{
    class Program
    {
        static void Main(string[] args)
        {
            MUserDL.load();
            ProductDL.load();
            int option = 0;
            do
            {
                option = MUserUI.MainMenu();
                if (option == 1)
                {
                 string role = MUserDL.isValidUser(MUserUI.takeSignInInput());
                    if(role == "admin")
                    {
                        int admin_option = 0;
                        do
                        {
                            admin_option = MUserUI.adminMenu();
                            if (admin_option == 1)
                            {
                                ProductDL.addNewProduct((ProductUI.takeUserInput()));
                            }
                            else if (admin_option == 2)
                            {
                                ProductUI.viewProducts(ProductDL.getProductList());
                            }
                            else if (admin_option == 3)
                            {
                                ProductUI.printString(ProductDL.findProductWithHighestPrice());
                            }
                            else if (admin_option == 4)
                            {
                                ProductUI.printFloat(ProductDL.taxOnAllProducts());
                            }
                            else if (admin_option == 5)
                            {
                                ProductUI.viewProducts(ProductDL.productsToBeOrdered());
                            }
                        }
                        while (admin_option != 6);
                    }
                    else if(role == "customer")
                    {
                        int customer_option = 0;
                        do {
                            customer_option = MUserUI.customerMenu();
                            if(customer_option == 1)
                            {
                                ProductUI.viewProducts(ProductDL.getProductList());
                            }
                            else if (customer_option == 2)
                            {
                                CustomerDL.buyProduct(ProductDL.isAvailable(CustomerUI.takeCustomerInput()));
                            }
                            else if (customer_option == 3)
                            {
                                CustomerUI.printInvoice(CustomerDL.priceOfAllProductsCust(),CustomerDL.taxOnAllProductsCust(),CustomerDL.totalBill());
                            }
                        } while (customer_option != 4);

                    }
                }
                else if(option == 2)
                {
                    MUserDL.addNewUser(MUserUI.takeSignUpInput());
                }
            }
            while (option != 3);
            MUserDL.store();
            ProductDL.store();
        }
    }
}
