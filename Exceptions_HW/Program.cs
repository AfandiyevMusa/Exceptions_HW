


using System.Text.RegularExpressions;
using Exceptions_HW.Controller;

#region Task_1

#endregion

#region Task_2
////HomeTask
//LibraryControlller.GetAll();

#region Exceptions
//int[]? arr = new int[2];
//arr[0] = 5;

//// 1
//try
//{
//    if (arr[5] == null)
//    {
//        throw new Exception();
//    }
//    else
//    {
//        Console.WriteLine(arr[5]);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//// 2
//try
//{
//    if (arr[5] == null)
//    {
//        throw new Exception();
//    }
//    else
//    {
//        Console.WriteLine(arr[5]);
//    }
//}
//catch (Exception)
//{
//    Console.WriteLine("Please, enter correct number");
//}

//// 3
//try
//{
//    if (arr[5] == null)
//    {
//        throw new Exception();
//    }
//    else
//    {
//        Console.WriteLine(arr[5]);
//    }
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//// 4
//bool isParse = true;

//try
//{
//    int index = int.Parse(Console.ReadLine());
//    int[] arr = new int[2];
//    arr[0] = 5;
//    isParse = true;
//    Console.WriteLine(arr[index]);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    isParse = false;
//}
//finally
//{
//    if (isParse)
//    {
//        Console.WriteLine("HelloWorld");
//    }
//    else
//    {
//        Console.WriteLine("You can't login");
//    }
//}

//// 5

//int[]? arr = new int[2];
//arr[0] = 5;
//try
//{
//    if (arr[5] == null)
//    {
//        throw new Exception("Exception!!!");
//    }
//    else
//    {
//        Console.WriteLine(arr[5]);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//// 6

//GetID(null);
//static void GetID(int? ID)
//{
//	try
//	{
//		if(ID == null)
//		{
//			throw new Exception();
//		}
//		Console.WriteLine("ID: " + ID);
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}
//}

//// 7
//AccountController account = new AccountController();
//account.RegisterAccount();

//AccountController account = new AccountController();
//account.GetID();
#endregion
#endregion

#region Task_3
//FactorialController factorialController = new();
//factorialController.CheckAndReleaseOutput();
#endregion

#region Task_4
//LoginController loginController = new LoginController();
//loginController.CheckUser();
#endregion
