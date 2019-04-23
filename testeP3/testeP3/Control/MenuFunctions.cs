using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;
using testeP3.View;

namespace testeP3.Control
{
    public class MenuFunctions
    {
        public static bool ReadMainMenu(string menuOption)
        {
            bool mainMenuOn = true;

            while (mainMenuOn)
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();

                switch (menuOption)
                {
                    case "1":
                        Console.WriteLine(" ----- Menu Planos ----- ");
                        Console.WriteLine();

                        Console.WriteLine(" Escolha uma opção:");
                        Console.WriteLine();

                        Console.WriteLine(" 1 - Cadastrar Plano");
                        Console.WriteLine(" 2 - Remover Plano");
                        Console.WriteLine(" 3 - Visualizar todos os Planos");
                        Console.WriteLine(" 4 - Buscar Plano por ID");
                        Console.WriteLine(" 5 - Editar Plano pelo ID (fazer)");
                        Console.WriteLine(" 6 - Visualizar histórico de Planos");
                        Console.WriteLine(" 7 - Visualizar usúarios relacionados a um Plano (fazer)");
                        Console.WriteLine(" 8 - Visualizar planos relacionados a um Usúario (fazer)");
                        Console.WriteLine(" 9 - Visualizar planos relacionados a um Tipo de Plano (fazer)");
                        Console.WriteLine(" 10 - Visualizar planos relacionados a um Status de Plano (fazer)");
                        Console.WriteLine(" 0 - Voltar");

                        Console.WriteLine();

                        Console.Write(" Opção: ");
                        mainMenuOn = ReadMenuPlans(Console.ReadLine());

                        break;

                    case "2":
                        Console.WriteLine(" ----- Menu Usúarios ----- ");
                        Console.WriteLine();

                        Console.WriteLine(" Escolha uma opção:");
                        Console.WriteLine();

                        Console.WriteLine(" 1 - Cadastrar usúario");
                        Console.WriteLine(" 2 - Remover Usúario");
                        Console.WriteLine(" 3 - Visualizar todos os Usúarios");
                        Console.WriteLine(" 4 - Buscar Usúario por ID");
                        Console.WriteLine(" 5 - Editar Usúario por ID");
                        Console.WriteLine(" 6 - Visualizar histórico de Usúarios");
                        Console.WriteLine(" 0 - Voltar");

                        Console.WriteLine();

                        Console.Write(" Opção: ");
                        mainMenuOn = ReadMenuUsers(Console.ReadLine());

                        break;

                    case "3":
                        Console.WriteLine(" ----- Menu Tipo de Planos ----- ");
                        Console.WriteLine();

                        Console.WriteLine(" Escolha uma opção:");
                        Console.WriteLine();

                        Console.WriteLine(" 1 - Cadastrar Tipo de Plano");
                        Console.WriteLine(" 2 - Remover Tipo de Plano");
                        Console.WriteLine(" 3 - Editar Tupo de Plano por ID");
                        Console.WriteLine(" 4 - Visualizar todos os Tipos de Plano");
                        Console.WriteLine(" 0 - Voltar");

                        Console.WriteLine();

                        Console.Write(" Opção: ");
                        mainMenuOn = ReadMenuTypes(Console.ReadLine());

                        break;

                    case "4":
                        Console.WriteLine(" ----- Menu Status de Planos ----- ");
                        Console.WriteLine();

                        Console.WriteLine(" Escolha uma opção:");
                        Console.WriteLine();

                        Console.WriteLine(" 1 - Cadastrar Status de Plano");
                        Console.WriteLine(" 2 - Remover Status de Plano");
                        Console.WriteLine(" 3 - Editar Status de Plano por ID");
                        Console.WriteLine(" 4 - Visualizar todos os Status de Plano");
                        Console.WriteLine(" 0 - Voltar");

                        Console.WriteLine();

                        Console.Write(" Opção: ");
                        mainMenuOn = ReadMenuStatus(Console.ReadLine());

                        break;

                    case "0":
                        Console.WriteLine("Finalizando Programa !");
                        Console.WriteLine();
                        Console.WriteLine("Tecle enter para confirmar . . .");
                        Console.ReadLine();

                        return false;
                }

            }
            return true;
        }


