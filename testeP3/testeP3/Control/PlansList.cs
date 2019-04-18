using System;
using System.Collections.Generic;
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
        }

        public void AddPlan(Plan PlanP)
        {
            PlanList.Add(PlanP.id.ToString(), PlanP);
        }

        public Plan GetPlanById(string IdP)
        {
            return PlanList[IdP];
        }

        public IDictionary<string, Plan> GetPlanList()
        {
            return PlanList;
        }
           
        public void removePlan(string IdP)
        {
            PlanList.Remove(IdP);
        }
    }
}
