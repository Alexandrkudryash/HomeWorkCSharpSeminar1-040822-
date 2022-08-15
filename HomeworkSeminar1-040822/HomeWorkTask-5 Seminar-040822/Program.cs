// Задача-5: Показать числа от  - N до N
// ДЗ к Семинару 1 от 04.08.2022 

Console.Clear();
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine() ?? "0");

int count = N*(-1);
while (count <= N )
{
    Console.WriteLine(count);
    count++;
}
