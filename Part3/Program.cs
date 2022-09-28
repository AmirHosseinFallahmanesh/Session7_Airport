using System;

namespace Part3
{//repository
    class Program
    {
        static void Main(string[] args)
        {

            StudentRepository repository = new StudentRepository();
            while (true)
            {
                Console.WriteLine("1)Add Student");
                Console.WriteLine("2)Print Student");
                Console.WriteLine("3)Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Surname");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Enter Age");
                        int age  =int.Parse( Console.ReadLine());
                        Student student = new Student()
                        {
                            Age = age,
                            Name = name,
                            Surname = surname
                        };
                        repository.AddStudent(student);



                        break;
                    case "2":
                        foreach (var item in repository.GetStudents())
                        {
                            Console.WriteLine(item.Name);
                            Console.WriteLine(item.Surname);
                            Console.WriteLine(item.Age);
                            Console.WriteLine("********************");
                        }
                        break;
                    case "3":

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
