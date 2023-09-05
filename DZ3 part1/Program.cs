// See https://aka.ms/new-console-template for more information
using System;
using DZ3_part1;

        Console.Write("Введите длину стороны квадрата: ");
        int sideLength = int.Parse(Console.ReadLine());

        Console.Write("Введите символ для квадрата: ");
        char symbol = Console.ReadLine()[0];

        PrintSquare(sideLength, symbol);
        Console.WriteLine("Проверка числа на палиндромность");
        Console.Write("Введите число для проверки: ");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine($"Число {number} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Число {number} не является палиндромом.");
        }

        Console.WriteLine("Метод для фильтрации массива на основании переданных параметров");
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filterArray = { 6, 88, 7 };

        int[] resultArray = FilterArray(originalArray, filterArray);

        Console.WriteLine("Результат фильтрации:");
        foreach (int num in resultArray)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("Проверка класса веб-сайт");
        Website myWebsite = new Website();
        myWebsite.InputData();
        myWebsite.DisplayData();

       // Доступ к полям через методы класса
       string websiteName = myWebsite.GetSiteName();
       myWebsite.SetSiteName("Новое название сайта");

       Console.WriteLine("Проверка класса Journal");
       Journal journal = new Journal();
       journal.InputData();
       journal.OutputData();


Shop shop = new Shop();
shop.InputData();
shop.DisplayData();

string name = shop.GetName();
string address = shop.GetAddress();
string profileDescription = shop.GetProfileDescription();
string phoneNumber = shop.GetPhoneNumber();
string email = shop.GetEmail();
// можно использовать полученные данные дальше по необходимости
static void PrintSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }

       
    static bool IsPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }
   
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        int[] resultArray = new int[originalArray.Length];
        int resultIndex = 0;

        // Проходим по каждому элементу оригинального массива
        foreach (int num in originalArray)
        {
            // Проверяем, есть ли этот элемент в массиве для фильтрации
            bool isInFilterArray = false;
            foreach (int filterNum in filterArray)
            {
                if (num == filterNum)
                {
                    isInFilterArray = true;
                    break;
                }
            }

            // Если элемент не найден в массиве для фильтрации, добавляем его в результат
            if (!isInFilterArray)
            {
                resultArray[resultIndex] = num;
                resultIndex++;
            }
        }

        // Создаем новый массив размером с количеством найденных элементов
        int[] finalResult = new int[resultIndex];
        Array.Copy(resultArray, finalResult, resultIndex);

        return finalResult;
    }
