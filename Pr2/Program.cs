using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int studentNumberLastDigit = 6;

        ChooseNumbersInRange(studentNumberLastDigit);
        CalculateTriangleProperties();
        FindMinMaxInArray(studentNumberLastDigit);
        CreateNewArrayBasedOnModulo(studentNumberLastDigit);
    }

    static void ChooseNumbersInRange(int studentNumberLastDigit)
    {
        int upperLimit = 10 + studentNumberLastDigit;

        Console.WriteLine("\n--- Вибір чисел, що належать інтервалу ---");
        Console.WriteLine("Введіть три цілих числа:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Числа в інтервалі [1, {upperLimit}]:");
        if (num1 >= 1 && num1 <= upperLimit) Console.WriteLine(num1);
        if (num2 >= 1 && num2 <= upperLimit) Console.WriteLine(num2);
        if (num3 >= 1 && num3 <= upperLimit) Console.WriteLine(num3);
    }

    static void CalculateTriangleProperties()
    {
        Console.WriteLine("\n--- Периметр, площа і тип трикутника ---");
        Console.WriteLine("Введіть три сторони трикутника:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (IsValidTriangle(a, b, c))
        {
            double perimeter = a + b + c;
            double s = perimeter / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine($"Периметр: {perimeter}");
            Console.WriteLine($"Площа: {area}");

            DetermineTriangleType(a, b, c);
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не може існувати.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

    static void DetermineTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            Console.WriteLine("Трикутник рівносторонній.");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("Трикутник рівнобедрений.");
        }
        else
        {
            Console.WriteLine("Трикутник різносторонній.");
        }
    }

    static void FindMinMaxInArray(int studentNumberLastDigit)
    {
        int arrayLength = 10 + studentNumberLastDigit;
        int[] array = new int[arrayLength];

        Console.WriteLine($"\n--- Мінімальне та максимальне значення в масиві ---");
        Console.WriteLine($"Введіть {arrayLength} елементів масиву:");
        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = array[0];
        int max = array[0];

        foreach (int num in array)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        Console.WriteLine("Масив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine($"\nМінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }

    static void CreateNewArrayBasedOnModulo(int studentNumberLastDigit)
    {
        int arrayLength = 10 + studentNumberLastDigit;
        int[] arrayX = new int[arrayLength];

        Console.WriteLine($"\n--- Формування нового масиву на основі модуля елементів ---");
        Console.WriteLine($"Введіть {arrayLength} елементів масиву X:");
        for (int i = 0; i < arrayLength; i++)
        {
            arrayX[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введіть значення M:");
        int M = Convert.ToInt32(Console.ReadLine());

        List<int> arrayY = new List<int>();
        foreach (int num in arrayX)
        {
            if (Math.Abs(num) > M)
            {
                arrayY.Add(num);
            }
        }

        Console.WriteLine($"Число M: {M}");
        Console.WriteLine("Масив X:");
        foreach (int num in arrayX)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nМасив Y:");
        foreach (int num in arrayY)
        {
            Console.Write(num + " ");
        }
    }
}
