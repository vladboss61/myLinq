using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
	public abstract class Assort<T> : ISortable {

		public Assort(T[] array)
		{
			Array = array;
		}

		public T[] Array { get; protected set; }
		public abstract void Sort();
    }
}