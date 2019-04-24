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

        public Types GetTypeById(string IdP)
        {
            foreach (var item in Program.listTypes.GetPlanTypeList())
            {
                if (item.id.ToString() == IdP)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" ----- Tipo Atual -----");
                    Console.WriteLine();
                    Console.WriteLine($"ID: {item.id}");
                    Console.WriteLine($"Nome: {item.name}");
                    Console.WriteLine();

                    return item;
                }
            }

            return null;
        }

        public void AddType(Types typeP)
        {
            if (typeP == null)
            {
                throw new ArgumentNullException(nameof(typeP));
            }

            Console.WriteLine();

            try
            {
                DataBase.cnn.Query("INSERT INTO plan_types (name) VALUES (@name)", typeP);
                TypeList.Add(typeP);
                Program.listTypes = new TypesList();
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
            if (typeP == null)
            {
                throw new ArgumentNullException(nameof(typeP));
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Insira os novos dados do Tipo:");
            Console.WriteLine();
            Console.Write("Nome: ");
            typeP.name = Console.ReadLine();
            Console.WriteLine();
            try
            {
                DataBase.cnn.Query("UPDATE plan_types SET name = @name WHERE id = @id", typeP);
                Program.listTypes = new TypesList();
                Console.WriteLine("Tipo de Plano atualizado com sucesso !");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar atualizar Tipo de Plano !");
                Console.WriteLine();
            }
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
