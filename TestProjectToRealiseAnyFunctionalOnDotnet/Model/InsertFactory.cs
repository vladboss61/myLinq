using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
    class InsertFactory : ISortFactory
    {
		public ISortable CreateSort(IEnumerable<int> sequence) 
		{
			return new Insert(sequence);
		}
    }
}
