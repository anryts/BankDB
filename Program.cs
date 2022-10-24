using BankDB.DataAccess;
using BankDB.Models;

namespace BankDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BankContext db = new BankContext())
            {
                Bank bank = new Bank { BankName = "Bank of America"};
                db.Bank.Add(bank);
                db.SaveChanges();
            }

            using (BankContext db = new BankContext())
            {
                var banks = db.Bank.ToList();
                Console.WriteLine("List of banks:");
                foreach (Bank b in banks)
                {
                    Console.WriteLine($"{b.BankId}.{b.BankName}");
                }
            }
        }
    }
}