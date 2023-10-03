// See https://aka.ms/new-console-template for more information
using WorksWithFilesLibrary;

Console.WriteLine("Hello, World!");
var a = new WorkWithFiles("D:\\");
//a.WriteCurrentPath();
a.ShowFiles();


a.ChangeDirectory(Console.ReadLine());
a.WriteCurrentDirectory();
a.CreateFile(Console.ReadLine());
a.CreateFile(Console.ReadLine());
a.CreateFile(Console.ReadLine());
a.ShowFiles();
a.DeleteFile(Console.ReadLine());
a.DeleteFile(Console.ReadLine());
a.DeleteFile(Console.ReadLine());

//a.WriteCurrentPath(); a.CreateFile(Console.ReadLine());
