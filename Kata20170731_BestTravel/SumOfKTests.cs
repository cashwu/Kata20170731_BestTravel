using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Kata20170731_BestTravel
{
    [TestClass]
    public class SumOfKTests
    {
        [TestMethod]
        public void input_distance_10_visit_2_ls_50_should_return_null()
        {
            AssertShooseBestSum(10, 2, new List<int> { 50 }, null);
        }

        private static void AssertShooseBestSum(int maxDistance, int visitCount, List<int> listOfDistance, int? expected)
        {
            var sumOfk = new SumOfK();
            var actual = sumOfk.chooseBestSum(maxDistance, visitCount, listOfDistance);
            Assert.AreEqual(expected, actual);
        }
    }

    public class SumOfK
    {
        public int? chooseBestSum(int maxDistance, int visitCount, List<int> listOfDistance)
        {
            return null;
        }
    }
}