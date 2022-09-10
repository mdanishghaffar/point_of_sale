using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_product.BL
{
    class MUserBL
    {
        private string username;
        private string password;
        private string role;
        public MUserBL(string username,string password,string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public MUserBL(string username, string password)
        {
            this.username = username;
            this.password = password;
           
        }


        public MUserBL()
        {

        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getRole()
        {
            return role;
        }
        public void setRole(string role)
        {
            this.role = role;
        }

    }
}
