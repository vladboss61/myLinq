using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Helper
{
	public static class AlgorithmHelper {
		public static void Swap<T>(ref T left, ref T right) 
		{
			T temp = left;
			left = right;
			right = temp;
		}

	}
}
