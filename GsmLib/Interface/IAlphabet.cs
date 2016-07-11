using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmLib.Interface
{
    public interface IAlphabet
    {
        bool CheckString(string str);
        byte? CharToByte(char c);
        char? ByteToChar(byte b);
    }
}
