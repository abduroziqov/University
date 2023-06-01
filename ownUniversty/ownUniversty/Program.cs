namespace ownUniversty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            Unversity unversity = new Unversity(1,"Bek");

            List<Student> students = new List<Student>()
            {
                new Student (1,"Axrorbek",18,"914797329"),
                new Student (2,"Avazbek",19,"914797329"),
                new Student (3,"Farhodjon",20,"914797329"),
                new Student (4,"Abdulaziz",21,"914797329"),
                new Student (5,"Tohir",22,"914797329"),
            };

            Teacher teacher = new Teacher(1,"axror","salomdunyo");
            

            Groups group1 = new Groups(1,"group1");
            
            Groups group2 = new Groups(2,"group2");

            Groups group3 = new Groups(3,"group3");

            group1.students = students;

            group2.students = students;
            
            group3.students = students;

            Unversity.Groups.Add(group1);
            Unversity.Groups.Add(group2);
            Unversity.Groups.Add(group3);

            unversity.Menu();




        }
    }
}