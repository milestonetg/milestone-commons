using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MilestoneTG.Data;

namespace MilestoneTG.Tests
{
    [TestClass]
    public class BooleanTests
    {
        [DataTestMethod]
        [DataRow("1")]
        [DataRow("y")]
        [DataRow("yes")]
        [DataRow("t")]
        [DataRow("true")]
        public void Truethy_values_should_parse_to_true(string value)
        {
            bool success = DataUtil.TryParseBool(value, out bool boolValue);
            Assert.IsTrue(success);
            Assert.IsTrue(boolValue);
        }

        [DataTestMethod]
        [DataRow("0")]
        [DataRow("n")]
        [DataRow("no")]
        [DataRow("f")]
        [DataRow("false")]
        public void Falsey_values_should_parse_to_false(string value)
        {
            bool success = DataUtil.TryParseBool(value, out bool boolValue);
            Assert.IsTrue(success);
            Assert.IsFalse(boolValue);
        }
        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        [DataRow("foo")]
        public void Invalid_values_should_fail_to_parse(string value)
        {
            bool success = DataUtil.TryParseBool(value, out bool boolValue);
            Assert.IsFalse(success);
        }

        [DataTestMethod]
        [DataRow("1")]
        [DataRow("y")]
        [DataRow("yes")]
        [DataRow("t")]
        [DataRow("true")]
        [DataRow("0")]
        [DataRow("n")]
        [DataRow("no")]
        [DataRow("f")]
        [DataRow("false")]
        public void Convert_should_succeed_with_valid_boolean_values(object value)
        {
            bool result = DataUtil.Convert<bool>(value);
            DataUtil.TryParseBool(value.ToString(), out bool boolValue);
            Assert.AreEqual(boolValue, result);
        }

        [TestMethod]
        public void Convert_should_return_default_for_dbnull()
        {
            bool result = DataUtil.Convert<bool>(DBNull.Value);
            Assert.AreEqual(default(bool), result);
        }

        [TestMethod]
        public void Convert_should_return_default_for_null()
        {
            bool result = DataUtil.Convert<bool>(null);
            Assert.AreEqual(default(bool), result);
        }
    }
}
