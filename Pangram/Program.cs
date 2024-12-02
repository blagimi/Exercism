#region Условие
/*
    Определить является ли введенное фраза Панграмой.
    Панграма это фраза в которой находятся все буквы алфавита.
    Пробелы и дефисы не учитываются. Буквы могут повторятся. 
*/ 
#endregion

#region Вывод

Fonts.IsPangram("The quick brown fox jumps over the lazy dog");
Fonts.IsPangram("Quilt frenzy jackdaw gave them best pox");
Fonts.IsPangram("In the town where I was born lived a man who sailed to sea");

#endregion

#region Описание решения
public static class Fonts
{
    public static bool IsPangram (string pangram)
    {
        var output = pangram.ToLower().Where(x => char.IsLetter(x)).GroupBy(x => x).Count() == 26;

        System.Console.WriteLine(output);
        return output;
    }
}
#endregion