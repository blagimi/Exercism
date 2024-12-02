Leap newYear = new(2000);
Console.WriteLine(newYear.Divided());
Console.WriteLine(Leap.IsThisLeapYear(1997));

public class Leap(int Year)
{
    #region 1 вариант
    public int year = Year;
    public bool isLeapYear = false;
    public bool Divided()
    {
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            isLeapYear = true;
        }
        return isLeapYear;
    }
    #endregion

    #region 2 вариант
    public static bool IsThisLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    #endregion
}