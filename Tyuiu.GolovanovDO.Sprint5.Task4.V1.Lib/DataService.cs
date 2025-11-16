using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GolovanovDO.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double res = Math.Round(1 / (Math.Cos(double.Parse(strX)) + double.Parse(strX)) - 4.12 * double.Parse(strX), 3);
            return res;

        }
    }
}
