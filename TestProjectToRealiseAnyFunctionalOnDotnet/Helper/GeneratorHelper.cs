using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Helper
{
    class GeneratorHelper
    {
		public static IEnumerable<int> GenerateSequenceOfNumber(int max) {
			int i = 0;
			var random = new Random();

			while ( i < max )
			{
				yield return random.Next(0, max);
				i++;
			}
		}
	}
}