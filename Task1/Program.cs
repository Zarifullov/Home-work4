/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int b = int.Parse (Console.ReadLine());

int Count (int a, int b)
{
    int i = 1;
    int result = 1;
    while (i <= b)
    {
        result = result * a;
        i++;
    }    
    return result;
}
Console.WriteLine(Count(a,b));