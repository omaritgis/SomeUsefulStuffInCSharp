using System;
using NUnit.Framework;

namespace SomeUsefulStuffInCSharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0.83)]
        public static double confidenceInterval(double phatt){
            double n = 100;
            double p1 = phatt + 1.96*Math.Sqrt((phatt * (1-phatt)) / n);
            double p2 = phatt - 1.96*Math.Sqrt((phatt * (1-phatt)) / n);
            Assert.IsTrue(0.832 < p1 && 0.832 > p2, "Test");
            
            return p2;
        }
    }
}