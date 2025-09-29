using Tyuiu.IvanovEO.Sprint1.Task4.V5.Lib;
namespace Tyuiu.IvanovEO.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService dataService = new DataService();
            double x = 1;
            double y = 1;
            var res = dataService.Calculate(x, y);
            Assert.AreEqual(0.5 , res);

        }
    }
}
