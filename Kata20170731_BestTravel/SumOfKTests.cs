using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Kata20170731_BestTravel
{
    [TestClass]
    public class SumOfKTests
    {
        [TestMethod]
        public void input_distance_10_visit_1_ls_50_should_return_null()
        {
            AssertShooseBestSum(10, 1, new List<int> { 50 }, null);
        }

        [TestMethod]
        public void input_distance_16_visit_1_ls_20_15_should_return_15()
        {
            AssertShooseBestSum(16, 1, new List<int> { 20, 15 }, 15);
        }

        [TestMethod]
        public void input_distance_20_visit_1_ls_20_15_should_return_20()
        {
            AssertShooseBestSum(20, 1, new List<int> { 20, 15 }, 20);
        }

        [TestMethod]
        public void input_distance_20_visit_2_ls_20_15_should_return_20()
        {
            AssertShooseBestSum(20, 1, new List<int> { 20, 15 }, 20);
        }

        [TestMethod]
        public void input_distance_30_visit_2_ls_20_15_should_return_null()
        {
            AssertShooseBestSum(30, 2, new List<int> { 20, 15 }, null);
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
            if (visitCount == listOfDistance.Count
                && listOfDistance.Sum() > maxDistance)
            {
                return null;
            }

            int? choose = listOfDistance.FirstOrDefault(a => maxDistance >= a);
            return choose == 0 ? default(int?) : choose;
        }
    }
}