using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReview
{
	class LinkedList
	{
		Node head;

		public LinkedList()
		{
			head = null;
		}

        public void addFirst(String value)
        {
            Node temp = head;
            head.next = temp;
            temp.previous = head;

        }

		public void AddLast(string value)
		{
			Node temp = head;
			while (temp.next != null)
			{
				temp = temp.next;
			}
			temp.next = new Node(temp, null, value);
		}

        public string getFirst()
        {
            return head.value;
        }

		public Node GetNode(int index)
		{
			Node temp = head;
			for (int i = 0; i < index; i++)
			{
				try
				{
					temp = temp.next;
				} catch
				{
					return null;
				}
			}
			return temp;
		}

		public override string ToString()
		{
			string output = head != null ? "{ " + head.value : "{ ";
			Node current = head != null ? head.next : null;

			while (current != null)
			{
				output += ", " + current.value;
				current = current.next;
			}

			return output + " }";
		}

		public string Get(int index)
		{
			return GetNode(index).value;
		}
        public string getLast()
        {
            Node temp = head;
            while (true)
            {
                if (temp.next != null)
                {
                    temp = temp.next;
                }
                else
                {
                    return temp.value;
                }
            }
        }
	}
}
