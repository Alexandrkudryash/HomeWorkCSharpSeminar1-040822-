// Задача-6: Показать последнюю цифру трёхзначного числа
// ДЗ к Семинару 1 от 04.08.2022 

Console.Clear();
Console.WriteLine("Введите любое трёхзначное число");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a/100;
int c = a - (b*100);
int d = c/10;
int N = c -(d*10);
Console.Write("Третья цифра введённого числа = ");
Console.WriteLine(N);
