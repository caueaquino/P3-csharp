using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    public class Plan
    {
        public int id { get; }
        public string name { get; set; }
        public int id_type { get; set; }
        public int id_user { get; set; }
        public int id_status { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string description { get; set; }
        public decimal cost { get; set; }

        private static int aux_plans_size = 0;

        public Plan(string nameP, int idUserP, int idTypeP = 1, int idStatusP = 3, DateTime startDateP = default, DateTime endDateP = default, string descriptionP = "Sem Descrição", decimal costP = 0)
        {
            id = 1 + aux_plans_size;
            name = nameP;
            id_type = idTypeP;
            id_user = idUserP;
            id_status = idStatusP;
            start_date = startDateP;
            end_date = endDateP;
            description = descriptionP;
            cost = costP;
            UpAuxPlansSize();
        }

        private void UpAuxPlansSize()
        {
            aux_plans_size++;
        }
    }
}
