using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Exercises.Test
{
    [TestClass]
    public class CompleteRangeTest
    {
        [TestMethod]
        public void TestBuildCompleteRange()
        {
            var input = new List<int>
            {
               8,9,2,6,15
            };
            var output = CompleteRange.Build(input);
            var sum = output.ToList().Sum();
            Assert.AreEqual(sum, (input.Max() * (input.Max() +1)) / 2);
            Assert.AreEqual(output.Count(), input.Max());
        }

    }
}
