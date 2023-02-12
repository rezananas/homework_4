/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
Console.WriteLine("Введите число А: ");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int num_b = Convert.ToInt32(Console.ReadLine());

int degree = 1;
if(num_b > 0)
{
    for(int i = 1; i <= num_b; i++)
    {
        degree = degree * num_a;
    }
    Console.WriteLine($"Число {num_a} в степени {num_b} равно {degree}");
}
else
{
    Console.WriteLine("Это ненатуральное число B");
}
*/

void FindDegree(int num_a, int num_b)
{
    int degree = 1;
    for(int i = 1; i <= num_b; i++)
    {
        degree = degree * num_a;
    }
    Console.WriteLine($"Число {num_a} в степени {num_b} равно {degree}");
}

Console.WriteLine("Введите число А: ");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int num_b = Convert.ToInt32(Console.ReadLine());

if(num_b > 0)
{
    FindDegree(num_a, num_b);
}
else
{
    Console.WriteLine("Это ненатуральное число B");
}