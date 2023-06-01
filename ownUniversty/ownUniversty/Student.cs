using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ownUniversty
{
    internal class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int _age;
        public int Age { get => _age ; set 
            { 
                if(value <= 17)
                {
                    
                    Console.WriteLine(" Student yoshi 18 dan katta bolish kerak ");
                }
                _age = value;
            } 
        
        }
        

        protected int Mark;

        private string number ;
        public string PhoneNumber
        {
            get => number; set
            {
                if(value.Length == 9)
                {
                    number = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }


        public Student(int id  , string name, int age, string phoneNum)
        {
            Id = id;
            Name = name;
            Age = age;
            PhoneNumber = phoneNum;
           
        }
    }
}
