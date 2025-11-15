using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GolovanovDO.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(3 * x + 2 - (2 * x - x) / (Math.Cos(x) + 1), 2);
                double d = (Math.Cos(x) + 1);

                if (d != 0)
                {
                    strY = Convert.ToString(y);
                }
                else
                {
                    strY = Convert.ToString(0);
                }




                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            
            return path;    
        }
    }
}
