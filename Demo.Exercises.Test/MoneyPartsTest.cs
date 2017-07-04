using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Exercises.Test
{
    [TestClass]
    public class MoneyPartsTest
    {
        [TestMethod]
        public void TestBuildMoneyParts()
        {
            var input = 0.35m;
            var output = new MoneyParts().Build(input);

            var eachSumEqualsToInput = output.TrueForAll(x => x.Sum() == input);

            Assert.AreEqual(output.Count(), 6);
        }
       
    }
}
