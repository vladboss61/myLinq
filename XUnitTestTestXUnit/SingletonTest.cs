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
			var actual = Singleton<int>.Instance;
			Assert.Same(Singleton<int>.Instance, actual);
		}

		[Fact]
		public void The_Same_Singletone_Fields_Should_Return_True() 
		{
			var actual = Singleton<int>.Instance;
			actual.TestSingletonField = 50;

			Assert.Equal(Singleton<int>.Instance
									   .TestSingletonField, 
						actual.TestSingletonField);
		}
	}
}
