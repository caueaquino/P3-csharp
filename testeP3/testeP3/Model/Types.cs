using System;
using System.Collections.Generic;
using System.Text;

namespace testeP3.Model
{
    public class Types
    {
        public int id { get; }
        public string name { get; set; }


        public Types(string nameP)
        {
            name = nameP;
        }

        public Types(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
