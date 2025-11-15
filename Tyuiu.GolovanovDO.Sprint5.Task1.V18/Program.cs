using Tyuiu.GolovanovDO.Sprint5.Task1.V18.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        int starValue = -5;
        int stopValue = 5;

        Console.WriteLine("Исходные данные: ");
        Console.WriteLine("starValue = " + starValue + " stopValue = " + stopValue);
        string res = ds.SaveToFileTextData(starValue, stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();


    }
}