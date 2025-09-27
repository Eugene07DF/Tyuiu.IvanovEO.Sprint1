using Tyuiu.IvanovEO.Sprint1.Task1.V20.Lib;
namespace Tyuiu.IvanovEO.Sprint1.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(10.5, res);
        }
    }
}
