using System;
namespace Generics_PrintArray_FindMaximum
{
	public class GenericPrintArray
	{
		public static void ToPrint<T>(T[] array)
		{
			Console.WriteLine("Displaying values:");
			foreach(T element in array)
			{
				Console.Write(element + " ");
			}
		}
	}
}

