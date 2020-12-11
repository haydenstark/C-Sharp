using System;

namespace Code_First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bartholomew" };

                context.Students.Add(stud);
                context.SaveChanges();
            }

            Console.WriteLine("Added");
            Console.Read();
        }
    }
}
