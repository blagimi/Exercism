School newSchool = new();

newSchool.AddToList("Barb",1);
newSchool.AddToList("Charlie",1);
newSchool.AddToList("Alex",2);
newSchool.AddToList("Peter",2);
newSchool.AddToList("Zoe",2);
newSchool.AddToList("Alla",1);
newSchool.AddToList("Jim",5);
newSchool.SortByGrade(1);
newSchool.Sorting();
newSchool.ShowList();
public class School ()
{
    public Dictionary<string,int> gradeList = new()
    {
        {"Anna", 1}
    };
    public  Dictionary<string,int> AddToList(string name,int grade)
    {
        gradeList.Add(name,grade);
        return gradeList;
    }
    public void ShowList()
    {
        gradeList.ToList().ForEach(A => Console.WriteLine(A.Key + " : " + A.Value + " grade"));
    }
    public void SortByGrade(int grade) 
    {
        System.Console.WriteLine("~~~~~ Sorting by grade ~~~~~");
        foreach (var item in gradeList)
        if (item.Value == grade)
        {
            var output = item.Value; 
            System.Console.WriteLine(item.Key); 
        }
        System.Console.WriteLine("~~~~~ Sorting by grade ended ~~~~~");     
    }
     public void Sorting() 
    {
        System.Console.WriteLine("~~~~~ Sorting by order ~~~~~");
        var output = gradeList.OrderBy(s => s.Value).ThenBy(s => s.Key).Select(s => s.Key); 
        foreach (var item in output)
        {        
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("~~~~~ Sorting by order ended ~~~~~"); 
        
    }

/*    public void sortGrade() 
    {
        var output = String.Join(", ", gradeList.Select(res => "Kid with name " + res.Key + ": Grade = " + res.Value));
        Console.WriteLine(output);
    }  
    */
}