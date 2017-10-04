using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReview
{
	class Node
	{
		Node previous, next;
		string value;

		public Node(Node p, Node n, string val)
		{
			previous = p;
			next = n;
			value = val;
		}
	}
}
