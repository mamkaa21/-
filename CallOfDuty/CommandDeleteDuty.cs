using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty
{
    internal class CommandDeleteDuty : CommandUser
    {
        private StudentRepository studentRepository;
        private string folder = "dutys";
        public CommandDeleteDuty(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public override void Execute()
        {
            string path = Path.Combine(Environment.CurrentDirectory, folder);
            string[] jsonfiles = Directory.GetFiles(path, "*.json");
            if(jsonfiles.Length > 0 )
            {
                foreach(string file in jsonfiles) 
                {
                    File.Delete(file);
                }
                Console.WriteLine("Обнуление успешно");
            }
           
        }
    }
}

