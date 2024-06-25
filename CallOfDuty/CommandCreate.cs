using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty
{
    internal class CommandCreate : CommandUser
    {
        private StudentRepository studentRepository;
        public CommandCreate(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public override void Execute()
        {
            Console.WriteLine("Создать студента");
            Student student = studentRepository.Create();
            Console.WriteLine("Имя студента");
            student.Name = Console.ReadLine();
            Console.WriteLine("Информация о студенте");
            student.Info = Console.ReadLine();
            if (studentRepository.Update(student))
                Console.WriteLine("студент создан");
            else
                Console.WriteLine("произошла ошибка");
        }
    }
}
