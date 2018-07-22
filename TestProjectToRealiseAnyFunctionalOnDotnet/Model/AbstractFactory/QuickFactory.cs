using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model.AbstractFactory 
{
	public class QuickFactory : ISortFactory 
	{
		public ISortable CreateSort(IEnumerable<int> sequence) 
		{
			return new Quick(sequence);
		}
	}
}