using BankDB.DataAccess;
using BankDB.Models;
using Microsoft.EntityFrameworkCore;

namespace BankDB
{
    class Program
    {
        /*  Використовуючи багатопоточний підхід реалізувати генерацію в циклі тестових екзе?мплярів сутностей з попередньої роботи
         (наприклад. Студент1,Студент2, ... СтудентN, Предмет1, Предмет2, .... ПредметN) і зберегти їх в БД. 
         Використати синхронізуючі примітиви для забезпечення унікальності згенерованих імен. 
         Реалізувати багатопоточне читання та відображення даних записаних в БД. 
         Завдання виконати двома способами - з використанням класу Thread та Task
              При роботі з EntityFramework та LINQ використовувати Async варіанти методів.
          */

        static async Task Main(string[] args)
        {
            // // lock
            //   var locker = new object();
            //   int clientIndex = 0;
            //   var clientThread = new ThreadStart(() =>
            //   {
            //       Console.WriteLine($"Client thread started{Thread.CurrentThread.ManagedThreadId}");
            //       using (var context = new BankContext())
            //       {
            //           for (int i = 0; i < 10; i++)
            //           {
            //             
            //               lock (locker)
            //               {
            //                   clientIndex++;
            //                   context.Clients.Add(new Client
            //                   {
            //                       FirstName = $"client:FirstName{clientIndex}",
            //                       LastName = $"client:LastName{clientIndex}",
            //                       EmailAddres = "test@mail.com"
            //                   });
            //               }
            //           }
            //           context.SaveChanges();
            //       }
            //   });
            //   var thread1 = new Thread(clientThread);
            //   var thread2 = new Thread(clientThread);
            //   var thread3 = new Thread(clientThread);
            //   var thread4 = new Thread(clientThread);
            //   
            //   thread1.Start();
            //   thread2.Start();
            //   thread3.Start();
            //   thread4.Start();
            //   
            //   var allThreadsAreDone = false;
            //   while (!allThreadsAreDone) {
            //       allThreadsAreDone = thread1.ThreadState == System.Threading.ThreadState.Stopped &&
            //                           thread2.ThreadState == System.Threading.ThreadState.Stopped &&
            //                           thread3.ThreadState == System.Threading.ThreadState.Stopped &&
            //                           thread4.ThreadState == System.Threading.ThreadState.Stopped;
            //   }
            //   Console.WriteLine(clientIndex);


            //// паралельно зчитаю з БД
           // // використовуючи Thread
            // var db = new BankContext();
            // var clients = await db.Clients.ToListAsync();
            //
            //
            // ThreadStart action = () =>
            // {
            //     for (int i = 0; i < (clients.Count-1)/2; i++)
            //     {
            //         Console.WriteLine(clients[i].FirstName + " " + clients[i].LastName +" " + Thread.CurrentThread.ManagedThreadId);
            //         Thread.Sleep(500);
            //     }
            // };
            // ThreadStart action2 = () =>
            // {
            //     for (int i = (clients.Count-1)/2; i < clients.Count-1; i++)
            //     {
            //         Console.WriteLine(clients[i].FirstName + " " + clients[i].LastName +" " + Thread.CurrentThread.ManagedThreadId);
            //         Thread.Sleep(500);
            //     }
            // };
            //
            // var thread1 = new Thread(action);
            // var thread2 = new Thread(action2);
            //
            // thread1.Start();
            // thread2.Start();
            //
            // await db.DisposeAsync();
            
           // // використовуючи Task
             // var db = new BankContext();
             // var clients = await db.Clients.ToListAsync();
             //
             // var task1 = Task.Run(()=> 
             // {
             //     for (int i = 0; i < (clients.Count-1)/2; i++)
             //     {
             //         Console.WriteLine(clients[i].FirstName + " " + clients[i].LastName +" " + Thread.CurrentThread.ManagedThreadId);
             //         Task.Delay(500).Wait();
             //     }
             // });
             //
             // var task2 = Task.Run(()=> 
             // {
             //     for (int i = (clients.Count-1)/2; i < clients.Count-1; i++)
             //     {
             //         Console.WriteLine(clients[i].FirstName + " " + clients[i].LastName +" " + Thread.CurrentThread.ManagedThreadId);
             //         Task.Delay(500).Wait();
             //     }
             // });
             //
             // await Task.WhenAll(task1, task2);
             //
             // await db.DisposeAsync();
            
        }
    }
}