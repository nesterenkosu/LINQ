using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;

namespace ConsoleApp_DB
{
    [Table(Name = "Users")]
    public class MyUsersOrm
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Age")]
        public int Age { get; set; }
    }
    public class MyLogger
    {
        public void Log(string component, string message)
        {
            Console.WriteLine("Component: {0} Message: {1} ", component, message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Live\20211202_LINQ2SQL\ConsoleApp_DB\ConsoleApp_DB\Database1.mdf;Integrated Security=True");

            var logger = new MyLogger();
            StreamWriter writer = File.CreateText("newfile.txt");
            db.Log = writer;

            while (true)
            {
                var users = from u in db.GetTable<MyUsersOrm>()
                            select u;

                Console.Clear();

                Console.WriteLine("ID\tName\tAge");
                Console.WriteLine("-----------------------------");
                foreach (var u in users)
                {
                    Console.WriteLine(u.Id + "\t" + u.Name + "\t" + u.Age);
                }
                Console.WriteLine("-----------------------------");

                Console.WriteLine("[C] Create [U] Update [D] Delete [X] Exit");

                MyUsersOrm user = new MyUsersOrm();
                int id;

                switch (Console.ReadKey().KeyChar)
                {
                    case 'C':
                        {
                            Console.Write("\nИмя:");
                            user.Name = Console.ReadLine();
                            Console.Write("Возраст:");
                            user.Age = Convert.ToInt32(Console.ReadLine());

                            db.GetTable<MyUsersOrm>().InsertOnSubmit(user);
                            db.SubmitChanges();
                            break;
                        }
                    case 'U':
                        {
                            Console.WriteLine("Введите ID редактируемого пользователя:");
                            id = Convert.ToInt32(Console.ReadLine());
                            user = (from u in db.GetTable<MyUsersOrm>()
                                    where u.Id == id
                                    select u).First<MyUsersOrm>();

                            Console.Write("Имя [" + user.Name + "] :");
                            user.Name = Console.ReadLine();
                            Console.Write("Возраст [" + user.Age.ToString() + "] :");
                            user.Age = Convert.ToInt32(Console.ReadLine());

                            db.SubmitChanges();
                            break;
                        }
                    case 'D':
                        {
                            Console.Write("\nВведите ID удаляемого пользователя:");
                            id = Convert.ToInt32(Console.ReadLine());

                            //С удалением у LINQ не всё так просто

                            //Способ, приводящий к выполнению двух запросов
                            /*user = (from u in db.GetTable<MyUsersOrm>()
                                        where u.Id == id
                                        select u).First<MyUsersOrm>();

                            db.GetTable<MyUsersOrm>().DeleteOnSubmit(user);
                            db.SubmitChanges();*/

                            //Способ, приводящий к выполнению одного запроса, 
                            //но требующий написания платфоромзависимого SQL
                            db.ExecuteCommand("DELETE FROM Users WHERE Id={0}", id);

                            //Способ, приводящий к выполнению одного запроса, но почему-то не работающий (https://ask-dev.ru/info/296887/linq-to-sql-delete-entity-by-id-with-one-query)

                            /*var user2 = new MyUsersOrm { Id = id };                            
                            db.GetTable<MyUsersOrm>().Attach(user2,false);
                            db.GetTable<MyUsersOrm>().DeleteOnSubmit(user2);
                            db.SubmitChanges();*/

                            //А это - самый очевидно напрашивающийся способ, но он тоже не работает
                            /*user.Id = id;                           
                            db.GetTable<MyUsersOrm>().DeleteOnSubmit(user);
                            db.SubmitChanges();*/

                            break;
                        }
                    case 'X':
                        {
                            writer.Close();
                            return;
                        }
                }
            }

            

        }   
    }
}
