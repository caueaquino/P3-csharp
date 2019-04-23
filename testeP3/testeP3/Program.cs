using System;
using testeP3.Control;
using testeP3.Model;
using testeP3.View;

namespace testeP3
{
    public class Program
    {
        public static PlansList listPlans = new PlansList();
        public static PlansHistoryList listPlansHistory = new PlansHistoryList();
        public static UsersList listUsers = new UsersList();
        public static UsersHistoryList listUsersHistory = new UsersHistoryList();
        public static TypesList listTypes = new TypesList();
        public static StatusList listStatus = new StatusList();

        public static void Main(string[] args)
        {
            bool programOn = true;

            while (programOn)
            {
                programOn = ShowData.showMenu();
            }
        }
    }
}
