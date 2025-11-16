using Tyuiu.GolovanovDO.Sprint5.Task7.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\Users\0\AppData\Local\Temp\InPutDataFileTask7V19.txt";

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine();

        string res = ds.LoadDataAndSave(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}