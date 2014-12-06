using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMegaCoolQueue
{
    public interface ISexyStack<T>
    {
        int Count { get; }
        T Peek();
        void Push(T item);
        T Pop();
    }
}
