using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class NextList<T>
    {
        public NextList(T data)
        {
            Data = data;
        }
        public NextList()
        {
            Data = default;
            Next = default;
        }
        public T Data { get; set; }
        public NextList<T> Next { get; set; }
    }
    public class CircularLinkedList<T> : IEnumerable<T>  // кольцевой связный список
    {
        NextList<T> head; // головной/первый элемент
        NextList<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке
        public T ById(int i)
        {
            if(i<0 || i > count)
            {
                throw new IndexOutOfRangeException();
            }
            CircularLinkedList<T> m = this;
            while (i != 0)
            {
                m.head = m.head.Next;
                i--;
            }
            return m.head.Data;
        }
        
        public bool Find(T search)
        {
            bool ret = false;
            foreach (T some in this)
            {
                if (some.Equals(search))
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
        public int GetId(T search)
        {
            int ret = 0;
            foreach (T some in this)
            {
                if (some.Equals(search))
                {

                    break;
                }
                ret += 1;
            }
            if (ret == count)
                return -1;
            else
                return ret;
        }
        // добавление элемента
        public void Add(T data)
        {
            NextList<T> node = new NextList<T>(data);
            // если список пуст
            if (head == null)
            {
                head = node;
                tail = node;
                tail.Next = head;
            }
            else
            {
                node.Next = head;
                tail.Next = node;
                tail = node;
            }
            count++;
        }
        public bool Remove(T data)
        {
            NextList<T> current = head;
            NextList<T> previous = null;

            if (IsEmpty) return false;

            do
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если узел последний,
                        // изменяем переменную tail
                        if (current == tail)
                            tail = previous;
                    }
                    else // если удаляется первый элемент
                    {

                        // если в списке всего один элемент
                        if (count == 1)
                        {
                            head = tail = null;
                        }
                        else
                        {
                            head = current.Next;
                            tail.Next = current.Next;
                        }
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            } while (current != head);

            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            NextList<T> current = head;
            if (current == null) return false;
            do
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            while (current != head);
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            NextList<T> current = head;
            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
            while (current != head);
        }

    }
}
