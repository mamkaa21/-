using System.Text.Json;
using System.Xml.Linq;

namespace CallOfDuty
{
    public class StudentRepository
    {
        public List<Student> Students { get; set; }

        public StudentRepository()
        {
            Students = new List<Student>();
        }

      
        public StudentRepository(string file)
        {
            var lines = File.ReadAllLines(file);
            Students = new List<Student>(lines.Length);
           
            if (!File.Exists("duty.json"))
                Students = new List<Student>();
            else
            using (FileStream fs = new FileStream("duty.json", FileMode.OpenOrCreate))
            {
               Students = JsonSerializer.Deserialize<List<Student>>(fs);
               foreach (var line in lines)
               {
                   var cols = line.Split(';');
                   Students.Add(new Student { Name = cols[0], Info = cols[1] });
               }
            }
        }

        public Student Create()
        {
            Student student = new Student { };
            Students.Add(student);
            return student;
        }

        public bool Update(Student student)
        {
            if (Students.Contains(student))
                Save();
            else
                return false;
            return true;
        }

        public List<Student> Search(string text)
        {
            List<Student> result = new();
            foreach (var student in Students)
            {
                if (student.Name.Contains(text))
                    result.Add(student);
            }
            return result;
        }

        public bool Delete(Student student)
        {
            Students.Remove(student);
            Save();
            return true;
        }

        void Save() 
        {
            using (FileStream fs = new FileStream("duty.json", FileMode.Create))
            {
                JsonSerializer.Serialize(fs, Students);
            }
        }
    }
}