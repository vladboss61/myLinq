using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CollectionArray = System.Array;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
	public class Quick : Assort<int> 
	{			
		public Quick(IEnumerable<int> array)
		{	
			base.Array = array.ToArray();
		}

		public override void Sort() 	
		{
			//realization
		}
		public void RandomizeSequence() {
			var random = new Random();
			for ( int i = 0; i < Array.Length; i++ )
			{
				Array[i] = random.Next();
			}
		}
	}
}