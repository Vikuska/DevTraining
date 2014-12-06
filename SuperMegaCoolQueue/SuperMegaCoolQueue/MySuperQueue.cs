﻿using System;

namespace SuperMegaCoolQueue
{
    public class MySuperQueue<T> : IQueue<T>
    {
        public int Count
        {
            get { return _count; }
        }

        private ListNode<T> _first;
        private ListNode<T> _last;
        private int _count;
        
        public MySuperQueue()
        {
            _first = new ListNode<T>(default(T));
            _last = _first;
            _count = 0;
        }

        public void Enqueue(T item)
        {
            ListNode<T> newItem = new ListNode<T>(item);

            if (Empty())
                _first = newItem;

            _last.Next = newItem;
            _last = newItem;

            _count++;
        }

        public ListNode<T> Dequeue()
        {
            CheckIfEmpty();
            var elementToDeueue = _first;
            _first = _first.Next ?? _last;
            _count--;
            return elementToDeueue;
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
            return (_count == 0) || (_first == null);
        }

        private void CheckIfEmpty()
        {
            if (Empty())
                throw new Exception("Queue is empty");
        }
    }
}
