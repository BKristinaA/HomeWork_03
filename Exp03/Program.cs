// Напишите программу, которая на вход принимает число N и выдает таблицу кубов чисел от 1 до N.

int ValueInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void cubeNumber(int number)
{
    
    for (int i = 1; i <= number; i++)
    {
        double cube = Math.Pow (i, 3);
        Console.WriteLine($"{i} = " + cube);
    } 
}
int number = ValueInput();
cubeNumber(number);