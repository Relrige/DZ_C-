using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Generic_types
{
    interface IStack<T>//:IEnumerable<T>
    {
        void Push(T elem);
        void Pop();
        bool Empty();
        bool TryPeek(out T result);
        bool TryPop(out T result);

        int Size { get; }
        uint Count{ get; }
        T Peek();
    }
}
