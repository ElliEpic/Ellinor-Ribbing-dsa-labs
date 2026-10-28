using System;

namespace DSA.Lab02
{
    public sealed class ArrayStack<T>
    {
        private readonly T[] _items;
        private int _count;

        public ArrayStack(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            _items = new T[capacity];
        }

        public int Count => _count;
        public int Capacity => _items.Length;

        public void Push(T item) 
        {
            if(_count == _items.Length) 
            {
                throw new InvalidOperationException("Stack was full!!!!!!!!!!");
            }

            _items[_count] = item; 
            _count++;
            // TODO: place the item at the logical top and update the state.
            
        }

        public T Peek()
        {
           if(_count == 0)
            {
                throw new InvalidOperationException("It's EMPTY");
            }

        return _items[_count-1];
            // TODO: return the logical top without removing it.
        }

        public T Pop()
        { 
            if(_count == 0)
            {
                throw new InvalidOperationException("It's EMPTY");
            }
        _count--; // Same as: _count = count - 1
        T item = _items[_count];
        _items[_count] = default;
        return item;
            // TODO: remove and return the logical top.

        }
    }
}
