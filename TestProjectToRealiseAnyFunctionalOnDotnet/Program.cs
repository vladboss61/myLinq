using System;
using System.Collections.Generic;
using System.Linq;
using TestProjectToRealiseAnyFunctionalOnDotnet.Helper;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model;

namespace TestProjectToRealiseAnyFunctionalOnDotnet
{
	static class Program
    {
       public static void Main()
        {
			var factory = new BubbleFactory();
			Console.WriteLine();

			var first = new int[] { 0, 2 };
			var second = new int[] { 0, 1, 3, 4, 5 };
			first.Union(second).ForEach(el => Console.WriteLine(el));
			Console.WriteLine();
			first.myUnion(second).ForEach(el => Console.WriteLine(el));
			Console.WriteLine();
			first.Except(second).ForEach(el => Console.WriteLine(el));
			Console.WriteLine();
			first.myExcept(second).ForEach(el => Console.WriteLine(el));


			//var arr = factory.CreateSort(GeneratorHelper.GenerateSequenceOfNumber(10));
			//arr.Sort();

			//var queue = new Queue<int>(GeneratorHelper.GenerateSequenceOfNumber(10));			

			//queue.ForEach(el => Console.WriteLine(el));
			//queue.Peek();

			//Console.WriteLine();
			//queue.ForEach(el => Console.WriteLine(el));
			//queue.Dequeue();

			//Console.WriteLine();
			//queue.ForEach(el => Console.WriteLine(el));

			//queue.Dequeue();
			//Console.WriteLine();			
			//queue.ForEach(el => Console.WriteLine(el));
			Console.ReadLine();
		}
	}
		
	


	

}
