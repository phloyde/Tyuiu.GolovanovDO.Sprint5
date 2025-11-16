using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GolovanovDO.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(1 - (Math.Cos(Convert.ToInt32(strX)) + Convert.ToInt32(strX)) - 4.12 * Convert.ToInt32(strX), 3);
            return res;

        }
    }
}
