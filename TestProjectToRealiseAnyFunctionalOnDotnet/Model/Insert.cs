using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestProjectToRealiseAnyFunctionalOnDotnet.Helper;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
    public class Insert : Assort<int>
    {
		public Insert(IEnumerable<int> array) 
		{
			base.Array = array.ToArray();
		}
		public  int[] GetArray() {
			return Array;
		}

		public override void Sort() 
		{		
			for ( int i = 0; i < Array.Length; i++)
			{
				for ( int j = i; j > 0 && Array[j - 1] > Array[j]; j-- )
				{
					AlgorithmHelper.Swap(ref Array[j], ref Array[j - 1]);
				}
			}
		}
    }
}