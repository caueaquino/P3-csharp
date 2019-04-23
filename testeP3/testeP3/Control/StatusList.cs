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

        public void AddStatus(string nameP)
        {
            Console.WriteLine();

            try
            {
                StatuList.Add(new Status(nameP));

                Console.WriteLine("Status cadastrado com sucesso !");
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao tentar adicionar novo Status !");
                Console.WriteLine();
            }
        }

        public void RemoveStatus(int IdP)
        {
            Console.WriteLine();

            try
            {

                Console.WriteLine("Status removido com sucesso !");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao tentar remover Status !");
            }
        } 
    }
}
