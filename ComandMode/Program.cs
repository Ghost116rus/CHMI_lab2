using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorksWithFilesLibrary;

namespace ComandMode
{
    public class Program
    {
        private static WorkWithFiles _workWithFiles;

        private static void HandleArray(string[] parameters, Func<string, int> handler)
        {
            foreach (var item in parameters)
            {
                var result = handler.Invoke(item);
                var isCreationCommand = handler == _workWithFiles.CreateFile;

                switch (result)
                {
                    case 1:
                        Console.WriteLine($"\tФайл {item} успешно {(isCreationCommand ? "создан" : "удален")}");
                        break;
                    case -1:
                        Console.WriteLine($"\tВо время {(isCreationCommand ? "создания" : "удаления")} файла {item}, произошла ошибка");
                        break;
                    case -2:
                        Console.WriteLine($"\t{(isCreationCommand ? "У файла неверное расширение" : "Данный файл не существует")}");
                        break;

                    default:
                        break;
                }

            }
        }


        static void Main(string[] args)
        {
            string comand = "";
            _workWithFiles = new WorkWithFiles();

            while (comand != "exit")
            {
                _workWithFiles.WriteCurrentDirectory(); comand = Console.ReadLine();

                var comandArr = comand.Split(' ');
                

                var currentCommand = comandArr[0];
                var parameters = comandArr.Skip(1).ToArray();

                switch (currentCommand.ToLower())
                {
                    case "make":
                        HandleArray(parameters, _workWithFiles.CreateFile);
                        break;
                    case "remove":
                        HandleArray(parameters, _workWithFiles.DeleteFile);
                        break;
                    case "goto":
                        if (parameters.Length > 1)
                        {
                            Console.WriteLine("При смене текущей директории возможен только один параметр");
                            continue;
                        }
                        _workWithFiles.ChangeDirectory(parameters[0]);
                        break;
                    case "show":
                        if (parameters.Length > 0)
                        {
                            Console.WriteLine("Команда show не принимает параметров");
                            continue;
                        }
                        _workWithFiles.ShowFiles();
                        break;

                    default:
                        Console.WriteLine("Такой команды нет!");
                        continue;
                }
                
            }

        }
    }
}
