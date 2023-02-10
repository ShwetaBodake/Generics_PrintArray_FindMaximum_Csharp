using System;
namespace Generics_PrintArray_FindMaximum
{
	public class GenericClassConcept<T>
	{
		public T[] array;
		public GenericClassConcept(T[] array)
		{
			this.array = array;
		}

		public void ToPrint()
		{
			foreach(T element in array)
			{
				Console.Write(element + " ");
			}
		}
    }
}

