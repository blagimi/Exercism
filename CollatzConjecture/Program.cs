#region Условие
/*
    Вводится число если оно делится на 2 (четное) делим его на 2. 
    Если не четное число умножается на 3 и к нему добавляется 1.
    Процесс повторяется до тех пор пока число не станет 1. 
*/
#endregion

#region Вывод
Numbers.Count(12);
Numbers.Count2(12);

#endregion

#region Описание решения 
public static class Numbers
{
    public static bool isEven = false;
    public static int steps = 0;
    public static void Count(int numbers)
    {
        if (numbers <= 1) throw new ArgumentOutOfRangeException("Incorrect number input");
        for ( int i = 10; i > 1 ; i--)
        {
            
            isEven = numbers % 2  == 0;
            if (isEven)
            {
                System.Console.WriteLine($"Number {i} is even, current numbers is {numbers}");
                numbers /= 2;
            }
            else 
            {
                System.Console.WriteLine($"Number {i} is odd, current numbers is {numbers}");
                numbers = (numbers * 3) + 1;
            }
            steps++;
        }
        System.Console.WriteLine($"Result in : {steps-1} steps");       
    }
    public static void Count2(int numbers)
    {
        if (numbers <= 0) throw new ArgumentOutOfRangeException("Incorrect number input");
        int steps2 = 0;
        while (numbers != 1)
        {   
            System.Console.WriteLine($"current numbers is {numbers}");
            numbers = numbers % 2 == 0  ? numbers /= 2 : numbers = (numbers * 3) + 1;
            steps2++;
        }
        System.Console.WriteLine($"Result in : {steps2} steps");
    }
}
#endregion
