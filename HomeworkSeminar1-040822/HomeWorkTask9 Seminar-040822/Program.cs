// Задача-9: Удалить вторую цифру трехзнаного числа
// ДЗ к Семинару 1 от 04.08.2022


Console.Clear();
Console.WriteLine("Введите любое трёхзначное число");
int a = int.Parse(Console.ReadLine() ?? "0"); // а = полное число вводит пользователь

if (a > 100 && a < 1000)
{
int first = a/100;  // обычное деление на 100 - это первая цифра трехзначного числа
int last = a%10; // - последняя цифра 3х значного числа

int result = first * 10 + last;

Console.Write("Трёхзначное число становится двухзначным");
Console.Write(", если убрать вторую цифру, и наше число превращается в  = ");
Console.WriteLine(result);
}
else 
Console.WriteLine("введено не 3-х значеное число");
