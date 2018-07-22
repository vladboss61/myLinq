using System;

namespace MEF
{
	using Newtonsoft.Json;
	using Microsoft.Extensions.Configuration.Json;
	using Microsoft.Extensions.FileSystemGlobbing.Internal;

	public class Class1 {
		private IPattern pattern = new Microsoft
										.Extensions
										.FileSystemGlobbing
										.Internal
										.Patterns
										.PatternBuilder(StringComparison.CurrentCulture)
										.Build("123");
		public void M() 
		{
			
		}
	}
}