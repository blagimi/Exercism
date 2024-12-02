#region 1 вариант инициализация
OneFor Alice    = new ("Alice");
OneFor Bohdan   = new ("Bohdan");
OneFor you      = new ();
OneFor Zaphod   = new ("Zaphod");
#endregion

#region 2 вариант вызов
Console.WriteLine(TwoFor.Speak("Alice"));
Console.WriteLine(TwoFor.Speak("Bohdan"));
Console.WriteLine(TwoFor.Speak());
Console.WriteLine(TwoFor.Speak("Zaphod"));
#endregion


#region  1 вариант
public class OneFor
{
    public string Name = "";
    public OneFor()
    {
        System.Console.WriteLine("One for you, one for me");
    }
    public OneFor(string name)
    {
        this.Name = name;
        System.Console.WriteLine($"One for {name}, one for me");
    }
}
#endregion

#region 2 вариант

public static class TwoFor
{
    public static string Speak()
    {
        return "One for you, one for me";
    }
    public static string Speak(string name)
    {
        return $"One for {name}, one for me";
    }
}
#endregion