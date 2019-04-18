using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;

namespace testeP3.Control
{
    public class UsersList
    {
        private IDictionary<string, User> UserList;

        public UsersList()
        { 
            UserList = new Dictionary<string, User>();
        }

    public void AddUser(User userP)
        {
            UserList.Add(userP.id.ToString(), userP);
        }

        public User GetUserById(string IdP)
        {
            return UserList[IdP];
        }

        public IDictionary<string, User> GetUserList()
        {
            return UserList;
        }

        public void removeUser(string IdP)
        {
            UserList.Remove(IdP);
        }
    }
}
