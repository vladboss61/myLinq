using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Algorithm
{
	public class Tree<T> 
	{
		public Node<T> Root { get; set; }
		public String ResultDown { get; set; }

		private void DownRecurse(Node<T> root) 
		{
			if ( root == null )
			{
				return;
			}

			ResultDown += root.Value + " ";
			DownRecurse(root.Left);
			DownRecurse(root.Right);
		}

		public void Down() 
		{
			DownRecurse(Root);
		}
	}
}