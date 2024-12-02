Console.WriteLine(GigasecondConverter.Converter(DateTime.Parse("1990.4.21")));

public static class GigasecondConverter
{
    const int GIGASECOND = 1000000000;
    public static DateTime Converter(DateTime dateTime) 
    {
        return dateTime.AddSeconds(GIGASECOND);
    }
}