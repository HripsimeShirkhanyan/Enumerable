using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerable
{
    partial class ListNode<T> : IEnumerable<T>
    {
        public ListNode(T item)
        {
            value = item;
        }
        public T value;
        public ListNode<T> next;
        private ListNode<T> currentNode;

        public void Add(T item)
        {
            if(currentNode == null)
            {
                next = new ListNode<T>(item);
                currentNode = next; 
                //currentNode = new ListNode(item);
            }

            else
            {
                currentNode.next = new ListNode<T>(item);
                currentNode = currentNode.next;
            }
        }

        public override string ToString()
        {
            return value.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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
