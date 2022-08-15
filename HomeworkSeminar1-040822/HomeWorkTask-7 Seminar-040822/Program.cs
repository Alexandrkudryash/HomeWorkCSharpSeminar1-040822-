// Задача-7: Показать вторую цифру трёхзначного числа
// ДЗ к Семинару 1 от 04.08.2022

Console.Clear();
Console.WriteLine("Введите любое трёхзначное число");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a > 100 && a < 1000)
   {
     int b = a/100;
     int c = a - (b*100);
     int d = c/10;
     Console.Write("Вторая цифра введённого числа = ");
     Console.WriteLine(d);
   }
else 
Console.WriteLine("Введено не трёхзначное число");
