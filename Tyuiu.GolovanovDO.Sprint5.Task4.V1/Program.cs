using Tyuiu.GolovanovDO.Sprint5.Task4.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string path = @"C:\Users\0\AppData\Local\Temp\InPutDataFileTask4V1.txt";


        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine();

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}