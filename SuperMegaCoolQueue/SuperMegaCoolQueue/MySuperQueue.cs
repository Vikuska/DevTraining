using System;

namespace SuperMegaCoolQueue
{
    public class MySuperQueue<T> : IQueue<T>
    {
        public int Count { get; private set; }

        private ListNode<T> _first;
        private ListNode<T> _last;

        public MySuperQueue()
        {
            _first = new ListNode<T>(default(T));
            _last = _first;
            Count = 0;
        }

        public void Enqueue(T item)
        {
            ListNode<T> newItem = new ListNode<T>(item);

            if (Empty())
                _first = newItem;

            _last.Next = newItem;
            _last = newItem;

            Count++;
        }

        public T Dequeue()
        {
            CheckIfEmpty();
            var elementToDeueue = _first;
            _first = _first.Next ?? _last;
            Count--;
            return elementToDeueue.Data;
        }

        public T FirstElement()
        {
            CheckIfEmpty();
            return _first.Data;
        }

        public T LastElement()
        {
            CheckIfEmpty();
            return _last.Data;
        }

        private bool Empty()
        {
            return (Count == 0);
        }

        private void CheckIfEmpty()
        {
            if (Empty())
                throw new Exception("Queue is empty");
        }
    }
}
