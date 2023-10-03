using System;
using System.IO;


namespace WorksWithFilesLibrary
{
    public class WorkWithFiles
    {
        private string _currentDirectory;

        /// <summary>
        /// Устанавливает текущий путь по рабочему каталогу приложенемя
        /// </summary>
        public WorkWithFiles()
        {
            _currentDirectory = Directory.GetCurrentDirectory();
        }

        /// <summary>
        /// Возвращает и задает текущий каталог
        /// </summary>
        public string CurrentDirectory
        {
            get => _currentDirectory;
            private set
            {
                if (value is null || value == String.Empty)
                    return;
                _currentDirectory = value;
                Directory.SetCurrentDirectory(value);
            }
        }

        /// <summary>
        /// В случае, если папка по заданному пути существует, устанавливает текущий путь по заданному, 
        /// иначе устанавливает его по рабочему каталогу приложения
        /// </summary>
        /// <param name="path"></param>
        public WorkWithFiles(string path) : this()
        {
            if (Directory.Exists(path))
                _currentDirectory = path;

        }

        /// <summary>
        /// Выводит текущий каталог без переноса на следующую строку
        /// </summary>
        public void WriteCurrentDirectory() => Console.Write(CurrentDirectory + ">>");

        /// <summary>
        /// Смена текущего каталога, при .. - поднимается на каталог выше
        /// </summary>
        /// <param name="newPath">Новый каталог - путь может быть как относительный, так и абсолютный</param>
        public void ChangeDirectory(string newPath)
        {

            switch (newPath)
            {
                case ".":
                case "\\":
                case "\\\\":
                case "/":
                case "//":
                    return;
            }

            if (newPath == "..")
                CurrentDirectory = Directory.GetParent(CurrentDirectory)?.ToString();
            else if (Path.IsPathRooted(newPath) && Directory.Exists(newPath))
                CurrentDirectory = newPath;
            else if (Directory.Exists(Path.Combine(CurrentDirectory + newPath)))
                CurrentDirectory = Path.Combine(CurrentDirectory + newPath);
            else
                Console.WriteLine("Directory does not exist.");
        }

        /// <summary>
        /// Выводит сначала все папки текущего каталога, после все файлы
        /// </summary>
        public void ShowFiles()
        {
            string[] subdirectoryEntries = Directory.GetDirectories(CurrentDirectory);

            string[] fileEntries = Directory.GetFiles(CurrentDirectory);

            foreach (string subdirectoryEntry in subdirectoryEntries)
                Console.WriteLine("  " + subdirectoryEntry);
            foreach (string fileEntry in fileEntries)
                Console.WriteLine("  " + fileEntry);
        }

        /// <summary>
        /// Создает файл
        /// </summary>
        /// <param name="fileName">Получает название файла, либо с абсолютным путем, либо название файла + расширение его</param>
        /// <returns>-2 - неправильное расширение файла, -1 - ошибка создания файла, 1 - файл успешно создан</returns>
        public int CreateFile(string fileName)
        {
            var extension = Path.GetExtension(fileName);
            if (extension == string.Empty)
                return -2;
            try
            {
                using (File.Create(fileName))

                return 1;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                return -1;
            }
        }

        /// <summary>
        /// Удаляет файл
        /// </summary>
        /// <param name="fileName">Получает название файла, либо с абсолютным путем, либо название файла + расширение его</param>
        /// <returns>-2 - файл не существует, -1 - ошибка удаления файла, 1 - файл успешно удален</returns>
        public int DeleteFile(string fileName)
        {
            if (!File.Exists(fileName))
                return -2;
            try
            {
                File.Delete(fileName);
                return 1;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                return -1;
            }
        }
        
    }
}
