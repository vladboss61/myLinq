using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestProjectToRealiseAnyFunctionalOnDotnet.Helper;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
	public class Bubble : Assort<int> 
	{
		public Bubble(IEnumerable<int> sequence)
		{
			base.Array = sequence.ToArray();
		}

		public override void Sort() 
		{
			if ( Array == null )
				throw new NullReferenceException();

			if ( Array.Length.Equals(0) )
				throw new ArgumentNullException();

			for ( int i = 0; i < Array.Length; i++ )
			{
				for ( int j = 0; j < Array.Length - 1; j++ )
				{
					if ( Array[j] > Array[j + 1] )
						AlgorithmHelper.Swap(ref Array[j], ref Array[j + 1]);
				}
			}
		}

		public bool LineSearsh(int value) 
		{
			foreach ( var item in Array )
			{
				if ( value.Equals(item) )
					return true;
			}
			return false;
		}
	}
}