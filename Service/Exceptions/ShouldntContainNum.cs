using System;
namespace Service.Exceptions
{
	public class ShouldntContainNum : Exception
	{
		public ShouldntContainNum(string message) : base(message)
		{
		}
	}
}

