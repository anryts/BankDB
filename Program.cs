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
            //вибираю всіх клієнтів з певними полями з БД і вивожу їх на екран 
            // using (var db = new BankContext())
            // {
            //   
            //     var result = db.Clients.Select(x => new
            //     {
            //         FullName = x.FirstName + " " + x.LastName,
            //         Citizenship = x.Citizenship,
            //         EmailAddress = x.EmailAddres,
            //     });
            //     foreach (var item in result)
            //     {
            //         Console.WriteLine("**********************************************");
            //         Console.WriteLine($"FullName: {item.FullName}");
            //         Console.WriteLine($"Citizenship: {item.Citizenship}");
            //         Console.WriteLine($"EmailAddress: {item.EmailAddress}");
            //         Console.WriteLine("**********************************************");
            //     }
            // }


            //приклади використання union, except, intersect, join, distinct, group by, агрегатних функцій.
            using (var db = new BankContext())
            {
                // //union
                // // ef core не може не об'єднати дві таблиці, тому 
                // // var result = db.Clients.Where(x => x.FirstName == "Ivan")
                // //     .Union(db.Employees.Where(x => x.FirstName == "Ivan").ToList();
                //
                //
                // var result = db.Clients.Where(x=> x.FirstName == "Ivan")
                //     .Select(x=> new {FullName = x.FirstName + " " + x.LastName, Role = "Client"})
                //     .Union(db.Employees.Where(x=> x.FirstName == "Ivan")
                //         .Select(x=> new {FullName = x.FirstName + " "+ x.LastName, Role = "Employee"})).ToList();
                //
                // foreach (var person in result )
                // {
                //     Console.WriteLine("**********************************************");
                //     Console.WriteLine($"FullName: {person.FullName}");
                //     Console.WriteLine($"Role: {person.Role}");
                //     Console.WriteLine("**********************************************");
                // }


                // //except
                // var result = db.Clients.Where(x => x.LastName == "Doe");
                // var result2 = db.Clients.Where(x=> x.Citizenship == "Ukraine");
                // var result3 = result.Except(result2).ToList();
                // foreach (var person in result3)
                // {
                //     Console.WriteLine("**********************************************");
                //     Console.WriteLine($"FullName: {person.FirstName} {person.LastName}");
                //     Console.WriteLine($"Citizenship: {person.Citizenship}");
                //     Console.WriteLine("**********************************************");
                // }


                // //intersect
                // // var result = db.Clients.Where(x => x.LastName == "Doe" 
                // //                                    && x.Citizenship == "USA");
                //  var result = db.Clients.Where(x => x.LastName == "Doe")
                //      .Intersect(db.Clients.Where(x => x.Citizenship == "USA")).ToList();
                //  foreach (var person in result)
                // {
                //     Console.WriteLine("**********************************************");
                //        Console.WriteLine($"FullName: {person.FirstName} {person.LastName}");
                //        Console.WriteLine($"Citizenship: {person.Citizenship}");
                //        Console.WriteLine("**********************************************");
                // }


                // // join отримую операції, які виконував клієнт у банку
                // var result = db.ServiceForClientInBanks.Join(db.Clients, // другий набір даних
                //     x => x.ClientId, // властивість, за якою вибираємо у першому наборі даних
                //     u => u.PersonId, // властивість, за якою вибираємо у першому наборі даних
                //     (x, u) => new
                //     {
                //         Name = u.FirstName + u.LastName,
                //         ServiceId = x.ServiceInBankId,
                //         ServiceName = x.ServiceInBank.NameOfService,
                //     }
                // );
                // foreach (var person in result)
                // {
                //     Console.WriteLine("**********************************************");
                //        Console.WriteLine($"FullName: {person.Name}");
                //        Console.WriteLine($"ServiceName: {person.ServiceName}");
                //        Console.WriteLine($"ServiceId: {person.ServiceId}");
                //        Console.WriteLine("**********************************************");
                // }


                // //distinct uniq values
                // var result = db.Clients.Select(x => x.Citizenship).Distinct().ToList();
                // foreach (var person in result)
                // {
                //     Console.WriteLine("**********************************************");
                //     Console.WriteLine($"Citizenship: {person}");
                //     Console.WriteLine("**********************************************");
                // }


                // //group by та Sum
                // var result = db.AccountInBanks.GroupBy(x=> x.Currency)
                //     .Select(x => new
                //     {
                //            Currency = x.Key,                                   //ключ від групи (x.Currency)
                //            Sum = x.Sum(y => y.AmountOnAccount),
                //        }).ToList();
                //
                // foreach (var account in result)
                // {
                //     Console.WriteLine("**********************************************");
                //     Console.WriteLine($"Currency: {account.Currency}");
                //     Console.WriteLine($"Sum: {account.Sum}");
                // }
            }


            //Навести приклади різних стратегій завантаження зв'язаних даних (Eager, Explicit, Lazy)


            // //Eager
            // using (var db = new BankContext())
            // {
            //     var result = db.Clients.Include(x => x.AccountsInBank).ToList();
            //     foreach (var client in result)
            //     {
            //         Console.WriteLine($"FullName: {client.FirstName} {client.LastName}");
            //         Console.WriteLine($"Citizenship: {client.Citizenship}");
            //         Console.WriteLine($"Accounts: ");
            //         // підраховую к-сть кожної валюти для кожного клієнта
            //         foreach (var account in client.AccountsInBank)
            //         {
            //             Console.WriteLine($"AccountNumber: {account.AccountId}");
            //             var singleCurrencies = db.AccountInBanks.Where(x=> x.AccountId == account.AccountId)
            //                 .GroupBy(x=> x.Currency)
            //                 .Select(x => new
            //                 {
            //                        Currency = x.Key,                                  
            //                        Sum = x.Sum(y => y.AmountOnAccount),
            //                    }).ToList();
            //             foreach (var singleCurrency in singleCurrencies)
            //             {
            //                 Console.WriteLine($"Currency: {singleCurrency.Currency}");
            //                 Console.WriteLine($"Sum: {singleCurrency.Sum}");
            //             }
            //         }
            //         Console.WriteLine("**********************************************");
            //     }
            // }


            // //Explicit
            // using (var db = new BankContext())
            // {
            //     var result = db.Clients.Find(4); //пошук по id
            //     db.Entry(result).Collection(x => x.AccountsInBank).Load();
            //     Console.WriteLine("**********************************************");
            //     Console.WriteLine($"FullName: {result.FirstName} {result.LastName}");
            //     Console.WriteLine($"Citizenship: {result.Citizenship}");
            //     Console.WriteLine($"Accounts: ");
            //     foreach (var account in result.AccountsInBank)
            //     {
            //         Console.WriteLine($"AccountNumber: {account.AccountId}");
            //         var singleCurrencies = db.AccountInBanks.Where(x=> x.AccountId == account.AccountId)
            //             .GroupBy(x=> x.Currency)
            //             .Select(x => new
            //             {
            //                    Currency = x.Key,                                  
            //                    Sum = x.Sum(y => y.AmountOnAccount),
            //                }).ToList();
            //         foreach (var singleCurrency in singleCurrencies)
            //         {
            //             Console.WriteLine($"Currency: {singleCurrency.Currency}");
            //             Console.WriteLine($"Sum: {singleCurrency.Sum}");
            //         }
            //     }
            //     Console.WriteLine("**********************************************");
            // }


            // // Lazy loading 
            // using (var db = new BankContext())
            // {
            //     var clients = db.Clients.ToList();
            //     foreach (var client in clients)
            //     {
            //         Console.WriteLine($"FullName: {client.FirstName} {client.LastName}");
            //         Console.WriteLine($"Citizenship: {client.Citizenship}");
            //         Console.WriteLine($"Accounts: ");
            //         foreach (var account in client.AccountsInBank)
            //         {
            //             Console.WriteLine($"AccountNumber: {account.AccountId}");
            //             var singleCurrencies = db.AccountInBanks.Where(x=> x.AccountId == account.AccountId)
            //                 .GroupBy(x=> x.Currency)
            //                 .Select(x => new
            //                 {
            //                        Currency = x.Key,                                  
            //                        Sum = x.Sum(y => y.AmountOnAccount),
            //                    }).ToList();
            //             foreach (var singleCurrency in singleCurrencies)
            //             {
            //                 Console.WriteLine($"Currency: {singleCurrency.Currency}");
            //                 Console.WriteLine($"Sum: {singleCurrency.Sum}");
            //             }
            //         }
            //         Console.WriteLine("**********************************************");
            //     }
            // }


            // // Навести приклад завантаження даних що не відслідковуються, їх зміни та збереження
            // using (var db = new BankContext())
            // {
            //     db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // відключаємо відслідковування для всіх запитів
            //     Console.WriteLine(db.ChangeTracker.Entries().Count()); // 0
            //     var client = db.Clients.FirstOrDefault(x => x.PersonId==4);
            //     Console.WriteLine($"{client.FirstName} {client.LastName}");
            //     client.FirstName = "Vasya";
            //     client.LastName = "Ivanov";
            //     db.SaveChanges();
            // }
            //
            // using (var db = new BankContext())
            // {
            //     var client = db.Clients.Where(x=> x.PersonId==4).AsNoTracking().FirstOrDefault();
            //     Console.WriteLine($"{client.FirstName} {client.LastName}");
            //     db.SaveChanges();
            // }


            // Навести приклади виклику збережених процедур та функцій за допомогою Entity Framework
            using (var db = new BankContext())
            {
                var blogs = db.Clients.FromSqlRaw("select * from select_my_table(2);").ToList();
                blogs.ForEach(x => Console.WriteLine($"ID:{x.PersonId}  {x.FirstName} {x.LastName}"));
            }
        }
    }
}