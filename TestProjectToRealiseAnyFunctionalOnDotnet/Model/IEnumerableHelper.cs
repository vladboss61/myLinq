using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
   public static class IEnumerableHelper
   {
		public static void ForEach(this IEnumerable<int> array, Action<int> action) 
		{
			if ( ReferenceEquals(action, null) 
				|| ReferenceEquals(array, null))
				throw new ArgumentNullException();

			foreach (var item in array)
			{
				action(item);
			}
		}

		public static bool TryForAll(this IEnumerable<int> sequence, Func<int, bool>  predicate) 
		{
			if ( sequence == null )
				throw new Exception("sequence is null");

			if ( predicate == null )
				throw new Exception("predicate is null");

			foreach ( var item in sequence)
			{
				if ( !predicate(item) )
					return false;
			}

			return true;
		}

		public static IEnumerable<int> mySelect(this IEnumerable<int> sequence, Func<int, int> func) {
			foreach ( var item in sequence)
			{
				yield return func(item);
			}
		}

		public static IEnumerable<int> MyWhere(this IEnumerable<int> sequence, Func<int, bool> func) 
		{
			foreach ( var item in sequence )
			{
				if ( func(item) )
					yield return item;
			}
		}

		public static int myFindFirstOrDefault(this IEnumerable<int> sequence, Func<int, bool> func) 
		{
			foreach (var item in sequence)
			{
				if ( func(item) )
					return item;
			}
			return default(int);
		}

		public static int myCount(this IEnumerable<int> sequence) 
		{
			int count = 0;
			foreach ( var item in sequence )
			{
				count++;
			}
			return count;
		}

		public static int[] myToArray(this IEnumerable<int> sequence) 
		{
			int[] array = new int[sequence.myCount()];
			var enumerator = sequence.GetEnumerator();

			//realization first
			int i = 0;
			while ( enumerator.MoveNext() )
			{
				array[i] = enumerator.Current;
				i++;
			}

			enumerator.Reset(); // cuz i use one enumerator for first and second realization

			//realization seconde
			for ( int index = 0; enumerator.MoveNext(); index++ )
			{
				array[index] = enumerator.Current;
			}

			//realization third ;
			int j = 0;
			foreach ( var item in sequence)
			{
				array[j] = item;
				i++;
			}

			return array;
		}

		public static int myMax(this IEnumerable<int> sequence) 
		{
			int max = int.MinValue;
			foreach ( var item in sequence)
			{
				if ( max < item )
					max = item;
			}
			return max;
		}

		public static int myMin(this IEnumerable<int> sequence) 
		{
			int min = int.MaxValue;
			foreach ( var item in sequence )
			{
				if ( min > item )
					min = item;
			}
			return min;
		}

		public static List<int> myToList(this IEnumerable<int> sequence) 
		{
			var list = new List<int>();
			foreach ( var item in sequence)
			{
				list.Add(item);
			}
			return list;
		}

		public static int myLast(this IEnumerable<int> sequence) {
			int last = default(int);
			foreach ( var item in sequence)
			{
				last = item;
			}
			return last;
		}

		public static int myFirst(this IEnumerable<int> sequence) {

			//realization first;
			int first = default(int);
			foreach ( var item in sequence)
			{
				first = item;
				break;
			}

			//realization second
			var iterator = sequence.GetEnumerator();
			if ( iterator.MoveNext() )
			{
				first = iterator.Current;
			}
			return first;
		}
   }
}
