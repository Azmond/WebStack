using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStringStack.Models.Repository
{
    public interface IStringStackRepository
    {
        void Push(string str);
        bool Pop(out string str);
        bool Peek(out string str);
        int Size();
    }
}
