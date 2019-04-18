using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    public class User
    {
        public int id { get; }
        public string name { get; set; }
        public DateTime register_date { get; }
        public DateTime last_changed_date { get; set; }
        public bool can_create_plan { get; set; }
        public bool removed { get; set; }

        private static int aux_users_size = 0;

        public User(string nameP, bool canCreatePlanP)
        {
            id = 1 + aux_users_size;
            name = nameP;
            register_date = DateTime.Now;
            last_changed_date = DateTime.Now;
            can_create_plan = canCreatePlanP;
            removed = false;
            UpAuxUsers();
        }

        private static void UpAuxUsers()
        {
            aux_users_size++;
        }
    }
}
