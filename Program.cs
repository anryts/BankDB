using BankDB.DataAccess;
using BankDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDB
{
    ///union, except, intersect, join, distinct, group by, агрегатних функцій.
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BankContext())
            {
                //вибираю всіх клієнтів з певними полями з БД і вивожу їх на екран 
                var result = db.Clients.Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    Citizenship = x.Citizenship,
                    EmailAddress = x.EmailAddres,
                });
                foreach (var item in result)
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine($"FullName: {item.FullName}");
                    Console.WriteLine($"Citizenship: {item.Citizenship}");
                    Console.WriteLine($"EmailAddress: {item.EmailAddress}");
                    Console.WriteLine("**********************************************");
                }
            }
        }
    }
}