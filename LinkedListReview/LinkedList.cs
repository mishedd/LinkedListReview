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
            Node thisnode = head;
            head.next = thisnode;
            thisnode.previous = head;

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
	}
}
