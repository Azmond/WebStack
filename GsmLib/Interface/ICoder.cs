using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmLib.Interface
{
    public interface ICoder
    {
        bool SetAlphabet(IAlphabet alphabet);
        byte[] Encode(string message);
        string Decode(byte[] payload);
    }
}
