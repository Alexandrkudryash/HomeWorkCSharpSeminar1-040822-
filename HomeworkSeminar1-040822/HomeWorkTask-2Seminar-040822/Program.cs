// Задача-2: По заданному номеру дня недели вывести его название
// ДЗ к Семинару 1 от 04.08.2022 

Console.WriteLine("Введите номер дня недели");
int d = int.Parse(Console.ReadLine());

if (d == 1) { Console.WriteLine("Сегодня Понедельник"); }
if (d == 2) { Console.WriteLine("Сегодня Вторник");}
if (d == 3) { Console.WriteLine("Сегодня Среда");}
if (d == 4) { Console.WriteLine("Сегодня Четверг");}
if (d == 5) { Console.WriteLine("Сегодня Пятница");}
if (d == 6) { Console.WriteLine("Сегодня Суббота");}
if (d == 7) { Console.WriteLine("Сегодня Воскресенье");}
else
{
    Console.WriteLine("Набранное число не является днём недели");
}