using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GolovanovDO.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }

            double y = Math.Round(x / (Math.Sqrt(Math.Pow(x, 2) + x)), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
