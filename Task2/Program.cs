/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.WriteLine("Введите число N: ");

string s = Console.ReadLine();

int n = int.Parse(s);

int Number (int n)
{
    int[] array = new int [n];
    int result = 0;
    
    for(int i = 0; i <= array.Length; i++)
    {
        result = result + array[i];
    }
    return result;
}

Console.WriteLine(Number(n));


