using System;
using System.Collections.Generic;
using System.Linq;
using testeP3.Control;
using testeP3.Model;
using testeP3.View;

namespace testeP3
{
    public class Program
    {
        public static PlansList listPlans = new PlansList();
        public static UsersList listUsers = new UsersList();

        public static void Main(string[] args)
        {
            bool programOn = true;

            listUsers.AddUser(new User("Cauê", true));
            listUsers.AddUser(new User("Maria", false));

            listPlans.AddPlan(new Plan("Plano Semestral", 2));
            listPlans.AddPlan(new Plan("Plano Anual", 1));

            string optionMenu;

            while (programOn)
            { 
                ShowData.showMenu();

                optionMenu = Console.ReadLine();

                programOn = MenuFunctions.ReadMenuOption(optionMenu);
            }
        }
    }
}
