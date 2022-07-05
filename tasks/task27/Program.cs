/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int SumCalculation(int inputNumber)
{
    int result = 0;
    while (inputNumber > 0)
    {
        result = result + inputNumber % 10;
        inputNumber = inputNumber / 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int output = SumCalculation(number);
Console.WriteLine($"{number} -> {output}");



