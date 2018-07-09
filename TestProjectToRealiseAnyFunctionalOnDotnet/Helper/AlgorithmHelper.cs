using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Helper
{
	public static class AlgorithmHelper 
	{
		public static void Swap<T>(ref T left, ref T right) 
		{
			T temp = left;
			left = right;
			right = temp;
		}

		public static int BSearshReturnPosition<Template>(IList<Template> sequence, Template findValue) 
			where Template : IComparable
		{			
			var low = 0;
			var hight = sequence.Count - 1;

			while (low <= hight)
			{
				int mid = low + (hight - low) / 2;
				if ( sequence[mid].CompareTo(findValue).Equals(0))
					return mid;

				if (sequence[mid].CompareTo(findValue).Equals(1))
					hight = mid;

				else
					low = mid;
			}
			return -1;
		}

		public static bool LineSearch<Template>(IList<Template> sequence,Template value) 
		{
			foreach ( var item in sequence)
			{
				if ( value.Equals(item) )
					return true;
			}
			return false;
		}
	}
}
