using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
    public class BubbleFactory : ISortFactory
    {
		public ISortable CreateSort(IEnumerable<int> sequence) 
		{	
			return new Bubble(sequence);
		}		
    }
}