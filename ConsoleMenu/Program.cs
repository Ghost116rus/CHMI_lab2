using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorksWithFilesLibrary;


namespace ConsoleMenu
{
    internal class Program
    {
        private static void ShowMainMenu()
        {
            Console.WriteLine("Меню действий:\n" +
                              "1 - Создать файл\n" +
                              "2 - Показать текущую директорию\n" +
                              "3 - Удалить\n" +
                              "4 - Перейти\n" +
                              "5 - Выход\n");
        }

        private static void HandleCreateFile(WorkWithFiles fO)
        {

            Console.WriteLine("Введите название и формат файла (относительным или абсолютным путём");
            var newFileName = Console.ReadLine();
            var res = fO.CreateFile(newFileName);
            if(res == -2)
            {
                Console.WriteLine($"{newFileName} - неправильное расширение файла!");
            } else if (res == -1) {
                Console.WriteLine("Произошла ошибка при создании файла");
            } else
            {
                Console.WriteLine("Файл успешно создан");
            }

        }

        private static void HandleDeleteFile(WorkWithFiles fO)
        {
            var delChoice = "2";
            var files = Directory.GetFileSystemEntries(fO.CurrentDirectory);
            if (files.Count() > 0)
            {
                Console.WriteLine("1 - в текущем каталоге\n2 - абсолютным путём к файлу");
                delChoice = Console.ReadLine();
                while (delChoice != "1" && delChoice != "2")
                {
                    Console.WriteLine("Такого выбора нет");
                    delChoice = Console.ReadLine();
                }
            }

            string newFileName;
            if (delChoice == "1")
            {

                var i = 1;
                foreach (var file in files)
                {

                    Console.WriteLine($" {i++} - {file}");
                }
                Console.WriteLine("Введите индекс файла:");
                newFileName = Console.ReadLine();
                try
                {
                    var fileIndex = int.Parse(newFileName) - 1;
                    newFileName = Path.Combine(fO.CurrentDirectory, files[fileIndex]);
                }
                catch
                {
                    Console.WriteLine("Такого файла не существует");
                    return;
                }
            }
            else
            {

                Console.WriteLine("Введите абсолютный путь к файлу и формат файла:");
                newFileName = Console.ReadLine();
            }

            var res = fO.DeleteFile(newFileName);
            if (res == -2)
            {
                Console.WriteLine($"{newFileName} - такого файла не существует!");
            }
            else if (res == -1)
            {
                Console.WriteLine("Произошла ошибка при удалении файла");
            }
            else
            {
                Console.WriteLine("Файл успешно удалён");
            }

        }
        private static void HandleChangeDirectory(WorkWithFiles fO)
        {
            var choice = "2";
            var directories = Directory.GetDirectories(fO.CurrentDirectory);
            if (directories.Count() > 0)
            {
                Console.WriteLine("1 - в текущем каталоге\n2 - абсолютным путём к каталогу");
                choice = Console.ReadLine();
                while (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Такого выбора нет");
                    choice = Console.ReadLine();
                }
            }

            string newDirectory;
            if (choice == "1")
            {
                var i = 1;
                foreach (var directory in directories)
                {

                    Console.WriteLine($" {i++} - {directory}");
                }
                Console.WriteLine("Введите индекс каталога:");
                newDirectory = Console.ReadLine();
                try
                {
                    var newDirIndex = int.Parse(newDirectory) - 1;
                    newDirectory = Path.Combine(fO.CurrentDirectory, directories[newDirIndex]);
                }
                catch
                {
                    Console.WriteLine("Такого каталога не существует");
                    return;
                }
            }
            else
            {

                Console.WriteLine("Введите абсолютный путь к каталогу:");
                newDirectory = Console.ReadLine();
            }
            fO.ChangeDirectory(newDirectory);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текущий каталог файлов абсолютным путём либо пробел");
            var rootAsk = Console.ReadLine().Trim();
            var rootPath = rootAsk == ""? "C:\\chmitest": rootAsk;
            var fileOperator = new WorkWithFiles(rootPath);
            Console.WriteLine("Текущий каталог файлов:");
            fileOperator.ShowFiles();

            var exit = false;
            while (!exit)
            {
                ShowMainMenu();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        HandleCreateFile(fileOperator);
                        break;
                    case "2":
                        fileOperator.ShowFiles();
                        break;
                    case "3":
                        HandleDeleteFile(fileOperator);
                        break;
                    case "4":
                        HandleChangeDirectory(fileOperator);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Команда отсутствует");
                        break;
                   
                }
            }
        }
    }
}
