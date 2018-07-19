using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model.Observer
{
    public interface ISubject
    {
		void AddObserver(IObservable observer);

		void RemoveObserver(IObservable observer);

		void NotifyObservers(string s);
	}
}
