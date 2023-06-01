using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ownUniversty
{
    internal class Groups 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> students = new List<Student>();

        public Groups(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddStudent(Student student) 
        { 
          students.Add(student);
        }

        public void AddnewStudent() 
        {
            string name; int age , Id; string phoneNum;
            Console.Write(" Student ID : ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Student ismi : ");
            name = Console.ReadLine();
            Console.Write(" Student yoshi : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Student yoshi : ");
            phoneNum = Console.ReadLine();

            students.Add(new Student( Id , name, age, phoneNum));
        }

        public void DispilayStudents()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Goup name : " + Name + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Student student in students)
            {               
                Console.WriteLine($"Id : {student.Id} , Name : {student.Name} \n");
            }
        }




    }
}
