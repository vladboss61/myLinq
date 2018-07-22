using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model.Observer
{
	public class Subject : ISubject 
	{
		public enum myEnum { One = 0, Two = 1 }

		public class Simulator : IEnumerable {
			string [] moves = {"5","3","1","6","7"};

			public IEnumerator GetEnumerator() {
								
				foreach ( string element in moves )
					yield return element;
			}
		}

		public string SubjectState { get; set; }

		public List<IObservable> Observers { get; private set; }

		private Simulator simulator;

		private const int speed = 2000;

		public Subject() 
		{
			Observers = new List<IObservable>();
			simulator = new Simulator();
		}

		public void AddObserver(IObservable observer) 
		{
			Observers.Add(observer);
		}

		public void RemoveObserver(IObservable observer) 
		{
			Observers.Remove(observer);
		}

		public void NotifyObservers(string s) 
		{
			foreach ( var observer in Observers )
			{
				observer.Update(s);
			}
		}

		public void Go() 
		{
			new Thread(new ThreadStart(Run)).Start();
		}

		void Run() 
		{
			foreach ( string s in simulator )
			{
				Console.WriteLine("Subject: " + s);
				SubjectState = s;
				NotifyObservers(s);
				Thread.Sleep(speed); // milliseconds
			}
		}
	}
}
