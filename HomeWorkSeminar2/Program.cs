// Task 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int CutNumber (int func_num)
// {   
//     int result = func_num / 10 % 10;
//     return result;
// }

// Console.Write("Input a three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num < 100 || num > 1000)
// {
//     Console.Write("This is not a three-digit nimber, please insert a three-digit number");
// }
// else
// {
//     int newNumber = CutNumber(num);
//     Console.WriteLine($"New version of {num} is {newNumber}");
// }    

// Task 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

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

// Console.Write("Input a number: ");
// int initialNum = Convert.ToInt32(Console.ReadLine());
// int reverseNum = reverseDigits(initialNum);

// int digit3;
// if (reverseNum >= 100)
// {
//     digit3 = reverseNum / 100 % 10;
//     Console.WriteLine($"Third digit of {initialNum} is {digit3}");
// }    
// else
//    Console.WriteLine($"The number does not have third digit");


// Task15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// bool WEorNot(int p_num)
// {
//     if(p_num == 6 || p_num == 7)
//         return true;      
//     else
//         return false;
// }        

// Console.Write("Please, insert a nunber of a day of the week: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool result = WEorNot(number);

// if (result) 
// {
//     Console.WriteLine($"This day is a Weekend!");
// }
// else
// {
//     if (number > 0 && number < 6)
//     {
//         Console.WriteLine($"This day is not a Weekend!");
//     }
//     else
//     { 
//         if (number <=0 || number > 7)
//         {
//             Console.WriteLine($"This number is not a number of a day of the week, please insert a number form 1 to 7");
//         }
//     }
// }