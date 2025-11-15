using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GolovanovDO.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
