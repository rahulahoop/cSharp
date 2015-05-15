using System;
namespace linkedList
{
	public class node
	{
		private object value;
		public node nextNode;

		public node()
		{
			value = null;
		}

		public node(object value)
		{
			this.value = value;
			this.nextNode = null;
		}

		public object getValue()
		{
			return this.value;
		}

		public void setNext(node next)
		{
			this.nextNode = next;
		}

		public node getNext()
		{
			return nextNode;
		}
		
	}

	class linkedList
	{
		private node head;
		private int size;
		public linkedList()
		{
			head = new node(null);
			size = 0;
		}

		public int getSize()
		{
			return this.size;
		}

		public void insert(object value)
		{
			node Node = new node(value);
			node curNode = this.head;

			while ( curNode.getNext() != null) {
				curNode = curNode.getNext();
			}

			curNode.setNext(Node);
			this.size++;
		}

		public void toString()
		{
			node curNode = this.head;
			curNode = curNode.getNext ();

			while ( curNode.getNext() != null) {
				Console.Write(curNode.getValue() + " , ");
				curNode = curNode.getNext();
			}

		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			linkedList list = new linkedList ();
			int[] arr = {3 , 4 , 13, 44, 19, 22 };
			foreach (int x in arr){
				list.insert(x);
			}

			int s = list.getSize ();
			Console.Write (" Size : ");
			Console.WriteLine (s);
			list.toString();
		}
	}
}
