using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    public class List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int count;

        public int Count { get; set; }

        public void Add(T Info)
        {
            Node<T> clan = new Node<T>(Info);


            if (head == null)
            {
                head = clan;
                tail = clan;
                tail.Next = head;
            }
            else
            {
                tail.Next = clan;
                tail = clan;
                tail.Next = head;
            }
            count++;
        }

        public void InsertAt(int index, T value)
        {
            Node<T> clan = new Node<T>(value);

            if (index == 0)
            {
                clan.Next = head;
                head = clan;
                tail.Next = head;
            }
            else if (index == count)
            {
                tail.Next = clan;
                tail = clan;
                tail.Next = head;
            }
            else
            {
                Node<T> current = head;

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                clan.Next = current.Next;
                current.Next = clan;
            }

            count++;
        }

        public override string ToString()
        {
            if (head == null)
                return "[]";

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            Node<T> current = head;

            do
            {
                sb.Append(current.Value);
                if (current.Next != head)
                    sb.Append(", ");
                current = current.Next;
            } while (current != head);

            sb.Append("]");
            return sb.ToString();
        }
    }
}
