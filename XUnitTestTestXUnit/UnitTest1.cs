using System;
using Xunit.Extensions;
using Xunit;
using Moq;
using TestProjectToRealiseAnyFunctionalOnDotnet;
using TestProjectToRealiseAnyFunctionalOnDotnet.Model;
using System.Collections.Generic;

namespace XUnitTestTestXUnit
{
	public class TestProjectToRealiseAnyFunctionalOnDotnetTest 
	{

		[Theory]
		[MemberData(nameof(GetTestData_myFirst))]
		public static void Test_myFirst(int actual, int[] expected) {

			var forTestingConstructor = new int[] { 1,2,3 };
			var moq = new Mock<Insert>(MockBehavior.Default, forTestingConstructor);
			
			moq.SetupSet(el => el.Array = new[] { 3,2,1 });

			var arr = moq.Object;
			
			Assert.Equal(expected.myLast(), actual);
		}

		public static IEnumerable<object[]> GetTestData_myFirst() {
			yield return new object[] { 11, new int[] { 11,20,-5,1,21,4,12,11 } };
			yield return new object[] { 12, new int[] { 12,11,-5,-1,1,4,12,11 } };
		}

		[Theory]
		[MemberData(nameof(GetTestData_myLast))]
		public static void Test_myLast(int actual, int[] expected) {
			Assert.Equal(expected.myLast(), actual);
		}

		public static IEnumerable<object[]> GetTestData_myLast() {
			yield return new object[] { 25, new int[] { 11,20,-5,1,21,4,12,25 } };
			yield return new object[] { 26, new int[] { 12,11,-5,-1,1,4,12,26 } };
		}

		[Theory]
		[MemberData(nameof(GetTestData_mySelect))]
		public static void Test_mySelect(int[] actual, int[] expected) {
			Assert.Equal(actual.mySelect(el => el * el), expected);
		}

		public static IEnumerable<object[]> GetTestData_mySelect() {
			yield return new object[] { new[] { 1,2,3,4 },new[] { 1,4,9,16 } };
			yield return new object[] { new[] { 2,1,1,4 },new[] { 4,1,1,16 } };
		}
		
		[Theory]
		[MemberData(nameof(GetTestData_myMax))]
		public static void Test_myMax(int[] actual, int expected) {
			Assert.Equal(expected, actual.myMax());
		}

		public static IEnumerable<object[]> GetTestData_myMax() {
			yield return new object[] { new int[] { 1,2,3,11,10 }, 11 };
		}

		[Fact]
		public static void Test_Should_Throw_ArgumentNullException_in_ForEach() {
			Assert.Throws<ArgumentNullException>(
				() => new[] { 1, 2, 3 }.ForEach(null)
			);
		}
	}
}