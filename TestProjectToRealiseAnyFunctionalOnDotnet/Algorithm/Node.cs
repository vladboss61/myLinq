using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Algorithm
{
    public class Node<T>
    {
		public Node<T> left { get; set; }
		public Node<T> right { get; set; }
		public T Value { get; set; }

		public Node(T value) 
		{
			Value = value;
			left = null;
			right = null;
		}
    }
}
