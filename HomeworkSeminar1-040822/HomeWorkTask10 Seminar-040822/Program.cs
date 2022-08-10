// Задача-10: Выяснить кратно ли число заданному, если нет, вывести остаток
// ДЗ к Семинару 1 от 04.08.2022

int a = 15;

Console.Write("Задано число, оно составляет = ");
Console.WriteLine(a);

Console.WriteLine("Введите любое число");
int b = int.Parse(Console.ReadLine());

if (b%a == 0) Console.WriteLine("Введенное Вами число кратно заданному числу" );
else
   {
   Console.Write("Введённое Вами число НЕ кратно заданному, остаток от деления = ");
   Console.WriteLine(b%a);
   } 
