using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectToRealiseAnyFunctionalOnDotnet.Model
{
    interface ISortFactory
    {
		ISortable CreateSort(IEnumerable<int> sequence);
    }
}
