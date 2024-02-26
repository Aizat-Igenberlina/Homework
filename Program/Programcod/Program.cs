// See https://aka.ms/new-console-template for more information
using System;

class Program

//{
//    static void Main(string[] args)

//    {
//        string[] originalArray = {"abc", "defg", "hijklm", "nop", "q", "rst"};
//        int newIndex = 0;

//        for (int i = 0; i < ogiginalArray.Length; i++)

//      {
//          if(originalArray[i].Length <= 3)
//            {
//                NewArray[newIndex] = originalArray[i];
//                newIndex++;
//            }
//        }
//        Console.Writeline("Новый массив строк:");
//        for(int i = 0; i <= newIndex; i++)

//        {
//            Console.Writeline(NewArray[i]);
//        }
//    }
//
//}

// string[] M;
//            Console.WriteLine("Введите массив строк через пробел");
//            string stroka = Console.ReadLine();
//            M = stroka.Split(' ');
//            var result = new string[M .Length];
//            var realSize = 0;
//            foreach (var value in M )
//            {
//                if (value.Length <= 3)
//                {
//                    result[realSize] = value;
//                    realSize++;
//                }
//            }
//            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
//            Console.ReadKey(true);
string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2)