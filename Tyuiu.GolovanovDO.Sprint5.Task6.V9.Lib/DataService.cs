using System.Runtime.Intrinsics.X86;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GolovanovDO.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            str = str.Replace(",", "");

            string[] sTring = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int cnt = 0;
            foreach (string s in sTring)
            {
                if (s.Length == 3)
                {
                    cnt++;
                }
            }
            return cnt;
        }
        


    }
}
