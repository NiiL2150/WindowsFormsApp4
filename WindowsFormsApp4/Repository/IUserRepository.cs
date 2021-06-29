using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Model;

namespace WindowsFormsApp4.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserByName(string name);
        void SaveUser(User user);
        void SaveUsers(List<User> users);
    }
}
