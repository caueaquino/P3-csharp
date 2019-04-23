using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;

namespace testeP3.Control
{
    public class UsersHistoryList
    {
        private IList<UsersHistory> UserHistoryList;

        public UsersHistoryList()
        {
            UserHistoryList = new List<UsersHistory>();

            foreach (var item in DataBase.cnn.Query<UsersHistory>("SELECT * FROM users_history"))
            {
                UserHistoryList.Add(item);
            }
        }

        public IList<UsersHistory> GetUserHistoryList()
        {
            return UserHistoryList;
        }
    }
}
