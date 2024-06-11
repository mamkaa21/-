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
            Console.WriteLine("Создать жертву");
            Student student = studentRepository.Create();
            Console.WriteLine("Имя жертвы");
            student.Name = Console.ReadLine();
            Console.WriteLine("Инфа о жертве");
            student.Info = Console.ReadLine();
            if (studentRepository.Update(student))
                Console.WriteLine("жертва создана >$D");
            else
                Console.WriteLine("жертва смогла спастись и убежала");
        }
    }
}
