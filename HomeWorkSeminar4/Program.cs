// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double Expon(double p_A, int p_B)
// {
//     double ExponRes = 1;
//     for (int i = 1; i <= p_B; i++)
//     {
//         ExponRes = ExponRes * p_A;
//     }
//     return ExponRes;
// }
// Console.WriteLine("input a double number A and an integer number B3 ");
// double numberA = Convert.ToDouble (Console.ReadLine());
// int numberB = Convert.ToInt32 (Console.ReadLine());
// double result = Expon(numberA, numberB);
// Console.WriteLine($"Raising {numberA} to the power of {numberB} is {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int GetSumOfDigits(int p_num)
// {
//     int sumOfRemaimders = 0;
//      while (p_num > 0)
//      {
//         sumOfRemaimders = p_num % 10 + sumOfRemaimders;
//         p_num = p_num / 10;
//      }

//     return sumOfRemaimders;
// }
// Console.Write ("input a number: ");
// int number = Convert.ToInt32 (Console.ReadLine());
// int result = GetSumOfDigits (number);
// Console.WriteLine ($"sum of digits of the number {number} is {result}");

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int[] CreateArray (int size, int minValue, int maxValue)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array [i] = new Random().Next(minValue, maxValue + 1);
//     }
// return array;
// }
// void printArray (int [] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write (array [i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Write ("Input a length of array: ");
// int size = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a min value: ");
// int min = Convert.ToInt32 (Console.ReadLine());
// Console.Write ("Input a max value: ");
// int max = Convert.ToInt32 (Console.ReadLine());

// int [] newArray = CreateArray(size, min, max);
// printArray(newArray);