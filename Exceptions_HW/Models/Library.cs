using System;
namespace Exceptions_HW.Models
{
	public class Library
	{
		public int ID { get; set; }
		public string? Name { get; set; }
		public List<Book>? Books { get; set; }
	}
}

