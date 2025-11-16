using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GolovanovDO.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);

            str = str.Replace("сс", "с");
            str = str.Replace("Сс", "С");

            return str;
        }
    }
}
