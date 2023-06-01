using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownUniversty
{
    internal class Teacher 

    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Login { get; set; }

        public static bool isTure = true ;

        public static List<Arizachi> Arizachilar = new List<Arizachi>();

        public static List<Teacher> Teachers = new List<Teacher>();
        public Teacher(int id , string name  , string login) 
        { 
            Id = id;
            Name = name;
            Login = login;
            Teachers.Add(this);
        }

        public static void Check()
        {
            string login;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Assalomu alaykum \n ");
            Console.Write("Login : ");
            login = Console.ReadLine();
            foreach(Teacher teacher in Teacher.Teachers)
            {
                if(teacher.Login == login)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" \n Xushkelibsiz {teacher.Name} \n ");
                    isTure = false;
                    break;
                }
            }
            if(isTure)
            {
                Console.WriteLine(" Login xato ! ");
                Console.ReadKey();
                return;
            }

        }
        public static void openGroups()
        {
            int num;
            if (!isTure) 
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" 1 - Gruhlarni ochish , 2 - chiqish \n : ");
                num = Convert.ToInt32( Console.ReadLine() );
                switch (num) 
                {
                    case 1:
                        foreach (Groups gr in Unversity.Groups)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\n Id : {gr.Id} , Name : {gr.Name} \n ");
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.WriteLine();

                        Console.Write(" ochmoqchi bolgan guruhingizni ID ni kiritng : ");
                        num = Convert.ToInt32 ( Console.ReadLine() );
                        foreach (Groups gr in Unversity.Groups)
                        {
                            if(gr.Id == num)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n"+gr.Name + " studentlari \n ");
                                foreach (Student st in gr.students) 
                                {
                                    Console.ForegroundColor= ConsoleColor.Yellow;
                                    Console.WriteLine($"\n  Id {st.Id} , Name : {st.Name} , PhoneNumber : {st.PhoneNumber} \n ");
                                }
                            }
                        }
                        break;

                   case 2:
                     return;
                    default:
                        return;
                }

            }
        }


    }
}
