// List of allergy with numeric score       / Done
// input number to show allergen or all allergens 
// if input more than 256 show first (1)    / Done

AllergiesScore score = new(34);
//Console.WriteLine(score.List());
[Flags]
public enum Allergen
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    }

public class AllergiesScore
{

    private readonly Allergen allergenList;
    public AllergiesScore(int inputScore)
    {
        if (inputScore >= 256)
            {
                allergenList = Allergen.Eggs;
            }
        else 
            {             
            allergenList = (Allergen)inputScore;
            }
        Console.WriteLine(allergenList);
    }

    /*
    public bool IsAllergicTo (Allergen allergen)
    {
        return allergenList.HasFlag(allergen);
    }
    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(al => IsAllergicTo(al)).ToArray();
    }
    */
} 