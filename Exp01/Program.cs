//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void Polindrom(int number)
{
    if (number / 10000 == number % 10)
    {
        int newNumber = number / 1000 % 10;
        number = number / 10 % 10;
        if (newNumber == number)
        {
            Console.WriteLine("Число является палиндром");
        }
        else Console.WriteLine("Число не является палиндром");
    }
    else Console.WriteLine("Число не является палиндром");
}
int ValueInput()
{
    Console.Write("Введите пятизначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int number = ValueInput();
Polindrom(number);
