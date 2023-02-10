using Generics_PrintArray_FindMaximum;

namespace Generics_PrintArrayFindMaximum
    {
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics programs");

           int[] intarray = { 1, 2, 3, 6, 7 };
            double[] doublearray = { 2.23, 12.45, 23.43, 65.23 };
            char[] chararray = { 'a', 'g', 'u', 'p' };
            int a = 10, b = 20, c = 30;
            float x = 2.3f, y = 1.3f, z = 4.2f;

            Console.WriteLine("Please choose a Program from below option:");
            Console.WriteLine("1:Print Array \n2:Print Array usung Generic Method \n3:Generic Class Concept" +
                "\n4.Find Maximum");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
            PrintArray.ToPrint(intarray);
            PrintArray.ToPrint(doublearray);
            PrintArray.ToPrint(chararray);
                    break;
                case 2:
                    GenericPrintArray.ToPrint<int>(intarray);
                    GenericPrintArray.ToPrint<double>(doublearray);
                    GenericPrintArray.ToPrint<char>(chararray);
                    break;
                case 3:
                    GenericClassConcept<int> intObject = new GenericClassConcept<int>(intarray);
                    intObject.ToPrint();
                    GenericClassConcept<double> doubleObject = new GenericClassConcept<double>(doublearray);
                    doubleObject.ToPrint();
                    GenericClassConcept<char> charObject = new GenericClassConcept<char>(chararray);
                    charObject.ToPrint();
                    break;
                case 4:
                    FindMaximum.FindMaxValue(a, b, c);
                    FindMaximum.FindMaxValue(x,y,z);
                    break;
            Console.ReadLine();
           
        }
        }
    }
    }

