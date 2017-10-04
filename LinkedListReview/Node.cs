using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReview
{
	class Node
	{
		public Node previous, next;
		public string value;

		public Node(Node p, Node n, string val)
		{
			previous = p;
			next = n;
			value = val;
		}
	}
}
