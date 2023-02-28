using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task65
{
    internal class Program
    {
        /*Условие:
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Создайте програму в которой создайте метод который возвращает одномерный 
        целочисленный массив типа int размерностью n элементов (n –параметр метода), который 
        заполняется произвольными значениями. В методе Main() создайте целочисленный массив 
        размерностью 10 элементов и присвойте ему возвращаемое значение метода, который  
        создали ранее. Далее найдите: 
        1)   Сумму всех элементов массива и выведите ее на консоль;
        2)   Сумму все четных  элементов массива и выведите ее на консоль;
        3)   Среднее арифметическое элементов массива и выведите ее на консоль;
        4)   Все элементы массива которые больше чем среднее арифметическое и выведите 
        их на консоль.*/
        static int[] AvtoArray(int n)
        {
            int[] myArray = new int[n];
            Random myRandom = new Random();            
            for (int i = 0; i < n; i++)
            {
                myArray[i] = myRandom.Next(1,11);
            }
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] NewArray = new int[10];
            int[] SubArray = AvtoArray(5); // (n –параметр метода)
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < SubArray.Length; i++)
            {
                NewArray[i] = SubArray[i];
                sum1 += NewArray[i];         // Сумму всех элементов массива 
                if (NewArray[i] % 2 == 0)
                {
                    sum2 += NewArray[i];     // Сумму все четных  элементов массива 
                }
                Console.WriteLine(NewArray[i]);
            }
            double sum3 = (double)sum1 / SubArray.Length; // Среднее арифметическое элементов массива
            Console.WriteLine($"Среднее арифметическое элементов массива: {sum3}");
            Console.Write($"Все элементы массива которые больше чем среднее арифметическое: ");
            for (int i = 0; i < SubArray.Length; i++)
            {
                if (NewArray[i] > sum3) // Все элементы массива которые больше чем среднее арифметическое
                {
                    Console.Write($"'{NewArray[i]}'");  
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумму всех элементов массива: {sum1}");
            Console.WriteLine($"Сумму все четных  элементов массива: {sum2}");
            Console.ReadKey();
        }
    }
}
