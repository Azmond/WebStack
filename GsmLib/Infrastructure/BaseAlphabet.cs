using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsmLib.Interface;

namespace GsmLib.Infrastructure
{
    public abstract class BaseAlphabet : IAlphabet
    {
        protected Dictionary<char, byte> _dictionaryAlphabet;

        protected BaseAlphabet()
        {
            _dictionaryAlphabet = new Dictionary<char, byte>();
            InitAlphabet();
        }

        public char? ByteToChar(byte b)
        {
            var result = _dictionaryAlphabet.Where(v => v.Value == b);
            if (result.Count() > 0)
                return result.First().Key;
            else
                return null;
        }

        public byte? CharToByte(char c)
        {
            var result = _dictionaryAlphabet.Where(k => k.Key == c);
            if (result.Count() > 0)
                return result.First().Value;
            else
                return null;
        }

        public bool CheckString(string str)
        {
            foreach(char c in str)
            {
                if (!_dictionaryAlphabet.Any(k => k.Key == c))
                    return false;
            }
            return true;
        }

        protected abstract void InitAlphabet();


    }
}
