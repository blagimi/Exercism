#region Условие
/*
    Определить является ли введенное слово Изограмой.
    Изограма это слово или фраза в которой нет повторяющихся букв.
    Пробелы и дефисы не учитываются.
*/ 
#endregion

#region Вывод

Console.WriteLine(Word.IsIsogram("lumberjack"));
Console.WriteLine(Word.IsIsogram("abrakadabra"));

#endregion

#region Описание решения
public static class Word
{
    public static bool IsIsogram(string word)
    {
        var output = word.ToLower().Where(char.IsLetter).ToList();
        return output.Distinct().Count() == output.Count;
    }
} 
#endregion