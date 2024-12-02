#region Условие
/*
    Проверить введеное число, является ли оно идеальным.
    Идеальное число равно сумме его делителей. Например 6 = 1(6/6) + 2(6/2) + 3(6/3)
*/
#endregion

#region Вывод
using System.Diagnostics.CodeAnalysis;

IsPerfectNumber.CheckNumber(497);
#endregion

#region Описание решения
public class IsPerfectNumber
{
    public static int sum = 0;
    public static string divNumbers = "";
    public static void CheckNumber(int number)
    {
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
                divNumbers += i.ToString() + " ";
            }
        }
        System.Console.WriteLine($"DivNumbers for number : {divNumbers} Summ all numbers: {sum}");
        if (sum == number)
        System.Console.WriteLine("Это число идеальное.");
        else
        System.Console.WriteLine("Это обычное число.");       
    }
}
#endregion