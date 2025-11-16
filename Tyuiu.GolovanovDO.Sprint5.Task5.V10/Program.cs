using Tyuiu.GolovanovDO.Sprint5.Task5.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string path = @"C:\Users\0\AppData\Local\Temp\InPutDataFileTask5V10.txt";

        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine();

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}