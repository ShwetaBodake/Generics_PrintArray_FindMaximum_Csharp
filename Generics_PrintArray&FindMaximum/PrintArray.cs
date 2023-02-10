using System;
namespace Generics_PrintArray_FindMaximum
{
	public class PrintArray
	{
		public static void ToPrint(int[] array)
		{
			foreach(int element in array)
			{
				Console.Write(element + " " );
			}
		}

		public static void ToPrint(double[] array)
		{
			foreach(double element in array)
			{
				Console.Write(element + " ");
			}
		}
		public static void ToPrint(char[] array)
		{
			foreach(char element in array)
			{
				Console.Write(element + " ");
			}
		}
	}
}

