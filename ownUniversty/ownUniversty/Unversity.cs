using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownUniversty
{
    internal class Unversity : Groups


    {
        
        public Unversity(int id , string name ) : base(id , name) { }

        
        public int Id { get; private set; }

        protected static int ID = 0;
        public string Name { get; set; }

        public string Description = " Unversitet haqida malumotlar chiqishi kerak edi yozgani erindim ";


         public static List<Groups> Groups = new List<Groups>();
         
         
        public void Menu()
        {
            int num;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" \t \t \t \t \t   Unversity \n \n ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("_________________________                _________________________               _____________________");
            Console.WriteLine("| 1 - Ariza topshirish  |                | 2 - Unversitet haqida |               | 3 - O'qituvchiman |");
            Console.WriteLine("-------------------------                -------------------------               ---------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n : ");
            Console.ForegroundColor = ConsoleColor.White;
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Arizachi.Ariza();
                    Console.ForegroundColor = ConsoleColor.White;
                break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n"+Description+"\n \n ");
                    Console.ForegroundColor = ConsoleColor.White;
                break;
                case 3:
                Console.ForegroundColor = ConsoleColor.Yellow;
                    Teacher.Check();
                    Teacher.openGroups();
                   
                    Console.ForegroundColor = ConsoleColor.White;
               break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n  kallani ishlatish kerak \n ");
                    Console.ForegroundColor = ConsoleColor.White;
                break;

            }
            Menu();
        }
        
        
    }
}
