using Generics_PrintArray_FindMaximum;

namespace Generics_PrintArrayFindMaximum
    {
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics programs");
           
            int[] array = { 1, 9, 3, 5 };
            MaximumNumber<int> generic = new MaximumNumber<int>(array);
           Console.WriteLine( generic.MaxValue());
            Console.ReadLine();





            /*  int[] intarray = { 1, 2, 3, 6, 7 };
               double[] doublearray = { 2.23, 12.45, 23.43, 65.23 };
               char[] chararray = { 'a', 'g', 'u', 'p' };
               int a = 10, b = 20, c = 30;
               float x = 2.3f, y = 1.3f, z = 4.2f;
               string str1 = "abc", str2 = "pqr", str3 = "xyz";

               Console.WriteLine("Please choose a Program from below option:");
               Console.WriteLine("1:Print Array \n2:Print Array usung Generic Method \n3:Generic Class Concept" +
                   "\n4.Find Maximum \n5.Find max using generics");
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
                       Console.WriteLine("\n Integer Comparison");
                       FindMaximum.FindMaxValue(a, b, c);
                       Console.WriteLine("\nFloat Comparison");
                       FindMaximum.FindMaxValue(x,y,z);
                       Console.WriteLine("String Comparison");
                       var res1=FindMaximum.FindMaxValue(str1, str2, str3);
                       if(res1 != null)
                       {
                           Console.WriteLine("{0} is greater than among all {1} {2} {3}", res1, str1, str2, str3);
                       }
                       else
                       {
                           Console.WriteLine("2 or 3 numbers have same value");
                       }
                       break;
                   case 5:
                       FindmaxRefactor<int> obj= new FindmaxRefactor<int>(10,20,30);
                       int Result = obj.TestMaximum();
                       Console.WriteLine(Result);
                       FindmaxRefactor<float> obj2 = new FindmaxRefactor<float>(10.88f, 20.65f, 30.65f);
                       float Result2 = obj2.TestMaximum();
                       Console.WriteLine(Result2);
                       FindmaxRefactor<string> obj3 = new FindmaxRefactor<string>("abc", "dre", "hjh");
                       string Result3 = obj3.TestMaximum();
                       Console.WriteLine(Result);
                       break;
               Console.ReadLine();

           }*/
        }
    }
    }

