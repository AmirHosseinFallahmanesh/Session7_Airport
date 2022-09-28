using System.Collections.Generic;

namespace Part3
{//repository
    public class StudentRepository
    {

        private FileContext fileContext;
      
        public StudentRepository()
        {
        
            fileContext = new FileContext("db.txt");
        }

        public void AddStudent(Student student)
        {
            fileContext.AddStudent(student);
        }

        public List<Student> GetStudents()
        {
            return fileContext.GetStudents();
        }
    }
}
