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

        [TestMethod]
        public void input_distance_40_visit_2_ls_20_15_should_return_35()
        {
            AssertShooseBestSum(40, 2, new List<int> { 20, 15 }, 35);
        }

        [TestMethod]
        public void input_distance_31_visit_2_ls_20_15_10_should_return_30()
        {
            AssertShooseBestSum(31, 2, new List<int> { 20, 15, 10 }, 30);
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
            if (visitCount == listOfDistance.Count)
            {
                return (listOfDistance.Sum() > maxDistance) ? default(int?) : listOfDistance.Sum();
            }

            int? choose = null;
            if (visitCount == 1)
            {
                choose = listOfDistance.FirstOrDefault(a => maxDistance >= a);
            }
            else if (visitCount == 2)
            {
                var result = new List<int>();
                for (int i = 0; i < listOfDistance.Count; i++)
                {
                    for (int j = 0; j < listOfDistance.Count; j++)
                    {
                        result.Add(listOfDistance[i] + listOfDistance[j]);
                    }
                }

                choose = result.Distinct().OrderByDescending(a => a).FirstOrDefault(a => maxDistance >= a);
            }

            return choose == 0 ? default(int?) : choose;
        }
    }
}