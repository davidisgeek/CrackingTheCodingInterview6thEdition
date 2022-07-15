using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ch01._Arrays_and_Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01._Arrays_and_Strings.Tests
{
    [TestClass()]
    public class Q1_1_IsUniqueTests
    {
        private readonly Q1_1_IsUnique q1_1_IsUnique;

        public Q1_1_IsUniqueTests()
        {
            q1_1_IsUnique = new Q1_1_IsUnique();
        }

        [TestMethod()]
        [DataRow("a")]
        [DataRow("ab")]
        [DataRow("abcdef")]
        public void IsUniqueIneffecient_InputIsUnique_ReturnTrue(string str)
        {
            var result = q1_1_IsUnique.IsUniqueIneffecient(str);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("aa")]
        [DataRow("abab")]
        [DataRow("casa")]
        [DataRow("eve")]
        [DataRow("abdefghijkk")]
        public void IsUniqueIneffecient_InputIsNotUnique_ReturnFalse(string str)
        {
            var result = q1_1_IsUnique.IsUniqueIneffecient(str);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        [DataRow("a")]
        [DataRow("ab")]
        [DataRow("abcdef")]
        public void IsUniqueSorted_InputIsUnique_ReturnTrue(string str)
        {
            var result = q1_1_IsUnique.IsUniqueSorted(str);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("aa")]
        [DataRow("abab")]
        [DataRow("casa")]
        [DataRow("eve")]
        [DataRow("abdefghijkk")]
        public void IsUniqueSorted_InputIsNotUnique_ReturnFalse(string str)
        {
            var result = q1_1_IsUnique.IsUniqueSorted(str);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        [DataRow("a")]
        [DataRow("ab")]
        [DataRow("abcdef")]
        public void IsUniqueHashArray_InputIsUnique_ReturnTrue(string str)
        {
            var result = q1_1_IsUnique.IsUniqueHashArray(str);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("aa")]
        [DataRow("abab")]
        [DataRow("casa")]
        [DataRow("eve")]
        [DataRow("abdefghijkk")]
        public void IsUniqueHashArray_InputIsNotUnique_ReturnFalse(string str)
        {
            var result = q1_1_IsUnique.IsUniqueHashArray(str);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        [DataRow("a")]
        [DataRow("ab")]
        [DataRow("abcdef")]
        public void IsUniqueHashSet_InputIsUnique_ReturnTrue(string str)
        {
            var result = q1_1_IsUnique.IsUniqueHashSet(str);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("aa")]
        [DataRow("abab")]
        [DataRow("casa")]
        [DataRow("eve")]
        [DataRow("abdefghijkk")]
        public void IsUniqueHashSet_InputIsNotUnique_ReturnFalse(string str)
        {
            var result = q1_1_IsUnique.IsUniqueHashSet(str);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        [DataRow("a")]
        [DataRow("ab")]
        [DataRow("abcdef")]
        public void IsUniqueBitVector_InputIsUnique_ReturnTrue(string str)
        {
            var result = q1_1_IsUnique.IsUniqueBitVector(str);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        [DataRow("aa")]
        [DataRow("abab")]
        [DataRow("casa")]
        [DataRow("eve")]
        [DataRow("abdefghijkk")]
        public void IsUniqueBitVector_InputIsNotUnique_ReturnFalse(string str)
        {
            var result = q1_1_IsUnique.IsUniqueHashSet(str);

            Assert.IsFalse(result);
        }
    }
}