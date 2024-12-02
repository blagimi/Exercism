#region  Условие
/*
   Посчитать количество зерен пщеницы на шахматной доске, число на каждой клетке удваивается.
   Всего 64 клетки. На первой 1 на второй 2 и так далее. 
   Сколько зерен будет на клетке(К)?
   Сколько всего будет зерен на шахматной доске. 
*/
#endregion

#region Вывод
ChessBoard.NumbersOnSquare(10);
ChessBoard.TotalNumbers();
System.Console.WriteLine("~~~~~~~~~~~~~~~");
Console.WriteLine(ChessBoard2.NumbersOnSquare(10));
ChessBoard2.TotalNumbers();
#endregion

#region Описание решения 1
public static class ChessBoard
{
    public static void NumbersOnSquare(byte number)
    {
        if (number < 1 || number > 64) throw new ArgumentOutOfRangeException("За пределами шахматного поля");
        for (ulong i = 1, j = 1; i <= number; i++)
        {
            System.Console.WriteLine($"Field {i} : {j} grains");
            j *= 2;       
        }
    }
    public static void TotalNumbers()
    {
        for (ulong i = 1, j = 1, total = 0; i <= 64; i++)
        {
            System.Console.WriteLine($"Field {i} : {j} grains");
            total += j;
            System.Console.WriteLine($"Total grains on desk so far: {total}");
            j *= 2;
            
        }
    }
}
#endregion

#region Описание решения 2
public static class ChessBoard2
{
    public static ulong NumbersOnSquare(byte n)
    {
        if (n < 1 || n > 64) throw new ArgumentOutOfRangeException();
        return (ulong)Math.Pow(2, n-1);
    }
    public static ulong TotalNumbers()
    {
        ulong sum = 0;
        for (byte i = 1; i <= 64; i++)
        {
            sum += NumbersOnSquare(i);
        }
        System.Console.WriteLine(sum);
        return sum;
    }
}

#endregion