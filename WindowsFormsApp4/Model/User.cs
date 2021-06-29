using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Model
{
    public class User
    {
        public User()
        {

        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
            Posts = new List<string>();
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public List<string> Posts { get; set; }
    }
}
