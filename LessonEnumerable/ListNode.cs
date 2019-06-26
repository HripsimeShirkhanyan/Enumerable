using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace LessonEnumerable
{
    class ListNode<T> : IEnumerable<T>
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
                node = root;
            }

            private ListNode<T> node;
            public T Current { get; private set; }

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                if (node == null)
                    return false;

                Current = node.value;
                node = node.next;
                return true;
            }

            public void Reset()
            {
                node = null;
            }
            public void Dispose()
            {
                Reset();
            }
        }
    }
}
