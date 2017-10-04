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
