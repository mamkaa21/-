using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CallOfDuty
{
    internal class CommandDelete : CommandUser
    {
        private StudentRepository studentRepository;
        public CommandDelete(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public override void Execute()
        { 
            Console.WriteLine("Поиск студента");
            List<Student> Students = studentRepository.Search(Console.ReadLine());
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Students[i].Name} {Students[i].Info}");
                Console.WriteLine("Какого студента удалить?");
                int.TryParse(Console.ReadLine(), out int delete);
                if (Students.Count > delete - 1)
                {
                    studentRepository.Delete(Students[i]);
                    Console.WriteLine("Студент удален");
                }
                else
                    Console.WriteLine("произошла ошибка");
            }                  
        }
    }
}
