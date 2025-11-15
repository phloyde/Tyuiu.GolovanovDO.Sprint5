using Tyuiu.GolovanovDO.Sprint5.Task2.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] mtrx = new int[rows, cols];


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Введите {i}, {j} элемента массива: ");
                mtrx[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        string res = ds.SaveToFileTextData(mtrx);



        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}