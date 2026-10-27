using System;

namespace DSA.Lab02
{
    public sealed class RingQueue<T>
    {
        private readonly T[] _items;
        private int _head;
        private int _tail;
        private int _count;

        public RingQueue(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            _items = new T[capacity];
        }

        public int Count => _count;
        public int Capacity => _items.Length;

        public void Enqueue(T item)
        {
            // TODO: write at tail, advance tail with wrap-around, update count.
            if(_count == _items.Length)
            {
                throw new InvalidOperationException("Queue Is full");
            }
            

            throw new NotImplementedException();
        }

        public T Peek()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Queue Is Empty");
            }
            // TODO: return the item at head without removing it.
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            if(_count == 0)
            {
                throw new InvalidOperationException("Queue Is Empty");
            }
            // TODO: read/clear at head, advance head with wrap-around, update count.
            return _items[_count];
        }
    }
}
