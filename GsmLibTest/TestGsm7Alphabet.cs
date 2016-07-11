using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GsmLib.Interface;
using GsmLib.Infrastructure;

namespace GsmLibTest
{
    [TestClass]
    public class TestGsm7Alphabet
    {
        [TestMethod]
        public void TestGsm7Alphabet_ConvertToByte()
        {
            IAlphabet alphabet = new Gsm7Alphabet();
            char c = 'd';

            var result = alphabet.CharToByte(c).Value;

            Assert.AreEqual(result, 0x64);

        }

        [TestMethod]
        public void TestGsm7Alphabet_ConvertToChar()
        {
            IAlphabet alphabet = new Gsm7Alphabet();
            byte b = 0x64;

            var result = alphabet.ByteToChar(b).Value;

            Assert.AreEqual(result, 0x64);
        }

        [TestMethod]
        public void TestGsm7Alphabet_ConvertInvalidValues()
        {
            IAlphabet alphabet = new Gsm7Alphabet();
            char c = '{';
            byte b = 0xFF;

            var resultByte = alphabet.CharToByte(c);
            var resultChar = alphabet.ByteToChar(b);

            Assert.IsFalse(resultByte.HasValue);
            Assert.IsFalse(resultChar.HasValue);
        }

        [TestMethod]
        public void TestGsm7Alphabet_CheckString()
        {
            IAlphabet alphabet = new Gsm7Alphabet();
            string goodStr = "Hello World!";
            string badStr = "War never {changes}";

            var resultGood = alphabet.CheckString(goodStr);
            var resultFail = alphabet.CheckString(badStr);

            Assert.IsTrue(resultGood);
            Assert.IsFalse(resultFail);
        }


    }
}
