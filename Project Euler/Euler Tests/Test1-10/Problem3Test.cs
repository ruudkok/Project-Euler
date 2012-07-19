using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler_Problems.Problem1_10;

namespace Euler_Tests.Test1_10
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        public void FindLargestPrimefactorOfCompositeNumber_Value13195_ShouldBe29()
        {
            Assert.AreEqual(29, Problem3.FindLargestPrimefactorOfCompositeNumber(13195));
        }        
    }
}
