using System;
using System.Collections.Generic;

namespace ProjectStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("How Many Students are in your class?");
            //var studentCount = int.Parse(Console.ReadLine());

            //var studentNames = new String [studentCount];
            //var studentGrades = new int[studentCount];
            var students = new List<Student>();

            ////var studentNames = new List<string>();
            ////var studentGrades = new List<int>();

            //for (int x = 0; x < studentCount; x++)

            var adding = true;

            while (adding)
            {
                var newstudent = new Student();

                Console.WriteLine("What is your student Name ");
                newstudent.Name = Console.ReadLine();

                Console.WriteLine("What is your student Grade ");
                newstudent.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your student Birthday ");
                newstudent.Birthday = Console.ReadLine();

                Console.WriteLine("What is your student Address ");
                newstudent.Address = Console.ReadLine();

                Console.WriteLine("What is your student Phone");
                newstudent.Phone = int.Parse(Console.ReadLine());

                students.Add(newstudent);

                Console.WriteLine("Add new student? y/n");
                if (Console.ReadLine() != "y")
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine("Your Name is: {0} , Your Grade is {1}", student.Name, student.Grade);
            }
        }
    }
    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public int Phone;
    }
}
