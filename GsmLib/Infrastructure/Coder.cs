using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsmLib.Interface;

namespace GsmLib.Infrastructure
{
    public class Coder : ICoder
    {
        private IAlphabet _alphabet;

        public Coder(IAlphabet alphabet)
        {
            if (alphabet == null)
                throw new ArgumentNullException("alphabet");
            _alphabet = alphabet;
        }

        public bool SetAlphabet(IAlphabet alphabet)
        {
            if (alphabet == null)
                return false;
            _alphabet = alphabet;
            return true;
        }

        public byte[] Encode(string message)
        {
            if(String.IsNullOrEmpty(message))
                throw new ArgumentException("message null or empty");
            if(!_alphabet.CheckString(message))
                throw new ArgumentException("message contains invalid characters");

            var messageEnumer = message.GetEnumerator();
            messageEnumer.MoveNext();

            byte[] result = new byte[(int)Math.Ceiling(((message.Length * 7) / 8.0))];
            byte lastByte = _alphabet.CharToByte(messageEnumer.Current).Value;

            if (!messageEnumer.MoveNext())
            {
                result[0] = lastByte;
                return result;
            }

            var workBitInLast = 7;
            var workByte = 0;
            do
            {
                var nextByte = _alphabet.CharToByte(messageEnumer.Current).Value;
                var tempbyte = (byte)(nextByte << workBitInLast);
                lastByte = (byte)(lastByte | tempbyte);
                if (workBitInLast == 0)
                {
                    workBitInLast = 7;
                    continue;
                }
                result[workByte] = lastByte;
                lastByte = (byte)(nextByte >> (8 - workBitInLast));
                workBitInLast--;
                workByte++;
            } while (messageEnumer.MoveNext());

            if (workBitInLast != 0)
            {
                if ((message.Length * 7) % 8 == 1) // Согластно спецификации вместо семи 0 используется символ СR
                {
                    lastByte = (byte)(lastByte | (_alphabet.CharToByte('\r').Value << 1 ));
                }

                result[workByte] = lastByte;
            }

            return result;
        }

        public string Decode(byte[] payload)
        {
            StringBuilder result = new StringBuilder();
            if (payload.Count() == 0)
                throw new ArgumentException("payload is empty");

            var workByte = new byte();
            var bitForCopy = 7;
            foreach(byte b in payload)
            {
                var nextByte = b;
                nextByte = (byte)(nextByte << (8 - bitForCopy));
                nextByte = (byte)(nextByte >> 1);
                workByte = (byte)(workByte | nextByte);
                result.Append(_alphabet.ByteToChar(workByte));
                workByte = (byte)(b >> bitForCopy);
                bitForCopy--;
                if (bitForCopy == 0)
                {
                    result.Append(_alphabet.ByteToChar(workByte));
                    bitForCopy = 7;
                    workByte = byte.MinValue;
                }
            }
            return result.ToString();
        }

    }
}
