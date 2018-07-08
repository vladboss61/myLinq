using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
    public class Insert : Assort<int>
    {
		public Insert(IEnumerable<int> array) 
		{
			base.Array = array.ToArray();
		}

		public override void Sort() {
			//Realization
		}
    }
}
