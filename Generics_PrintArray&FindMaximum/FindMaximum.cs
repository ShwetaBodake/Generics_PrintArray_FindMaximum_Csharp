using System;
namespace Generics_PrintArray_FindMaximum
{
	public class FindMaximum
	{
		public static void FindMaxValue(int first,int second,int third)
		{
			//1,-1,0
			if(first.CompareTo(second)>=0 && first.CompareTo(third)>=0)
			{
				Console.WriteLine("{0} is greater", first);
			}
			else if(second.CompareTo(first)>=0 && second.CompareTo(third)>=0)
				{
				Console.WriteLine("{0} is greater", second);
			}
			else
			{
				Console.WriteLine("{0} is greater ", third);
			}
		}

		public static void FindMaxValue(float first,float second,float third)
		{
			if (first.CompareTo(second) >= 0 && first.CompareTo(third)>=0)
			{
				Console.WriteLine("{0} is greater",first);
			}
			else if(second.CompareTo(first)>=0 && second.CompareTo(third)>=0)
			{
				Console.WriteLine("{0} is greater ",second);
			}
			else
			{
				Console.WriteLine("{0} is greater", third);
			}
		}

        public static string FindMaxValue(string first, string second, string third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
				return first;
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
				return second;
            }
            else
            {
				return third;
            }
        }
    }
}

