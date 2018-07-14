using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model 
{
	public static class EnumerableHelper 
	{
		public static void ForEach(this IEnumerable<int> array,
			Action<int> action) 
		{
			if (action == null || array == null)
			{
				throw new ArgumentNullException();
			}

			foreach ( var item in array )
			{
				action(item);
			}
		}

		public static bool TryForAll(this IEnumerable<int> sequence,
			Func<int,bool> predicate) 
		{
			if ( sequence == null )
			{
				throw new Exception("sequence is null");
			}

			if ( predicate == null )
			{
				throw new Exception("predicate is null");
			}

			foreach ( var item in sequence )
			{
				if ( !predicate(item) )
				{
					return false;
				}
			}

			return true;
		}

		public static IEnumerable<int> mySelect(this IEnumerable<int> sequence,
			Func<int,int> func) 
		{
			foreach ( int item in sequence )
			{
				yield return func(item);
			}
		}

		public static IEnumerable<int> MyWhere(this IEnumerable<int> sequence,
				Func<int, bool> func) 
		{
			foreach ( var item in sequence )
			{
				if ( func(item) )
				{
					yield return item;
				}
			}
		}

		public static int myFindFirstOrDefault(this IEnumerable<int> sequence,
			Func<int, bool> func) 
		{
			foreach ( var item in sequence )
			{
				if ( func(item) )
				{
					return item;
				}
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

			foreach ( var item in sequence )
			{
				array[j] = item;
				j++;
			}

			return array;
		}

		public static int myMax(this IEnumerable<int> sequence) 
		{
			int max = int.MinValue;

			foreach ( int item in sequence )
			{
				if ( max < item )
				{
					max = item;
				}
			}

			return max;
		}

		public static int myMin(this IEnumerable<int> sequence) 
		{
			int min = int.MaxValue;

			foreach ( var item in sequence )
			{
				if ( min > item )
				{
					min = item;
				}
			}

			return min;
		}

		public static List<int> myToList(this IEnumerable<int> sequence) 
		{
			var list = new List<int>(sequence.Count()); // I think better definition start 
														// capacity than redistribute a memory into List

			foreach ( int item in sequence )
			{
				list.Add(item);
			}

			return list;
		}

		public static int myLast(this IEnumerable<int> sequence) 
		{
			int last = default(int);

			var iterator = sequence.GetEnumerator();

			foreach ( var item in sequence )
			{
				last = item;
			}

			return last;
		}

		public static int myFirst(this IEnumerable<int> sequence) 
		{
			//realization first;
			int first = default(int);

			foreach ( var item in sequence )
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

		public static IEnumerable<int> myUnion(this IEnumerable<int> sequence,
			IEnumerable<int> other) 
		{
			var temp = new List<int>(sequence);

			foreach ( var item in temp )
			{
				yield return item;
			}

			foreach ( var item in other )
			{
				if ( !temp.Contains(item) )
					yield return item;
			}

			//other Realization
			//foreach(var item in other){
			//  if ( !temp.Contains(item) )
			//    temp.Add(item);
			//
			//return temp;
		}

		public static IEnumerable<int> myIntersect(this IEnumerable<int> sequence,
			IEnumerable<int> other) 
		{
			ISet<int> set = new HashSet<int>(sequence);

			foreach ( var item in other )
			{
				if ( set.Remove(item) )
				{
					yield return item;
				}
			}
		}

		public static IEnumerable<int> myExcept(this IEnumerable<int> sequence,
			IEnumerable<int> other) 
		{
			ISet<int> set = new HashSet<int>(other);

			foreach ( var item in sequence )
			{
				if ( set.Add(item) )
				{
					yield return item;
				}
			}
		}

		public static IEnumerable<int> Full(this IEnumerable<int> sequence,
			IEnumerable<int> other) 
		{

			ISet<int> set = new HashSet<int>(other);

			foreach ( var item in sequence )
			{
				if ( set.Add(item) )
				{
					yield return item;
				}
			}

			set = new HashSet<int>(sequence);

			foreach ( var item in other )
			{
				if ( set.Add(item) )
				{
					yield return item;
				}
			}
		}

		public static IEnumerable<int> myUnique(this IEnumerable<int> sequence) 
		{
			ISet<int> set = new HashSet<int>();

			foreach ( var item in sequence )
			{
				if ( set.Add(item) )
				{
					yield return item;
				}
			}
		}

		public static int myAverage(this IEnumerable<int> sequence,
			Func<int,int,int> func) 
		{
			var sum = 0;

			foreach ( var value in sequence )
			{
				sum += value;
			}

			return sum / sequence.myCount();
		}

		public static IEnumerable<int> mySkip(this IEnumerable<int> sequence,
			int count) 
		{
			int temp = 0;
			foreach ( var value in sequence )
			{
				if ( temp >= count )
				{
					yield return value;
				}

				temp++;
			}
		}

		public static IEnumerable<int> myDistinct(this IEnumerable<int> sequence) 
		{
			ISet<int> set = new HashSet<int>();

			foreach ( var element in sequence )
			{
				if ( set.Add(element) )
				{
					yield return element;
				}
			}
		}

		public static bool myAny(this IEnumerable<int> sequence,
			Func<int,bool> predicate) 
		{
			foreach ( var element in sequence )
			{
				if ( !predicate(element) )
				{
					return true;
				}					
			}

			return false;
		}

		public static IEnumerable<int> myReverse(this IEnumerable<int> sequence) 
		{
			var reversedArray = new int [sequence.myCount()];
			var iterator = sequence.GetEnumerator();

			for ( int i = reversedArray.Length - 1; iterator.MoveNext(); i-- )
			{
				reversedArray[i] = iterator.Current;
			}

			foreach ( var element in reversedArray )
			{
				yield return element;
			}
		}

		public static IEnumerable<int> myAppend(this IEnumerable<int> sequence,
			int appended) 
		{
			foreach ( var value in sequence )
			{
				yield return value;
			}

			yield return appended;
		}

		public static IEnumerable<int> myPrepend(this IEnumerable<int> sequence,
			int prepended) 
		{
			yield return prepended;

			foreach ( var value in sequence )
			{
				yield return value;
			}
		}

		public static IEnumerable<int> mySkipWhile(this IEnumerable<int> sequence,
			Func<int,bool> func) 
		{
			foreach ( var value in sequence )
			{
				if ( !func(value) )
				{
					yield return value;
				}
			}

			//Other realization 
			//foreach (var value in sequence)
			//{
			//    if (func(value))
			//        continue;
			//    yield return value;
			//}
		}

		public static IEnumerable<T> mySkipWhile<T>(this IEnumerable<T>sequence, Func<T,bool> func) {
			bool flag = false;
			foreach ( var item in sequence)
			{
				if ( !flag && !func(item) )
					flag = true;
				if ( flag )
					yield return item;
			}

		}

		public static IEnumerable<int> myTake(this IEnumerable<int> sequence,
			int takeOf) 
		{
			int counter = 0;

			foreach ( var element in sequence )
			{
				if ( counter < takeOf )
				{
					yield return element;
				}

				counter++;
			}
		}

		public static IEnumerable<int> myZipToEnd(this IEnumerable<int> sequence,
			IEnumerable<int> zippedSequence) 
		{
			foreach ( var element in sequence )
			{
				yield return element;
			}

			foreach ( var zipped in zippedSequence )
			{
				yield return zipped;
			}
		}

		public static IEnumerable<int> myZipToStart(this IEnumerable<int> sequence,
			IEnumerable<int> zippedSequence) 
		{
			foreach ( var element in zippedSequence )
			{
				yield return element;
			}

			foreach ( var zipped in sequence )
			{
				yield return zipped;
			}
		}

		public static IEnumerable<int> myZipInsert(this IEnumerable<int> sequence, 
			IEnumerable<int> other,
			int offset) 
		{
			if ( offset < 0 )
			{
				throw new ArithmeticException("offset could not be less than 0");
			}

			if ( offset > sequence.Count() )
			{
				throw new ArithmeticException($"offset could not be biggest than count of sequence");
			}

			int count = 0;

			foreach ( var item in sequence)
			{
				if ( count.Equals(offset))
				{
					foreach ( var element in other)
					{
						yield return element;
					}
				}
				count++;

				yield return item;
			}
		}
		
		//public static IEnumerable<ICast> myCast<ICast, IOther>(this IEnumerable<IOther> sequence) 
		//	where IOther : ICast
		//{
		//	foreach ( var item in sequence)
		//	{
		//		yield return item;
		//	}
		//}		
	}
}