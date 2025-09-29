using Tyuiu.IvanovEO.Sprint1.Task5.V6.Lib;
namespace Tyuiu.IvanovEO.Sprint1.Task5.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var solution = new DataService();
            int input = 1;
            int expected = 1;
            int actual = solution.Calculate(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
