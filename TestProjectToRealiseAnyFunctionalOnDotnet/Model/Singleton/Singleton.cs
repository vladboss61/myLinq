using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model.Singleton 
{
	public class Singleton<T>
	{		
		private static Singleton<T> _singltone = null;

		private Singleton(T arg) 
		{
			TestSingletonField = arg;
		}

		private Singleton() : this(default(T)) {}

		static Singleton() {}

		public T TestSingletonField { get; set; }

		public static Singleton<T> Instance
		{	
			get 
			{
				_singltone = _singltone ?? new Singleton<T>();
				return _singltone;
			}
		}

		public static implicit operator Singleton<T>(T arg) 
		{
			if ( _singltone is null )
				_singltone = new Singleton<T>(arg);

			_singltone.TestSingletonField = arg;
			return _singltone;
		}
	}
}
