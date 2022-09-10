using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customer_product.UI;
using customer_product.BL;
using System.IO;

namespace customer_product.DL
{
    class MUserDL
    {
        static public List<MUserBL> newUsers = new List<MUserBL>();
        public static void addNewUser(MUserBL x)
        {
            newUsers.Add(x);
        }
        public static string isValidUser(MUserBL x)
        {
            for(int i = 0; i < newUsers.Count; i++)
            {
                if(x.getUsername() == newUsers[i].getUsername() && x.getPassword() == newUsers[i].getPassword())
                {
                    return newUsers[i].getRole();
                }
            }
            return null;
        }
        public static void store()
        {
            StreamWriter file = new StreamWriter("Users.txt");
            foreach (var v in newUsers)
            {
                file.WriteLine(v.getUsername() + "," + v.getPassword() + "," + v.getRole());
            }
            file.Flush();
            file.Close();
        }
        public static void load()
        {
            StreamReader file = new StreamReader("Users.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                MUserBL temp = new MUserBL(record[0], record[1],record[2]);
                newUsers.Add(temp);
            }
            file.Close();
        }
    }
}
