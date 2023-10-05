// ﻿// Напишите программу, которая принимает на вход пятизначное число
// // и выдает, является ли оно палиндромом или нет
// public class Answer
// {
//     static bool IsPalindrome(int number){
//         // Введите свое решение ниже
//         int numberLength = 5;
//             int[] digits = new int[numberLength];
//             for (int i = numberLength - 1; i >= 0; i--) {
//                 digits[i] = number % 10;
//                 number /= 10;
//             }
//             for (int i = 0; i < numberLength/2; i++) {
//                 if (digits[i] != digits[numberLength - i - 1])
//                     return false;
//             }
//             return true;
//     // int reversedNumber = 0;
//     // while (number != 0)
//     // {
//     //     int remainder = number % 10;
//     //     reversedNumber = reversedNumber * 10 + remainder;
//     //     number /= 10;
//     // }
//     // if (number == reversedNumber)
//     // {
//     //    return true;
//     // }
//     // else
//     // {
//     //     return false;
//     }

    
//     //Не удаляйте и не меняйте метод Main!
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             //Здесь вы можете поменять значения для отправки кода на выполнение
//             number = 64546;
//         }

//         //Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }
//Эталонное решение
using System;

public class Answer
{
    static bool IsPalindrome(int number){
        if (number < 10000 || number >= 100000){
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int reverse = 0;
        int temp = number;
        while (temp > 0){
            reverse = reverse * 10 + temp % 10;
            temp /= 10;
        }
        return reverse == number;
    }

      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 645464;
        }

        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
