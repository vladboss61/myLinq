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



			var tree = new Tree<int>();
			var root = new Node<int>(1);

			root.left = new Node<int>(2);
			root.right = new Node<int>(3);
			root.left.left = new Node<int>(5);
			root.left.right = new Node<int>(20);
			root.right.left = new Node<int>(50);
			root.right.right = new Node<int>(60);
			tree.Root = root;

			tree.Down();
			Console.WriteLine(tree.ResultDown);
			

			//var factory = new InsertFactory();
			//Console.WriteLine();

			//var first = new int[] { 0, 2 };
			//var second = new int[] { 0, 2, 10, 1, 30, 4, 3 };
			var goodSequence = new int[] { 1,2,3,4,5,6,7,8,9 };
			var positionOf = AlgorithmHelper.BSearshReturnPosition<int>(goodSequence, -1);
			//Console.WriteLine("Pos: " + positionOf);
			//var insersorter = (Assort<int>)factory.CreateSort(second);

			//insersorter.Sort();

			//insersorter.Array.ForEach(el => Console.WriteLine(el));					




			//first.Union(second).ForEach(el => Console.WriteLine(el));
			//Console.WriteLine();

			//first.myUnion(second).ForEach(el => Console.WriteLine(el));
			//Console.WriteLine();

			//first.Full(second).ForEach(el => Console.WriteLine(el));

			//Console.WriteLine();
			//first.myExcept(second).ForEach(el => Console.WriteLine(el));
			//second.myUnique().ForEach(el => Console.WriteLine(el));

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