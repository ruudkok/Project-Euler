using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler_Problems.Problem1_10;

namespace Euler_Tests
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        public void SumOfMultiplesOfTheeAndFive_Below10_ShouldBe23()
        {            
            int sumOfMultiplesMax10 = Problem1.CalculateSumOfMultiplesOfTheeAndFive(10);            
            Assert.AreEqual(23, sumOfMultiplesMax10);            
        }

        [TestMethod]
        public void SumOfMultiplesOfThreeAndFive_Below1000_ShouldBe233168()
        {
            int sumOfMultiplesMax1000 = Problem1.CalculateSumOfMultiplesOfTheeAndFive(1000);            
            //Assert.AreEqual(sumOfMultiplesMax1000, 23); // Assert.AreEqual failed. Expected:<233168>. Actual:<23>.
            Assert.AreEqual(233168, sumOfMultiplesMax1000);
        }
    }
}
