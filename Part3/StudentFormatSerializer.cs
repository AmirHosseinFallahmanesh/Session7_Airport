using System.Collections.Generic;

namespace Part3
{//repository
    public class StudentFormatSerializer
    {

        public static List<string> Serial (List<Student> model)
        {
            List<string> result = new List<string>();
            foreach (var item in model)
            {
                result.Add($"{item.Name},{item.Surname},{item.Age}");
            }
            return result;
        }

        public static List<Student> Deserial(List<string> model)
        {
            List<Student> result = new List<Student>();
            foreach (var item in model)
            {
                Student student = new Student()
                {
                    Name = item.Split(",")[0],
                    Surname = item.Split(",")[1],
                    Age = int.Parse(item.Split(",")[2])
                };
                result.Add(student);
            }
               
         
            return result;
        }
    }
}
