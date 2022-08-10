// Задача-4: Выяснить является ли число четным.
// ДЗ к Семинару 1 от 04.08.2022 

Console.WriteLine("введите число, проверим оно чётное или нет");
int a = int.Parse(Console.ReadLine());

if ( a%2 == 0) 
{
    Console.Write("введенное число ");
    Console.Write(a);
    Console.WriteLine(" является чётным");
}
else
{
    Console.Write("введенное число ");
    Console.Write(a);
    Console.WriteLine(" чётным НЕ является!");
}

