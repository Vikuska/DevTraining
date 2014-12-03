using System;

namespace SuperMegaCoolQueue
{
    class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data)
        {
            Data = data;
        }
    }

    internal class MySuperQueue<T>
    {
        private ListNode<T> _first;
        private ListNode<T> _last;
        private int size;
        public int Size
        {
            get { return size; }
        }

        public MySuperQueue()
        {
            _first = new ListNode<T>(default(T));
            _last = _first;
            size = 0;
        }

        public T FirstElement()
        {
            if (Empty())
                Console.WriteLine("Queue is empty");
            return _first.Data;
        }

        public T LastElement()
        {
            if (Empty())
                Console.WriteLine("Queue is empty");
            return _last.Data;
        }

        private bool Empty()
        {
            return (size == 0) || (_first == null);
        }

        public void Enqueu(T item)
        {
            ListNode<T> newItem = new ListNode<T>(item);

            if (Empty())
                _first = newItem;

            _last.Next = newItem;
            _last = newItem;

            size++;
        }

        public void Dequeu()
        {
            if (Empty())
                throw new NullReferenceException();
            _first = _first.Next ?? _last;
            size--;
        }
    }
}
