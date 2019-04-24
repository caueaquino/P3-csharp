using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using testeP3.Model;

namespace testeP3.Control
{
    public class PlansList
    {
        private IDictionary<string, Plan> PlanList;

        public PlansList()
        {
            PlanList = new Dictionary<string, Plan>();


            foreach (var item in DataBase.cnn.Query<Plan>("SELECT * FROM plans"))
            {
                PlanList.Add(item.id.ToString(), item);
            } 
        }

        public void AddPlan(Plan PlanP)
        {

            Console.WriteLine();
            Console.WriteLine();
            try
            {
                DataBase.cnn.Query("INSERT INTO plans (name, id_type, id_user, start_date, end_date, description, cost) VALUES (@name, @id_type, @id_user, @start_date, @end_date, @description, @cost)", PlanP);
                PlanList.Add(PlanP.id.ToString(), PlanP);
                Program.listPlans = new PlansList();
                Console.WriteLine("Plano cadastrado com sucesso !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar cadastrar plano !");
            }
        }

        public void UpdatePlan(Plan planP)
        {

        }

        public Plan GetPlanById(string IdP)
        {
            return PlanList[IdP];
        }

        public IDictionary<string, Plan> GetPlanList()
        {
            return PlanList;
        }
           
        public void RemovePlan(string IdP)
        {
            try
            {
                DataBase.cnn.Query($"DELETE FROM plans WHERE id = {IdP}");
                PlanList.Remove(IdP);
                Console.WriteLine("Plano removido com sucesso !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar remover Plano !");
            }
        }
    }
}
