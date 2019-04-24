using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;

namespace testeP3.Control
{
    public class StatusList
    {
        private IList<Status> StatuList;

        public StatusList()
        {
            if (StatuList == null || StatuList.Count == 0)
            {
                StatuList = new List<Status>();

                foreach (var item in DataBase.cnn.Query<Status>("SELECT * FROM plan_status"))
                {
                    StatuList.Add(item);
                }
            }
        }

        public IList<Status> GetPlanStatusList()
        {
            return StatuList;
        }

        public Status GetStatusById(String IdP)
        {
            foreach (var item in Program.listStatus.GetPlanStatusList())
            {
                if (item.id.ToString() == IdP)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ----- Status Atual -----");
                    Console.WriteLine();
                    Console.WriteLine($"ID: {item.id}");
                    Console.WriteLine($"Nome: {item.name}");
                    Console.WriteLine();

                    return item;
                }
            }

            return null;
        }

        public void AddStatus(Status statusP)
        {
            if (statusP == null)
            {
                throw new ArgumentNullException(nameof(statusP));
            }

            Console.WriteLine();

            try
            {
                DataBase.cnn.Query($"INSERT INTO plan_status (name) VALUES (@name)", statusP);
                StatuList.Add(statusP);
                Program.listStatus = new StatusList();
                Console.WriteLine("Status cadastrado com sucesso !");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar adicionar novo Status !");
                Console.WriteLine();
            }
        }

        public void UpdateStatus(Status statusP)
        {
            if (statusP == null)
            {
                throw new ArgumentNullException(nameof(statusP));
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Insira os novos dados do Status:");
            Console.WriteLine();
            Console.Write("Nome: ");
            statusP.name = Console.ReadLine();
            Console.WriteLine();

            try
            {
                DataBase.cnn.Query("UPDATE plan_status SET name = @name WHERE id = @id", statusP);
                Program.listStatus = new StatusList();
                Console.WriteLine("Tipo de Plano atualizado com sucesso !");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar atualizar Tipo de Plano !");
                Console.WriteLine();
            }
        }

        public void RemoveStatus(string IdP)
        {
            Console.WriteLine();

            try
            {
                DataBase.cnn.Query($"DELETE FROM plan_status WHERE id = {IdP}");
                Program.listStatus = new StatusList();
                Console.WriteLine("Status removido com sucesso !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar remover Status !");
            }
        } 
    }
}
