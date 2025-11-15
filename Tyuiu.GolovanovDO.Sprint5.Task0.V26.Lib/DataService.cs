using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GolovanovDO.Sprint5.Task0.V26.Lib
{
    public class DataService : ISprint5Task0V26
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = "OutPutFileTask0.txt";

            double result = 2 * Math.Pow(x, 2) + 3 * x - 4;
            File.WriteAllText(outputFile, result.ToString());

            return outputFile;
        }
    }
}
