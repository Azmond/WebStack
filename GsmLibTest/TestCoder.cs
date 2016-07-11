using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GsmLib.Interface;
using GsmLib.Infrastructure;

namespace GsmLibTest
{
    [TestClass]
    public class TestCoder
    {


        [TestMethod]
        public void TestCoder_Encode()
        {
            
            ICoder coder = new Coder(new Gsm7Alphabet());
            string str = "dude";

            var result = coder.Encode(str);
           
            var goodresult = new byte[] { 228, 58, 185, 12 };
            for(int num = 0; num < result.Length; num++)
            {
                Assert.AreEqual(result[num], goodresult[num]);
            }
        }

        [TestMethod]
        public void TestCoder_Decode()
        {
            ICoder coder = new Coder(new Gsm7Alphabet());
            var payload = new byte[] { 228, 58, 185, 12 };
            
            var result = coder.Decode(payload);

            string str = "dude";
            Assert.AreEqual(result, str);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCoder_NullConstructor()
        {
            ICoder coder = new Coder(null);
        }

        [TestMethod]
        public void TestCoder_SetNullAlphabet()
        {
            ICoder coder = new Coder(new Gsm7Alphabet());

            var result = coder.SetAlphabet(null);

            Assert.IsFalse(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCoder_EncodeNull()
        {
            ICoder coder = new Coder(new Gsm7Alphabet());
            coder.Encode(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCoder_EncodeEmptyString()
        {
            ICoder coder = new Coder(new Gsm7Alphabet());
            coder.Encode("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCoder_DecodeEmptyPayload()
        {
            ICoder coder = new Coder(new Gsm7Alphabet());
            byte[] byts = new byte[0];
            coder.Decode(byts);
        }


    }
}
