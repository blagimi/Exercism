HightScoreList newList = new ([100,200,300,400,500,7700,800,100,2200]);
//HightScoreList newList = new (new () {100,200,300,400,500,7700,800,100,2200});

newList.Scores();
Console.WriteLine($"Latest:   {newList.Latest()}");
Console.WriteLine($"TopScore: {newList.TopScore()}");
newList.TopThree().ForEach(Console.WriteLine);


class HightScoreList(List<int> scoreList)
{
    private List<int> ScoreList = scoreList;

    /*
    class HightScoreList 
{
    private List<int> ScoreList;
    public HightScoreList ( List<int> scoreList)
    {
        this.ScoreList = scoreList;
    }
     */

    public List<int> Scores()
    {
        System.Console.WriteLine("Score List: ");
        ScoreList.ForEach(Console.WriteLine);
        return ScoreList;  
    }
    public int Latest() => ScoreList.Last();
    public int TopScore() => ScoreList.Max();
    public List<int> TopThree() 
    { 
        System.Console.WriteLine("Top 3: ");
        return ScoreList.OrderByDescending(score => score).Take(3).ToList();
    }
}