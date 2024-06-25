using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CallOfDuty
{
    internal class CommandEdit : CommandUser
    {
        private StudentRepository studentRepository;
        public CommandEdit(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public override void Execute()
        {
            Console.WriteLine("Поиск жертвы");
            List<Student> Students = studentRepository.Search(Console.ReadLine());
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{Students[i].Name} {Students[i].Info}");
                Console.WriteLine("Какую жертву изменить?");
                int.TryParse(Console.ReadLine(), out int edit);
                if ((Students.Count > edit - 1))
                {
                    Console.WriteLine("Укажите имя жертвы...");
                    Students[i].Name = Console.ReadLine();
                    Console.WriteLine("Укажите информацию о жертве...");
                    Students[i].Info = Console.ReadLine();
                    if (studentRepository.Update(Students[i]))
                        Console.WriteLine("Жертва готова!");
                    else
                        Console.WriteLine("жертва отказалась от имени и убежала");
                }
            }
        }
    }
}

