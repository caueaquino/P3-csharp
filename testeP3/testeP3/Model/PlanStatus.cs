using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    public static class PlanStatus
    {
        //private static IList<string> planStatusList = new List<string>();
        private static readonly IList<string> plan_status_list = createPlanStatusList();

        private static IList<string> createPlanStatusList()
        {
            IList<string> aux_plan_status_list = new List<string>();

            aux_plan_status_list.Add("Aberto");
            aux_plan_status_list.Add("Conclúido");
            aux_plan_status_list.Add("Suspenso");
            aux_plan_status_list.Add("Cancelado");

            return aux_plan_status_list;
        }

        public static IList<string> getPlanStatusList()
        {
            return aux_plan_status_list;
        }
    }
}
