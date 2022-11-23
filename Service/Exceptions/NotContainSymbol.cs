using System;
namespace Service.Exceptions
{
	public class NotContainSymbol : Exception
	{
		public NotContainSymbol(string message) : base(message)
		{
		}
	}
}

