using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_product.BL;
using customer_product.DL;

namespace customer_product.UI
{
    class MUserUI
    {
        static public int MainMenu()
        {
            Console.WriteLine("1.SignIn");
            Console.WriteLine("2.SignUp");
            Console.WriteLine("Exit");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static public int adminMenu()
        {
            Console.WriteLine("1.Add Product.");
            Console.WriteLine("2.View All Products.");
            Console.WriteLine("3.Find Product with Highest Unit Price.");
            Console.WriteLine("4.View Sales Tax of All Products.");
            Console.WriteLine("5.Products to be Ordered. (less than threshold)");
            Console.WriteLine("6.Exit");
            int admin_option = int.Parse(Console.ReadLine());
            return admin_option;
        }
        static public int customerMenu()
        {
            Console.WriteLine("1.View all the products");
            Console.WriteLine("2.Buy the products");
            Console.WriteLine("3.Generate invoice");
            Console.WriteLine("4.Exit");
            int customer_option = int.Parse(Console.ReadLine());
            return customer_option;
        }
        static public MUserBL takeSignUpInput()
        {
            MUserBL user = new MUserBL();
            Console.WriteLine("Enter Name");
            user.setUsername(Console.ReadLine());
            Console.WriteLine("Enter Password:");
            user.setPassword(Console.ReadLine());
            Console.WriteLine("Enter role:");
            user.setRole(Console.ReadLine());

            return user;
        }
        static public MUserBL takeSignInInput()
        {

            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            MUserBL isValid = new MUserBL(username, password);
            return isValid;
        }
    }
}
