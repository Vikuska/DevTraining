using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMegaCoolQueue
{
    public interface IQueue<T>
    {
        int Count { get; }
        T FirstElement();
        T LastElement();
        void Enqueue(T item);
        ListNode<T> Dequeue();
    }
}
