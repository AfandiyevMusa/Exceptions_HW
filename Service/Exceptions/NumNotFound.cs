using System;
namespace Service.Exceptions
{
	public class NumNotFound : Exception
	{
		public NumNotFound(string message) : base(message)
		{
		}
	}
}

