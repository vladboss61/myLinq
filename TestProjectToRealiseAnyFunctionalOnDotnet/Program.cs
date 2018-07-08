using System;
using System.Collections.Generic;
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
