using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using TestProjectToRealiseAnyFunctionalOnDotnet.Algorithm;
using TestProjectToRealiseAnyFunctionalOnDotnet.Helper;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model.Observer;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model.Singleton;
using static TestProjectToRealiseAnyFunctionalOnDotnet.Model.Observer.Subject;

namespace TestProjectToRealiseAnyFunctionalOnDotnet
{
	static class Program
    {
		public static void Main() {

			var my = new myEnum();
			my = myEnum.Two;			
			Console.WriteLine(Marshal.SizeOf(Singleton<string>.Instance));			
			Console.WriteLine("T" + myEnum.Two);
			Console.ReadLine();
		}
	}
}