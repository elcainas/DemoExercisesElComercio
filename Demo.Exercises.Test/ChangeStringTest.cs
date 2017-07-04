using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Exercises.Test
{
    [TestClass]
    public class ChangeStringTest
    {
        [TestMethod]
        public void TestBuildChangeStringOnlyLetters()
        {
            var input = "aCdgPqZ";
            var output = ChangeString.Build(input);
            Assert.AreEqual(output, "bDehQr");
        }
        [TestMethod]
        public void TestBuildCangeStringLettersAndOthersChars()
        {
            var input = "gjTa2z~1kJa";
            var output = ChangeString.Build(input);
            Assert.AreEqual(output, "hkUb2~1lKb");
        }
    }
}
