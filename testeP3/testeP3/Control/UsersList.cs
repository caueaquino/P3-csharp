using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using testeP3.Model;

namespace testeP3.Control
{
    public class UsersList
    {
        private IDictionary<string, User> UserList;

        public UsersList()
        { 
            UserList = new Dictionary<string, User>();

            foreach (var item in DataBase.cnn.Query<User>("SELECT * FROM users"))
            {
                UserList.Add(item.id.ToString(), item);
            }
        }

    public void AddUser(User userP)
        {
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                DataBase.cnn.Query("INSERT INTO users (name, can_create_plan) VALUES (@name, @can_create_plan)", userP);
                Program.listUsers = new UsersList();
                Console.WriteLine("Usúario cadastrado com sucesso !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar cadastrar Usúario");
            }
        }

        public User GetUserById(string IdP)
        {
            return UserList[IdP];
        }

        public IDictionary<string, User> GetUserList()
        {
            return UserList;
        }

        public void UpdateUser(User userP)
        {
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                DataBase.cnn.Query("UPDATE users SET name = @name, can_create_plan = @can_create_plan, removed = @removed WHERE id = @id", userP);
                UserList[userP.id.ToString()] = userP;
                Program.listUsersHistory = new UsersHistoryList();
                Console.WriteLine("Usúario atualizado com sucesso !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar atualizar Usúario !");
            }
        }

        public void RemoveUser(string IdP)
        {
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                DataBase.cnn.Query($"UPDATE users SET removed = 1 WHERE id = {IdP}");
                UserList[IdP].removed = true;
                Console.WriteLine("Usúario removido com sucesso !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Erro ao tentar remover Usúario !");
            }
        }
    }
}
