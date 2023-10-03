// See https://aka.ms/new-console-template for more information
using WorksWithFilesLibrary;

Console.WriteLine("Hello, World!");
var a = new WorkWithFiles("D:\\");
//a.WriteCurrentPath();
a.ShowFiles();


a.ChangeDirectory(Console.ReadLine());
a.WriteCurrentDirectory(); a.ChangeDirectory(Console.ReadLine());
a.WriteCurrentDirectory(); a.ChangeDirectory(Console.ReadLine());

//a.WriteCurrentPath(); a.CreateFile(Console.ReadLine());
