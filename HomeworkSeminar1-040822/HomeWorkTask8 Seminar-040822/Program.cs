// Задача-8: Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
// ДЗ к Семинару 1 от 04.08.2022

Console.Clear();
int N = new Random().Next(10, 99);
Console.WriteLine("Пусть число из отрезка будет " +N);

int a = N/10;
int b = N-(a*10);

if (a > b) Console.WriteLine("Наибольшая цифра числа это " +a);
else 
Console.WriteLine("Наибольшая цифра числа это " + b);
