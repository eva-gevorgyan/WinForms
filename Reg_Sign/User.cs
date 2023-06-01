using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_Sign
{
    public class User
    {
        string username, password;
        List<User> users = new List<User>();
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User(){}
        public void SaveInfo(string username, string password)
        {
            users.Add(new User(username, password));
        }
        public bool IsUsernameTaken(string username)
        {
            return users.Any(user => user.username == username);
        }
        public bool Authenticate(string username, string password)
        {
            return users.Any(user => user.username == username && user.password == password);
        }
    }
}
