using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MilestoneTG.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void TestByteToStringConversion()
        {
            String foo = "foo bar";
            byte[] bytes = foo.GetUtf8Bytes();
            string bar = bytes.GetUtf8String();

            Assert.AreEqual(foo, bar);
        }

        [TestMethod]
        public void ToTitleCase_should_capitalize_the_first_letter_of_each_word()
        {
            String foo = "foo bar";
            String bar = foo.ToTitleCase();

            Assert.AreEqual("Foo Bar", bar);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void ToTitleCaseNullorWhitespace_should_return_original_value(string value)
        {
            Assert.AreEqual(value, value.ToTitleCase());
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("  ")]
        public void ToSentenseCase_NullorWhitespace_should_return_original_value(string value)
        {
            Assert.AreEqual(value, value.ToSentenceCase());
        }

        [DataTestMethod]
        [DataRow("this is a sentence. this is a question? happy! happy! joy! joy! string manipulation rocks!",
                 "This is a sentence. This is a question? Happy! Happy! Joy! Joy! String manipulation rocks!",
                 DisplayName = "Without leading whitespace")]
        [DataRow("  this is a sentence. this is a question? happy! happy! joy! joy! string manipulation rocks!",
                 "  This is a sentence. This is a question? Happy! Happy! Joy! Joy! String manipulation rocks!",
                 DisplayName = "With leading whitespace")]
        public void ToSentenceCase_should_capitalize_the_first_letter_of_each_sentence(string sentence, string expected)
        {
            String foo = sentence.ToSentenceCase();

            Assert.AreEqual(expected, sentence.ToSentenceCase());

            // There was a bug where it wasn't skipping if a sentence was already capital, and we were getting 
            // additional uppercase chars. For example, "Hello.".ToSentenceCase() returned "HEllo."
            Assert.AreEqual(expected, expected.ToSentenceCase());
        }

        [TestMethod]
        public void IsUpperCase_should_return_true_when_all_upper()
        {
            Assert.IsTrue("ABCD".IsUpperCase());
        }

        [DataTestMethod]
        [DataRow("abc")]
        [DataRow("Abc")]
        [DataRow("aBc")]
        [DataRow("abC")]
        public void IsUpperCase_should_return_false_when_not_all_upper(string value)
        {
            Assert.IsFalse(value.IsUpperCase());
        }
    }
}
