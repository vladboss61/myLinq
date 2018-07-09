using System;
using System.Collections.Generic;
using System.Linq;
using TestProjectToRealiseAnyFunctionalOnDotnet.Algorithm;
using TestProjectToRealiseAnyFunctionalOnDotnet.Helper;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model;

namespace TestProjectToRealiseAnyFunctionalOnDotnet
{
	static class Program
    {
       public static void Main()
        {
			new[] { 1,2,3 }				
				.myZipToStart(new[] { 60,60 })
				.myZipToEnd(new[] { 90, 90 })
				.myZipInsert(new[] { 20,30 }, 1)
				.ForEach(Console.WriteLine);
		}
	}
}