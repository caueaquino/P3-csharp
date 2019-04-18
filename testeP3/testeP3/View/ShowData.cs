using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Control;
using testeP3.Model;

namespace testeP3.View
{
    public static class ShowData
    {
        public static bool showMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ----- Menu Principal ----- ");
            Console.WriteLine();

            Console.WriteLine(" Escolha uma opção:");
            Console.WriteLine();

            Console.WriteLine(" 1 - Gerenciar Planos");
            Console.WriteLine(" 2 - Gerenciar Usúarios");
            Console.WriteLine(" 3 - Gerenciar Tipos de Plano");
            Console.WriteLine(" 4 - Gerenciar Status de Plano");
            Console.WriteLine(" 0 - Sair");

            Console.WriteLine();

            Console.Write(" Opção: ");

            return MenuFunctions.ReadMainMenu(Console.ReadLine());
        }

        public static void ShowPlanStatusList()
        {
            Console.WriteLine();
            Console.WriteLine("Lista de Status dos Planos:");
            Console.WriteLine();

            foreach (var item in PlanStatus.getPlanStatusList())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }

        public static void ShowPlanList(IDictionary<String, Plan> planListP)
        {
            if (planListP == null)
            {
                throw new ArgumentNullException(nameof(planListP));
            }

            Console.WriteLine();
            Console.WriteLine("Lista Planos:");
            Console.WriteLine();

            foreach (var plan in planListP)
            {
                Console.WriteLine($"ID: {plan.Value.id}");
                Console.WriteLine($"Nome: {plan.Value.name}");
                Console.WriteLine($"ID Tipo: {plan.Value.id_type}");
                Console.WriteLine($"ID Status: {plan.Value.id_status}");
                Console.WriteLine($"ID Usúario(Responsável): {plan.Value.id_user}");
                Console.WriteLine($"Data de início: {plan.Value.start_date}");
                Console.WriteLine($"Data de término: {plan.Value.end_date}");
                Console.WriteLine($"Descrição: {plan.Value.description}");
                Console.WriteLine($"Custo: {plan.Value.cost}");

                Console.WriteLine();
            }
        }

        public static void ShowPlanbyId(string IdP, IDictionary<String, Plan> listPlanP)
        {
            if (listPlanP == null)
            {
                throw new ArgumentNullException(nameof(listPlanP));
            }

            Plan plan;

            listPlanP.TryGetValue(IdP, out plan);

            Console.WriteLine();
            Console.WriteLine("Plano:");
            Console.WriteLine();

            Console.WriteLine($"ID: {plan.id}");
            Console.WriteLine($"Nome: {plan.name}");
            Console.WriteLine($"ID Tipo: {plan.id_type}");
            Console.WriteLine($"ID Status: {plan.id_status}");
            Console.WriteLine($"ID Usúario(Responsável): {plan.id_user}");
            Console.WriteLine($"Data de início: {plan.start_date}");
            Console.WriteLine($"Data de término: {plan.end_date}");
            Console.WriteLine($"Descrição: {plan.description}");
            Console.WriteLine($"Custo: {plan.cost}");

            Console.WriteLine();
        }

        public static void ShowUserList(IDictionary<string, User> listUsersP)
        {
            if (listUsersP == null)
            {
                throw new ArgumentNullException(nameof(listUsersP));
            }

            Console.WriteLine();
            Console.WriteLine("Lista Usúarios:");
            Console.WriteLine();

            foreach (var user in listUsersP)
            {
                Console.WriteLine($"ID: {user.Value.id}");
                Console.WriteLine($"Nome: {user.Value.name}");
                Console.WriteLine($"Data de criação: {user.Value.register_date}");
                Console.WriteLine($"Ultima modificação: {user.Value.last_changed_date}");
                Console.WriteLine($"Pode criar plano: {user.Value.can_create_plan}");
                Console.WriteLine($"Removido: {user.Value.removed}");

                Console.WriteLine();
            }
        }

        public static void ShowUserById(string IdP, IDictionary<string, User> listUsersP)
        {
            if (listUsersP == null)
            {
                throw new ArgumentNullException(nameof(listUsersP));
            }

            User user;

            listUsersP.TryGetValue(IdP, out user);
            
            Console.WriteLine();
            Console.WriteLine("Usúario:");
            Console.WriteLine();

            Console.WriteLine($"ID: {user.id}");
            Console.WriteLine($"Nome: {user.name}");
            Console.WriteLine($"Data de criação: {user.register_date}");
            Console.WriteLine($"Ultima modificação: {user.last_changed_date}");
            Console.WriteLine($"Pode criar plano: {user.can_create_plan}");
            Console.WriteLine($"Removido: {user.removed}");

            Console.WriteLine();
        }
    }
}
