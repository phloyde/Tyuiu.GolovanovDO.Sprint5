using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GolovanovDO.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на числа по пробелам
                    string[] numberStrings = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numberStrings)
                    {
                        // Заменяем точку на запятую для корректного парсинга
                        string formattedNumber = numberStr.Replace(".", ",");

                        if (double.TryParse(formattedNumber, out double number))
                        {
                            // Проверяем на четность (только целые числа)
                            if (number % 1 == 0 && number % 2 == 0)
                            {
                                res += number;
                            }
                        }
                    }
                }
            }
            return res;
        }
    }
}