        public static bool ReadMenuPlans(string menuOption)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            switch (menuOption)
            {
                case "1":
                    Console.WriteLine(" ----- Cadastro de Plano -----");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Preencha os campos abaixo:");
                    Console.WriteLine();
                    Console.Write("Nome: ");
                    string namep = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("ID Usúario(Responsável): ");
                    int idUser = Console.Read();
                    Program.listPlans.AddPlan(new Plan(namep, idUser));
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine(" ----- Remoção de Plano por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Plano desejado: ");
                    Program.listPlans.RemovePlan(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para confirmar . . .");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine(" ----- Exibição dos Planos ----- ");
                    Console.WriteLine();
                    ShowData.ShowPlanList(Program.listPlans.GetPlanList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine(" ----- Mostrar Plano por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Plano desejado: ");
                    string auxIdShow = Console.ReadLine();
                    Console.WriteLine();
                    ShowData.ShowPlanbyId(auxIdShow, Program.listPlans.GetPlanList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "5":
                    Console.WriteLine(" ----- Editar Plano por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Plano desejado: ");
                    String auxIdEdit = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("TO DO");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "6":
                    Console.WriteLine();
                    Console.WriteLine();
                    ShowData.ShowPlanHistory();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "7":
                    Console.WriteLine(" ----- Usúarios relacionados a um Plano ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Plano desejado: ");
                    String auxIdPlan = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("TO DO");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "8":
                    Console.WriteLine(" ----- Planos relacionados a um Usúario ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Usúario desaejado: ");
                    String auxIdUser = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("TO DO");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "9":
                    Console.WriteLine(" ----- Planos relacionados a um Tipo ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Tipo desejado: ");
                    String auxIdType = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("TO DO");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "10":
                    Console.WriteLine(" ----- Planos relacionados a um Status ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Status desejado: ");
                    String auxIdStatus = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("TO DO");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "0":
                    return false;
            }

            return true;
        }

        public static bool ReadMenuUsers(string menuOption)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            switch (menuOption)
            {
                case "1":
                    Console.WriteLine(" ----- Cadastro de Usúario ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Preencha os campos abaixo:");
                    Console.WriteLine();
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Permitir Usúario criar planos 1 para sim 0 para não: ");

                    if (Console.ReadLine() == "1")
                    {
                        Program.listUsers.AddUser(new User(name, true));
                    }
                    else
                    {
                        Program.listUsers.AddUser(new User(name, false));
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "2":
                    Console.WriteLine();
                    Console.WriteLine(" ----- Remoção Usúario ----- ");
                    Console.WriteLine();
                    Console.Write("Insira o id do Usúario desejado: ");
                    Program.listUsers.RemoveUser(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para confirmar . . .");
                    Console.Read();
                    break;

                case "3":
                    Console.WriteLine(" ----- Exibição dos Usúarios ----- ");
                    Console.WriteLine();
                    ShowData.ShowUserList(Program.listUsers.GetUserList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "4":
                    Console.WriteLine(" ----- Mostrar Usúario por id ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Usúario desejado: ");
                    string auxIdShow = Console.ReadLine();
                    Console.WriteLine();
                    ShowData.ShowUserById(auxIdShow, Program.listUsers.GetUserList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "5":
                    Console.WriteLine(" ----- Editar Usúario por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Usúario desajado: ");
                    string auxIdShow2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(" ----- Dados atuais ------");
                    User auxUser;
                    try
                    {
                         auxUser = ShowData.ShowUserById(auxIdShow2, Program.listUsers.GetUserList());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("ID não pertence a nenhum Usúario !");
                        Console.WriteLine();
                        Console.WriteLine("Tecle enter para continuar . . .");
                        Console.ReadLine();
                        return false;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Insira os novos dados do Usúario:");
                    Console.WriteLine();
                    Console.Write("Nome: ");
                    auxUser.name = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Permitir Usúario criar planos 1 para sim 0 para não: ");
                    if (Console.ReadLine() == "1")
                    {
                        auxUser.can_create_plan = true;
                    }
                    else
                    {
                        auxUser.can_create_plan = false;
                    }

                    Console.WriteLine();
                    Console.Write("Remover Usúario 1 para sim 0 para não: ");
                    if (Console.ReadLine() == "1")
                    {
                        auxUser.removed = true;
                    }
                    else
                    {
                        auxUser.removed = false;
                    }

                    Program.listUsers.UpdateUser(auxUser);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "6":
                    Console.WriteLine();
                    Console.WriteLine();
                    ShowData.ShowUserHIstory();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "0":
                    return false;
            }

            return true;
        }


        public static bool ReadMenuTypes(string menuOption)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            switch (menuOption)
            {
                case "1":
                    Console.WriteLine(" ----- Cadastro de tipo de plano ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Nome do Tipo de plano: ");
                    Console.WriteLine();
                    Program.listTypes.AddType(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine(" ----- Remoção de tipo de plano por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Tipo de plano desajado: ");
                    Console.WriteLine();
                    Program.listTypes.RemoveType(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine(" ----- Editar tipo de plano por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Tipo de plano desajado: ");
                    String auxIdEdit = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("TO DO");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine(" ----- Exibição de tipos de plano ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    ShowData.ShowPlanTypesList();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "0":
                    return false;
            }

            return true;
        }


        public static bool ReadMenuStatus(string menuOption)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            switch (menuOption)
            {
                case "1":
                    Console.WriteLine(" ----- Cadastro de status de plano ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Nome do Status: ");
                    Program.listStatus.AddStatus(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine(" ----- Remoção de status de plano por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Status de plano desajado: ");
                    Program.listStatus.RemoveStatus(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine(" ----- Editar status de plano por ID ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Status de plano desajado: ");
                    String auxIdEdit = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("TO DO");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine(" ----- Exibição de status de plano ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    ShowData.ShowPlanStatusList();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "0":
                    return false;
            }

            return true;
        }
    }
}
