using System;

namespace MinIntHeap
{
    public class MinIntHeap
    {
        private int _capacity = 10;
        private int _size = 0;
        private int[] _items;

        public MinIntHeap()
        {
            _items = new int[_capacity];
        }

        public int Peek()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }

            return _items[0];
        }

        public int Poll()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException();
            }

            int item = _items[0];
            _items[0] = _items[_size - 1];
            _size--;
            HeapifyDown();
            return item;
        }

        public void Add(int item)
        {
            EnsureCapacity();
            _items[_size] = item;
            _size++;
            HeapifyUp();
        }

        private int GetLeftChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 1;
        }

        private int GetRightChildIndex(int parentIndex)
        {
            return 2 * parentIndex + 2;
        }

        private int GetParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        private bool HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) < _size;
        }

        private bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) < _size;
        }

        private bool HasParent(int index)
        {
            return GetParentIndex(index) >= 0;
        }

        private int GetParent(int index)
        {
            return _items[GetParentIndex(index)];
        }

        private int GetLeftChild(int index)
        {
            return _items[GetLeftChildIndex(index)];
        }

        private int GetRightChild(int index)
        {
            return _items[GetRightChildIndex(index)];
        }

        private void Swap(int index1, int index2)
        {
            int temp = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = temp;
        }

        private void EnsureCapacity()
        {
            if (_size == _capacity)
            {
                var newArr = new int[2 * _capacity];
                Array.Copy(_items, newArr, _size - 1);
                _items = newArr;
                _capacity *= 2;
            }
        }

        private void HeapifyUp()
        {
            int index = _size - 1;
            while (HasParent(index) && GetParent(index) > _items[index])
            {
                int parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && GetRightChild(index) < GetLeftChild(index))
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (_items[index] < _items[smallerChildIndex])
                {
                    break;
                }

                Swap(index, smallerChildIndex);
                index = smallerChildIndex;
            }
        }
    }
}
