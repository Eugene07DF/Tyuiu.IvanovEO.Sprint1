using Tyuiu.IvanovEO.Sprint1.Task7.V5.Lib;
namespace Tyuiu.IvanovEO.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new DataService();
            double input = 2;
            double result = calculator.Calculate(input);
            Assert.AreEqual(result, -0.545);
        }
    }
}
