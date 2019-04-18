using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;
using testeP3.View;

namespace testeP3.Control
{
    public class MenuFunctions
    {
        public static bool ReadMenuOption(string menuOption)
        {
            string auxFunctions;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            switch (menuOption)
            {


                case "1":
                {
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
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    Console.Read();
                    break;
                }

                case "2":
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
                    Console.WriteLine("Usúario cadastrado com sucesso!");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "3":
                    Console.WriteLine(" ----- Exibir Todos os planos ----- ");
                    Console.WriteLine();
                    ShowData.ShowPlanList(Program.listPlans.GetPlanList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "4":
                    Console.WriteLine(" ----- Exibir todos os Usúarios ----- ");
                    Console.WriteLine();
                    ShowData.ShowUserList(Program.listUsers.GetUserList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "5":
                    Console.WriteLine(" ----- Mostrar Plano por Id ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Plano desejado: ");
                    auxFunctions = Console.ReadLine();
                    Console.WriteLine();
                    ShowData.ShowPlanbyId(auxFunctions, Program.listPlans.GetPlanList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "6":
                    Console.WriteLine(" ----- Mostrar Usúario por id ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Insira o id do Usúario desejado: ");
                    auxFunctions = Console.ReadLine();
                    Console.WriteLine();
                    ShowData.ShowUserById(auxFunctions, Program.listUsers.GetUserList());
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "7":
                    Console.WriteLine(" ----- Exibir tipos de status de planos ----- ");
                    Console.WriteLine();
                    Console.WriteLine();
                    ShowData.ShowPlanStatusList();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para continuar . . .");
                    Console.Read();
                    break;

                case "8":
                    Console.WriteLine();
                    Console.WriteLine(" ----- Remoção Plano ----- ");
                    Console.WriteLine();
                    Console.Write("Insira o id do Plano desejado: ");
                    Program.listPlans.removePlan(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Plano removido com sucesso !");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para confirmar . . .");
                    Console.Read();
                    break;

                case "9":
                    Console.WriteLine();
                    Console.WriteLine(" ----- Remoção Usúario ----- ");
                    Console.WriteLine();
                    Console.Write("Insira o id do Usúario desejado: ");
                    Program.listUsers.removeUser(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Usúario removido com sucesso !");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para confirmar . . .");
                    Console.Read();
                    break;

                case "0":
                    Console.WriteLine("Finalizando Programa !");
                    Console.WriteLine();
                    Console.WriteLine("Tecle enter para confirmar . . .");
                    Console.Read();
                    return false;

            }

            return true;
        }
    }
}
