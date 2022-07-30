

using System.Collections;
using System.Collections.Generic;

namespace AlgosCore.StructData
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count { get { return count; } }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if(head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }

        public bool Remoove(T data)
        {
            Node<T> current = head;
            Node<T> previos = null;

            while(current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previos != null)
                    {
                        previos.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previos;
                        }
                    }
                    else
                    { 
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previos = current;
                current = current.Next;
            }
            return false;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            { 
                if(current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            count++;
        }


        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }


        public bool IsEmpty() 
        {
            return count == 0;
        }


        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
