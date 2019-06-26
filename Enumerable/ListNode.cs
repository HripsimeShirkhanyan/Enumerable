using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerable
{
    class ListNode<T> : IEnumerable<T>
    {
        public ListNode(T item)
        {
            value = item;
        }

        public T value;
        public ListNode<T> next;
        private ListNode<T> _cuurentNode;

        public void Add(T item)
        {
            if (_cuurentNode == null)
            {
                next = new ListNode<T>(item);
                _cuurentNode = next;
            }
            else
            {
                _cuurentNode.next = new ListNode<T>(item);
                _cuurentNode = _cuurentNode.next;
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator : IEnumerator<T>
        {
            public Enumerator(ListNode<T> root)
            {
                _node = root;
            }

            private ListNode<T> _node;

            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (_node == null)
                    return false;

                Current = _node.value;
                _node = _node.next;
                return true;
            }

            public void Reset()
            {
                _node = null;
            }

            public void Dispose()
            {
                Reset();
            }
        }
    }
}
