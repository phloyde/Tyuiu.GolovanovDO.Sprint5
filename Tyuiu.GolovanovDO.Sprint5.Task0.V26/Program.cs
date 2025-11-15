using Tyuiu.GolovanovDO.Sprint5.Task0.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 2;

        Console.WriteLine("Исходные данные: " + x);
        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();

    }
}