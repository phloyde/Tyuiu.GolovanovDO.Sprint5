using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GolovanovDO.Sprint5.Task2.V20.Lib
{
    public class DataService : ISprint5Task2V20
    {
        public string SaveToFileTextData(int[,] mtrx)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mtrx[i,j] < 0)
                    {
                        mtrx[i, j] = 0;
                    } 
                    if (mtrx[i, j] > 0)
                    {
                        mtrx[i, j] = 1;
                    }
                }
            }

            string str = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + mtrx[i, j] + ";";
                    }
                    else
                    {
                        str = str + mtrx[i, j];
                    }
                }

                if (i != rows-1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
                str = "";
            }
            return path;

        }
    }
}
