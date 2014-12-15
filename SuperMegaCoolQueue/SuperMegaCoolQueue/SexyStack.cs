using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMegaCoolQueue
{
    public class SexyStack<T>: ISexyStack<T>
    {
        public int Count { get; private set; }

        private ListNode<T> _first;
        private ListNode<T> _last;

        public SexyStack()
        {
            _first = new ListNode<T>(default(T));
            _last = _first;
            Count = 0;
        }

        public T Peek()
        {
            CheckIfEmpty();
            return _first.Data;
        }

        public void Push(T item)
        {
            var newItem = new ListNode<T>(item);

            if (Empty())
                _first = newItem;

            newItem.Next = _first;
            _first = newItem;
            Count++;
        }

        public T Pop()
        {
            CheckIfEmpty();
            var deleted = _first.Data;
            _first = _first.Next ?? _last;
            Count--;
            return deleted;
        }

        private bool Empty()
        {
            return (Count == 0);
        }

        private void CheckIfEmpty()
        {
            if (Empty())
                throw new Exception("Stack is empty");
        }
    }
}
