using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler_Problems.Problem1_10;

namespace Euler_Tests
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        public void SumOfEvenFibonacci_Below40_ShouldBe44()
        {
            Assert.AreEqual(44, Problem2.SumOfEvenFibonacci(40));
        }

        [TestMethod]
        public void SumOfEvenFibonacci_Below4000000_ShouldBe4613732()
        {
            Assert.AreEqual(4613732, Problem2.SumOfEvenFibonacci(4000000));
        }
    }
}
