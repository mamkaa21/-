using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty
{
    class CommandInvoker
    {
        CommandManager commandManager;

        public CommandInvoker(CommandManager commandManager)
        {
            this.commandManager = commandManager;
        }

        public void Start()
        {
            string descr;
            do
            {
                Console.WriteLine("введите команду");
                descr = Console.ReadLine();
                if (descr != "помогите")
                    commandManager.ListCommand();
                else
                    commandManager.Execute(descr);
            }
            while (descr != "exit");
        }
    }
}
