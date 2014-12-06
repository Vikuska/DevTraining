using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMegaCoolQueue
{
    public class SexyStack<T>: ISexyStack<T>
    {
        public int Count { get { return _count; } }

        private ListNode<T> _first;
        private ListNode<T> _last;
        private int _count;

        public SexyStack()
        {
            _first = new ListNode<T>(default(T));
            _last = _first;
            _count = 0;
        }

        public T Peek()
        {
            CheckIfEmpty();
            return _first.Data;
        }

        public void Push(T item)
        {
            ListNode<T> newItem = new ListNode<T>(item);

            if (Empty())
                _first = newItem;

            newItem.Next = _first;
            _first = newItem;
            _count++;
        }

        public T Pop()
        {
            CheckIfEmpty();
            var deleted = _first.Data;
            _first = _first.Next ?? _last;
            _count--;
            return deleted;
        }

        private bool Empty()
        {
            return (_count == 0) || (_first == null);
        }

        private void CheckIfEmpty()
        {
            if (Empty())
                throw new Exception("Stack is empty");
        }
    }
}
