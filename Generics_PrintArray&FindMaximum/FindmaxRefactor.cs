using System;
namespace Generics_PrintArray_FindMaximum
{
	public class FindmaxRefactor<T> where T : IComparable
	{
        public T first, second, third;
        public FindmaxRefactor(T first,T second ,T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T  FindMaxValue(T first, T second, T third)
        {
            //1,-1,0
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

        public T TestMaximum()
        {
            T output = FindmaxRefactor<T>.FindMaxValue(this.first, this.second, this.third);
            return output;
        }
    }
}

