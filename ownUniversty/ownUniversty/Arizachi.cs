using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownUniversty
{
    internal class Arizachi
    {
        public string PsId { get; set; }

        public string Name { get; set;}
        public string Surename { get; set;}

        public int Age { get; set;}

        public int Result { get; set;}

        public Arizachi(string psid , string name , string surename , int age , int result)
        {
            PsId = psid;
            Name = name;
            Surename = surename;
            Age = age;
            Result = result;
        }

        public static void Ariza()
        {
            int  age, result;
            string name , surename , psid;

            Console.Write(" Pasport Id : ");
            psid = Console.ReadLine();
            Console.Write(" Name : ");
            name = Console.ReadLine();
            Console.Write(" SureName : ");
            surename = Console.ReadLine();

            Console.Write(" Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if( age < 18 ) 
            {
                Console.WriteLine("Age must be bigger than 18");
                return;
            }
            Console.Write(" Exam Result : ");
            result = Convert.ToInt32(Console.ReadLine());
            if( result < 55)
            {
                Console.WriteLine("result must be bigger than 55");
                return ;
            }
            if (result > 101)
            {
                Console.WriteLine("result must be smaller than 100");
                return;
            }

              

            Teacher.Arizachilar.Add( new Arizachi(psid , name , surename , age , result ));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" \n Ariza korib chiqish uchun topshirildi ");
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
