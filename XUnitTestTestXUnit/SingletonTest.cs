using System;
using System.Collections.Generic;
using System.Text;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model.Singleton;
using Xunit;

namespace XUnitTestTestXUnit
{
    public class SingletonTest
    {
		[Fact]
		public void The_Same_Singletone_Objects_Should_Return_True()	
		{
			var first = Singleton<int>.Instance;
			Assert.Same(first, Singleton<int>.Instance);
		}

		[Fact]
		public void The_Same_Singletone_Fields_Should_Return_True() 
		{
			var first = Singleton<int>.Instance;
			first.TestSingletonField = 50;

			Assert.Equal(first.TestSingletonField, 
					Singleton<int>.Instance.TestSingletonField);
		}
	}
}
