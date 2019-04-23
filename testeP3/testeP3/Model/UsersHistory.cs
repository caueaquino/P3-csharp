using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    public class UsersHistory
    {
        public int id { get; }
        public int id_user { get; }
        public bool status { get; }

        public bool create_new_plan { get; }
        public DateTime date { get; }
        

        public UsersHistory(int id, int id_user, bool status, bool create_new_plan, DateTime date)
        {
            this.id = id;
            this.id_user = id_user;
            this.status = status;
            this.create_new_plan = create_new_plan;
            this.date = date;
        }
    }
}
