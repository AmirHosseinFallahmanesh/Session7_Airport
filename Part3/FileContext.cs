using System.Collections.Generic;
using System.IO;

namespace Part3
{//repository
    public class FileContext
    {
        private string path;
        private List<Student> students;

        public FileContext(string path)
        {
            this.path = path;
            students = GetStudents();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            StreamWriter writer = new StreamWriter(path);
            List<string> models = StudentFormatSerializer.Serial(students);
            foreach (var item in models)
            {
                writer.WriteLine(item);
            }
            writer.Flush();
            writer.Close();

        }

        public List<Student> GetStudents()
        {
            StreamReader reader = new StreamReader(path);
            List<string> data = new List<string>();
            while (!reader.EndOfStream)
            {
                data.Add(reader.ReadLine());
            }
            List<Student> students = StudentFormatSerializer.Deserial(data);
            reader.Close();
            return students;
        }
    }
}
