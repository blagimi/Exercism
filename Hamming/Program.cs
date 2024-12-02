Console.WriteLine(HammingDistance.LineDistance("GAGCCTACTAACGGGAT","CATCGTAATGACGGCCT"));
public static class HammingDistance
{
    public static int LineDistance(string Line1, string Line2)
    {
        if (Line1.Length != Line2.Length)
        {
            throw new ArgumentException("Длина строк не равна");
        }
        int hamDistance = 0;
        for (int i = 0; i < Line1.Length; i++)
        {
            if (Line1[i] != Line2[i])
            {
                hamDistance++;
            }
        }
        return hamDistance;
    }
    // string 1 17 letters (CAGT)
    // string 2 17 letters (CAGT)
    // string 3 17 letters check difference between string 1&2 and mark difference, count all marks 
    // check Line length they should be same
}