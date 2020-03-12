using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilestoneTG.Data;

namespace MilestoneTG.Tests
{
    [TestClass]
    public class DataConversionTests
    {
        [TestMethod]
        public void ConvertStrings()
        {
            object expected = "foo";
            string actual = DataUtil.Convert<string>(expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertIntegers()
        {
            object expected = 100;
            int actual = DataUtil.Convert<int>(expected);
            Assert.AreEqual(expected, actual);
        }

    }
}
