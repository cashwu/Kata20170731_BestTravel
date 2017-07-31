using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170731_BestTravel
{
    [TestClass]
    public class SumOfKTests
    {
        [TestMethod]
        public void input_distance_10_visit_2_ls_50_should_return_null()
        {
            AssertShooseBestSum(10, 2, new List<int>(10), null);
        }

        private static void AssertShooseBestSum(int t, int k, List<int> ls, int? expected)
        {
            var sumOfk = new SumOfK();
            var actual = sumOfk.chooseBestSum(t, k, ls);
            Assert.AreEqual(expected, actual);
        }
    }

    public class SumOfK
    {
        public int? chooseBestSum(int t, int k, List<int> ls)
        {
            return null;
        }
    }
}
