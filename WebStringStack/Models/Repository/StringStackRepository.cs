using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStringStack.Models.Repository
{
    public class StringStackRepository : IStringStackRepository
    {
        private ConcurrentStack<string> _stringStack = null;
        private readonly int _attempts = 10;

        public StringStackRepository()
        {
            _stringStack = new ConcurrentStack<string>();
        }


        public bool Peek(out string str)
        {
            for(int attempt=0; attempt<_attempts; attempt++)
            {
                if (_stringStack.TryPeek(out str)) return true;
            }
            str = string.Empty;
            return false;
        }

        public bool Pop(out string str)
        {
            for (int attempt = 0; attempt < _attempts; attempt++)
            {
                if (_stringStack.TryPop(out str)) return true;
            }
            str = string.Empty;
            return false;
        }

        public void Push(string str)
        {
            _stringStack.Push(str);
        }

        public int Size()
        {
            return _stringStack.Count();
        }
    }
}
