using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    public class Status
    {
        public int id { get; }
        public string name { get; private set; }

        public Status(string nameP)
        {
            name = nameP;
        }

        public Status(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
