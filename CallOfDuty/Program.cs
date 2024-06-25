using CallOfDuty;
using System;

class Program
{
    public static void Main()
    {     
        string file = "Students.txt";
        StudentRepository studentRepository = new StudentRepository(file);     
        CommandManager commandManager = new CommandManager();
        CommandInvoker commandInvoker = new CommandInvoker(commandManager);
        commandManager.RegisterCommand("Duty", "Дежурство", new CommandChooseDuty(studentRepository));
        commandManager.RegisterCommand("Create", "Создание", new CommandCreate(studentRepository));        
        commandManager.RegisterCommand("Delete", "Удаление", new CommandDelete(studentRepository));
        commandManager.RegisterCommand("Update", "Редактирование", new CommandEdit(studentRepository));
        commandInvoker.Start();
    }

}



