using System;
using System.Collections.Generic;
using System.Linq;
using TestProjectToRealiseAnyFunctionalOnDotnet.Algorithm;
using TestProjectToRealiseAnyFunctionalOnDotnet.Helper;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model.Observer;

namespace TestProjectToRealiseAnyFunctionalOnDotnet
{
	static class Program
    {
       public static void Main()
        {
			var v = new Subject.Simulator();
			
			Subject subject = new Subject();
			Observer observer = new Observer(subject,"Center","\t\t");
			
			subject.Go();

			Observer observer2 = new Observer(subject,"Right","\t\t\t\t");

			subject.Go();
			// Wait for user
			Console.Read();
		}
	}
}