Nucleotide.Count("GATTACA");
public static class Nucleotide
{
    public static IDictionary<char,int> Count(string inputLine)
    {
        var nucleotidesList = new Dictionary<char,int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (char nucleotideChar in inputLine)
        {
            if (!nucleotidesList.ContainsKey(nucleotideChar))
            {
                throw new Exception ("В строке используются неправильные символы");
            }
            nucleotidesList[nucleotideChar]++;         
        }
        nucleotidesList.ToList().ForEach(A => Console.WriteLine(A.Key + " : " + A.Value));
        return nucleotidesList;
    }
}