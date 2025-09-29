using Tyuiu.IvanovEO.Sprint1.Task2.V11.Lib;
namespace Tyuiu.IvanovEO.Sprint1.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
         DataService ds = new DataService();
            int x = 2;
            int y = 3;
            var res = ds.ConvertHoursMinutesToSeconds(x, y);
            Assert.AreEqual(900, res);
        }
    }
}
