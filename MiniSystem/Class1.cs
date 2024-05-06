using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSystem
{
    internal class Class1
    {
        public class UserManager
        {
            public String username {  get; set; }
            public String password { get; set; }
            public static IDictionary<String, String> Users = new Dictionary<String, String>();

            public void addAccount(String user, String pass)
            {
                Users.Add(user, pass);
            }
            public Boolean validate(String user, String pass)
            {
                for (int x = 0; x < Users.Count; x++)
                {
                    if (Users.ElementAt(x).Key.Equals(user) && Users.ElementAt(x).Value.Equals(pass))
                    {
                        return true;
                    };

                }
                return false;
            }
        }
    }
}
