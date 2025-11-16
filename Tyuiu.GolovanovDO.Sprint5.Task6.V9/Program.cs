using Tyuiu.GolovanovDO.Sprint5.Task6.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string path = @"C:\Users\0\AppData\Local\Temp\InPutDataFileTask6V9.txt";

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine();

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}