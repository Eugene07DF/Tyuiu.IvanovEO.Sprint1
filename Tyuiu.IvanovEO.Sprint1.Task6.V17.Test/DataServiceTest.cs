using Newtonsoft.Json.Linq;
using Tyuiu.IvanovEO.Sprint1.Task6.V17.Lib;
namespace Tyuiu.IvanovEO.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            var solution = new DataService();
            string input = "Madam";
            bool result = solution.CheckPalindrome(input);
            Assert.IsTrue(result);

        }
    }
}
