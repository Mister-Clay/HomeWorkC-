// Task 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input a firs number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input an second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//   Console.WriteLine($"First number {num1} greater than the second {num2}");
// }
// else
// {
//   Console.WriteLine($"Second number {num2} greater than the First {num1}");
// }

//Task2. Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

// Console.WriteLine("Input a firs number:");
//   int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input an second number:");
//   int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter the third number:");
//   int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > max)
//     max = num2;
// else
//     num1 = max;
// if (num3 > max)
//     max = num3;
// else 
//     num3 = max;
// Console.WriteLine("The largest of the three numbers: " + max);

//Task3. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input an integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
 
// if (num % 2 == 1)
// {
//     Console.WriteLine($"Number {num} is odd ");
// }
// else
// {
//     Console.WriteLine($"Number {num} is even");
// }

//Task4.  Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

// Console.Write("input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int b = 1;
// int current = b;

// while(current <= num)
// {
//     if (current % 2 == 0)
//     {
//         Console.Write(current + " ");
//     }
//     current++;
// }