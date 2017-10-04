using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListReview
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList linkedList = new LinkedList();
			linkedList.AddLast("duck");
			linkedList.addFirst("dog");
			linkedList.AddLast("cat");
			linkedList.AddLast("bird");
			Console.WriteLine(linkedList.Get(1));
			Console.ReadLine();

		}
	}
}
