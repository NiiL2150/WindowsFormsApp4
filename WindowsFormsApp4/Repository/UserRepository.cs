using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4.Repository
{
    class UserRepository : IUserRepository
    {
        public string xmlPath { get; set; }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
        List<User> users;

        public UserRepository(string path)
        {
            xmlPath = $@"{path}\users.xml";

            if (!File.Exists(xmlPath))
            {
                XmlFakeRepo();
            }

            users = new List<User>();
            using (var ser = new StreamReader(xmlPath))
            {
                users = (List<User>)xmlSerializer.Deserialize(ser);
            }
        }

        void XmlFakeRepo()
        {
            List<User> userList = new List<User>
            {
                new User("NiiL2150", "real_password"),
                new User("admin", "admin")
            };
            SaveUsers(userList);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserByName(string name)
        {
            return users.Find(x => x.Name == name);
        }

        public void SaveUser(User user)
        {
            User findUser = (users.Find(x => x.Name == user.Name));
            if (findUser == null)
            {
                users.Add(user);
            }
            else
            {
                findUser = user;
            }
            SaveUsers(users);
        }

        public void SaveUsers(List<User> _users)
        {
            using (var ser = new StreamWriter(xmlPath))
            {
                xmlSerializer.Serialize(ser, _users);
            }
        }
    }
}
