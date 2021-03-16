using NUnit.Framework;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double s = Channel.Formula(3, 5, 8);
            Assert.AreEqual(197.92,s, 0.01);
            
        }
        [Test]
        public void Test2()
        {
            double s = Channel.Formula(3, 5, 8);
            Assert.Throws<System.ArgumentException>(()=> {
                double s = Channel.Formula(-3, 5, 8);
            });
        }
    }
}