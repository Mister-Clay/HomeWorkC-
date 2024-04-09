//  Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int reverseDigits(int p_initialNum)
// {
//     int revNum = 0;
//     while (p_initialNum > 0) 
//     {
//         revNum = revNum * 10 + p_initialNum % 10; 
//         p_initialNum = p_initialNum / 10;
//     }
//     return revNum;
// }
// Console.Write("Input a number >= 10: ");
// int initialNum = Convert.ToInt32(Console.ReadLine());
// int reverseNum = reverseDigits(initialNum);
// if (initialNum >= 10)
// {
//     if (reverseNum == initialNum)
//     {
//         Console.WriteLine($"Yes, your number {initialNum} is a palindrome!");
//     }    
//     else
//         Console.WriteLine($"No, your number {initialNum} is not a palindrome");
// }
// else
// Console.WriteLine($"Please, input a number >= 10");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Distance ( double p_xA, double p_yA, double p_zA, double p_xB, double p_yB, double p_zB)
// {
//     double p_hypotenuse = Math.Sqrt ((p_xA - p_xB)*(p_xA - p_xB) + (p_yA - p_yB)*(p_yA - p_yB) + (p_zA - p_zB)*(p_zA - p_zB));
//     return p_hypotenuse;
// } 
// Console.WriteLine("Input coordinates of point A in 3D (xA, yA, zA): ");
// double xA = Convert.ToDouble(Console.ReadLine());
// double yA = Convert.ToDouble(Console.ReadLine());
// double zA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinates of point B in 3D (xB, yB, zB): ");
// double xB = Convert.ToDouble(Console.ReadLine());
// double yB = Convert.ToDouble(Console.ReadLine());
// double zB = Convert.ToDouble(Console.ReadLine());
// double dist = Distance (xA, yA, zA, xB, yB, zB);
// Console.WriteLine ($"The distance between point A [{xA}, {yA}, {zA}] and point B [{xB}, {yB}, {zB}] is {dist}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubNum (int p_num)
// {
//     int current = 1;
//     while (current <= p_num)
//     {
//         Console.Write ($" {current * current * current},");
//         current++;
//     }
// }
// Console.Write ("Input your number: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// CubNum (Number);