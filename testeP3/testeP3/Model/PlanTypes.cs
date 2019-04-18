using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    class PlanTypes
    {
        public int id { get; }
        public string name { get; set; }

        private static int aux_plan_types_size = 0;

        public PlanTypes(string nameP)
        {
            id = 1 + aux_plan_types_size;
            name = nameP;
            upAuxPlanTypesSize();
        }

        private static void upAuxPlanTypesSize()
        {
            aux_plan_types_size++;
        }
    }
}
