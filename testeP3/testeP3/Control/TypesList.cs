using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;

namespace testeP3.Control
{
    public class TypesList
    {
        private IList<Types> TypeList;

        public TypesList()
        {
            if (TypeList == null || TypeList.Count == 0)
            {
                TypeList = new List<Types>();

                foreach (var item in DataBase.cnn.Query<Types>("SELECT * FROM plan_types"))
                {
                    TypeList.Add(item);
                }
            }
        }

        public IList<Types> GetPlanTypeList()
        {
            return TypeList;
        }

        public void AddType(string nameP)
        {
            Console.WriteLine();

            try
            {
                TypeList.Add(new Types(nameP));

                Console.WriteLine("Tipo cadastrado com sucesso !");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar adicionar novo tipo !");
                Console.WriteLine();
            }
        }

        public void UpdateType(Types typeP)
        {

        }

        public void RemoveType(string IdP)
        {
            Console.WriteLine();

            try
            {
                DataBase.cnn.Query($"DELETE FROM plan_types WHERE id = {IdP}");
                Program.listTypes = new TypesList();
                Console.WriteLine("Tipo removido com sucesso !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar remover Tipo !");
            }
        }
    }
}
