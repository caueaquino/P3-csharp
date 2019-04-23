using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    public class PlansHistory
    {
        public int id { get; }
        public int id_plan { get; }
        public int id_plan_status { get; }
        public DateTime date { get; }


        public PlansHistory(int id, int id_plan, int id_plan_status, DateTime date)
        {
            this.id = id;
            this.id_plan = id_plan;
            this.id_plan_status = id_plan_status;
            this.date = date;
        }
    }
}
