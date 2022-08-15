// // Задача-3: Найти максимальное из трех чисел
// ДЗ к Семинару 1 от 04.08.2022 
//Console.WriteLine("Hello, World!");

Console.Clear();
Console.WriteLine("Введите три числа" ?? "0");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (b > max ) max = b;
if (c > max ) max = c;

Console.Write ("Максимальное из введённых чисел = ");
Console.WriteLine(max);

