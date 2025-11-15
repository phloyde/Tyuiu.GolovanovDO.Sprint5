namespace Tyuiu.GolovanovDO.Sprint5.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\0\source\repos\Tyuiu.GolovanovDO.Sprint5\Tyuiu.GolovanovDO.Sprint5.Task0.V26\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo  fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
    