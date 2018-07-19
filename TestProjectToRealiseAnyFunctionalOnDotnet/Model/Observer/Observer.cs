using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model.Observer
{
	public class Observer : IObservable 
	{
		string name;

		ISubject subject;

		string state;

		string gap;

		public Observer(ISubject subject, string name, string gap) 
		{
			this.subject = subject;
			this.name = name;
			this.gap = gap;
			subject.AddObserver(this);
		}

		public void Update(string subjectState) {
			state = subjectState;
			Console.WriteLine(gap + name + ": " + state);
		}
	}
}
