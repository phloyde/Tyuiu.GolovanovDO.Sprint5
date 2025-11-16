using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GolovanovDO.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на числа по пробелам
                    string[] numberStrings = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numberStrings)
                    {
                        if (numberStr.Length == 3)
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }


    }
}
