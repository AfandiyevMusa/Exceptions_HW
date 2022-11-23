using System;
using Service.Exceptions;
using Service.Services;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class FactorialService : IFactorialService
	{
		public void CheckEnteredInput(int num)
        {
			int sum = 1;
			bool? isParse = true;
			try
			{
				if(num < 0)
				{
					isParse = false;
					throw new NotTrueForFactorialExceptions("The number that is entered, should be positive!");
					
				}
				else
				{
					isParse = true;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			finally
			{
				if (isParse == true)
				{
					for (int i = 1; i <= num; i++)
					{
						sum *= i;
					}
					Console.WriteLine(sum);
				}
				else if(isParse == false)
				{
					Console.WriteLine("Try again!");
				}
            }
        }
    }
}