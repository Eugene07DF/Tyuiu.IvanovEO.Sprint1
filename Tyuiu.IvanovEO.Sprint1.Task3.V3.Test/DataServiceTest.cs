using System.Net.WebSockets;
using Tyuiu.IvanovEO.Sprint1.Task3.V3.Lib;
namespace Tyuiu.IvanovEO.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds= new DataService();
            double x = 2;
            double y = 3;
            double z = 4;
            var res = ds.ParallelepipedVolume(x, y, z);
            Assert.AreEqual(24, res);
        }
    }
}
