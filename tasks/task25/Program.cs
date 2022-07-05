/*Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)               2, 4 -> 16   */

int exponentiation (int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}

Console.WriteLine("Введите 2 числа: ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

int resultOfExponentiation = exponentiation(numA, numB);
System.Console.WriteLine($"{numA}, {numB} -> {resultOfExponentiation}");
