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
                        Console.WriteLine($"\t{(isCreationCommand ? $"У файла {item} неверное расширение" : $"Данный файл {item} не существует")}");
                        break;

                    default:
                        break;
                }

            }
        }


        static void Main(string[] args)
        {
            string comand = "";
            _workWithFiles = new WorkWithFiles("D:\\Test");

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
                    case "help":
                        Console.WriteLine("make" + "\t make имя файла [... имя файла]" +
                            "\n\tпредназначена для создания файлов. Параметры вводятся после команды черезе пробел." +
                            "\n\tПринимает параматеры как с абсолютным путем, так и с относительным.");
                        Console.WriteLine("remove" + "\t remove имя файла [... имя файла]" +
                            "\n\tпредназначена для удаления файлов. Параметры вводятся после команды черезе пробел." +
                            "\n\tПринимает параматеры как с абсолютным путем, так и с относительным.");
                        Console.WriteLine("goto" + "\t goto F:\\ProgramFiles\\Test" +
                            "\n\tпредназначена для смены текущей директории. Принимает только один параметр");
                        Console.WriteLine("show" + "\t выводит все файлы текущей директории. Не принимает параметров");
                        Console.WriteLine("exit" + "\t предназначен для завершения работы");
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Такой команды нет!");
                        continue;
                }
                
            }

        }
    }
}
