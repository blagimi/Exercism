/*
1)Generate random name for robot with 2 uppercase letters and three digits RX837 as example. /Done
2)Reset robot and give new name to him  / Done
3)Random names without collision, all name must be unique.  / Done
*/

/*
System.Console.WriteLine("**********************************  Create first part robots **********************************");
Names.GiveName();
Names.GiveName();
System.Console.WriteLine("**********************************  Проверка наименований    **********************************");
Names.NamesCount();
System.Console.WriteLine("**********************************  Сброс наименований       **********************************");
Names.ResetName(1);
System.Console.WriteLine("**********************************  Create 2 second robots   **********************************");
Names.GiveName();
Names.GiveName();
System.Console.WriteLine("**********************************  Проверка наименований    **********************************");
Names.NamesCount();
System.Console.WriteLine("**********************************  Сброс наименований       **********************************");
Names.ResetName(2);
System.Console.WriteLine("**********************************  Create 3 rd part robots  **********************************");
Names.GiveName();
Names.GiveName();
System.Console.WriteLine("**********************************  Проверка наименований    **********************************");
Names.NamesCount();
*/

public static class Names
{
    private static readonly List<string> NameList = ["AA000"];
    /// <summary>
    /// Открытие списка и просмотр его содержимого
    /// </summary>
    /// <returns> Вывод всего содержимого на экран </returns>
    public static List<string> NamesCount()
    {
        System.Console.WriteLine("Names List: ");
        NameList.ForEach(Console.WriteLine);
        return NameList; 
    }

/// <summary>
/// Создание случайного уникального имени для роботов состоящего из букв и цифр
/// </summary>
/// <param name="nameLength">Длина имени</param>
/// <returns>Имя в виде строки содержащие 2 буквы и 3 цифры</returns>
/// <exception cref="Exception">Допускаются только уникальные имена, иначе ошибка.</exception>
    private static string GenerateName(int nameLength) 
    {

        Random r = new Random();
        string [] letters = ["A","B","C","D","E","F","G"];
        string [] digits = ["0","1","2","3","4","5","6","7","8","9"];
        string newName = "";
        for (int nameLetters = 0; nameLetters <= 2; nameLetters++)
            {
                newName += letters[r.Next(letters.Length)].ToUpper();
                nameLetters++;
            }
        for(int nameDigits = 0; nameDigits < nameLength; nameDigits++)
            {
                newName += digits[r.Next(digits.Length)];
                nameDigits++;
            }
        if (!NameList.Contains(newName))
                {
                    NameList.Add(newName);
                }
                else  
                {
                    throw new Exception  ("Наименование уже содержится в списке активных роботов");
                }

        return newName;
    }
    /// <summary>
    /// Обертка для работы с генератором имен, вызывает генератор и выводит результат работы на экран
    /// </summary>
    public static void GiveName()
    { 
        System.Console.WriteLine($"New robot created, robot name {GenerateName(5)}");
    }
    /// <summary>
    /// Сброс имени робота и присвоение ему нового значения
    /// </summary>
    /// <param name="value">указатель на индекс в списке</param>
    public static void ResetName(int value)
    {
        System.Console.WriteLine($"Робот с наименованием {NameList[value]} сбрасывает настройки на заводские");
        //NameList[value] = GenerateName(5);
        NameList.RemoveAt(value);
        Console.WriteLine($"Роботу присваивается новое наименование {GenerateName(5)}");
        //System.Console.WriteLine($"Роботу присваивается новое наименование {NameList[value]}");


    }
}