using BankDB.DataAccess;
using BankDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BankContext();
            var clients = db.Client.ToList();
            var client = clients.FirstOrDefault(x => x.FirstName=="Alex");
            db.Client.Remove(client);
            // clients.ForEach(x=> Console.WriteLine(x.FirsName));
            db.SaveChanges();
            db.Client.ToList().ForEach(x=> Console.WriteLine(x.FirstName));

            // var Client = new Client
            // {
            //     FirsName = "John",
            //     LastName = "Doe",
            //     Citizenship = "USA",
            //     EmailAddres = "test@gmail.com"
            
            // };

            // db.Add(Client);
        }
    }
}