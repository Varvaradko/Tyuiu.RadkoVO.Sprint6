using Tyuiu.RadkoVO.Sprint6.Task0.V6.Lib;

namespace Tyuiu.RadkoVO.Sprint6.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(3);

            double wait = 0.866;

            Assert.AreEqual(wait, res);
        }
    }
}
