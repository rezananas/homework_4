/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SummOfDigits(int number)
{
    int summ_of_digit = 0;
    while(number > 0)
    {
        summ_of_digit += number % 10;
        number = number / 10;
    }
    return summ_of_digit;
}

Console.WriteLine("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int user_number = Math.Abs(user_num);

int summ = SummOfDigits(user_number);
Console.WriteLine($"Сумма цифр в числе {user_number} равняется {summ}");