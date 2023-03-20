// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53;

// int Readint(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int[] a = new int[3];
// int[] b = new int[3];
// a[0] = Readint("Введите координату Х точки А: ");
// a[1] = Readint("Введите координату Y точки А: ");
// a[2] = Readint("Введите координату Z точки А: ");
// b[0] = Readint("Введите координату Х точки B: ");
// b[1] = Readint("Введите координату Y точки B: ");
// b[2] = Readint("Введите координату Z точки B: ");


// double res = Math.Round(Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2)), 2);
// System.Console.WriteLine("Расстояние между точками = " + res);

// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// int Readint(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void NumberPow(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         System.Console.Write(Math.Pow(i, 3) + " ");
//     }
// }

// int number = Readint("Введите число: ");
// NumberPow(number); // Вывод через функцию

// int number = Readint("Введите число: ");
// for (int i=1; i<=number; i++)
// {
//     System.Console.Write(Math.Pow(i, 3) + " "); // Вывод через цикл for
// }

//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да;

// Console.WriteLine("Введите пятизначное число: ");
// string num = Console.ReadLine()!;
// int n = num.Length;

// if (num.Length == 5)
// {
//     if (num[0] == num[4] && num[1] == num[3])
//     {
//         Console.WriteLine($"{num} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{num} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($": {num} - не является пятизначным");
// } // Мой метод


/* Альтернативный метод от софьи
//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;

CheckingPolindrom(number);

// -----------------------Methods----------------------------
bool CheckingPolindrom(string number){
    if(number.Length == 5){
        if(number[0] == number[4] && number[1] == number[3]){
            Console.WriteLine("Данное число является палиндромом!");
        }
        else{
            Console.WriteLine("Данное число не является палиндромом!");
        }
    }
    else{
        Console.WriteLine("Введено неверное число!");
        return false;
    }
    return true;
}
*/