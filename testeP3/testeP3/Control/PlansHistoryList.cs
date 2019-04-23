using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;

namespace testeP3.Control
{
    public class PlansHistoryList
    {
        private IList<PlansHistory> PlanHistoryList;

        public PlansHistoryList()
        {
            PlanHistoryList = new List<PlansHistory>();

            foreach (var item in DataBase.cnn.Query<PlansHistory>("SELECT * FROM plans_history"))
            {
                PlanHistoryList.Add(item);
            }
        }

        public IList<PlansHistory> GetPlanHistoryList()
        {
            return PlanHistoryList;
        }
    }
}
