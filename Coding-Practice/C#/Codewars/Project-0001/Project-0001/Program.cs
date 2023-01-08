//2022-12-31 - Jeremy Edwards

/*
Given a string of words, you need to find the highest scoring word.
Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
You need to return the highest scoring word as a string.
If two words score the same, return the word that appears earliest in the original string.
All letters will be lowercase and all inputs will be valid.
*/

public class Kata
{
    private const string S = "this is a test sentence";
    
    public static void Main()
    {
        string[] words = S.Split(' ');
        Dictionary<string, int> wordAndScore = new Dictionary<string, int>();
    
        foreach (string i in words) 
        {//split the word into char array, then count word and put into int array
            char[] wordToBeCounted = i.ToCharArray();
            if (!wordAndScore.ContainsKey(i))
            {
                wordAndScore.Add(i, countChars(wordToBeCounted));
            }
        }
    
        //next, pick the highest score in Dictionary
        Console.WriteLine(wordAndScore.Aggregate((x, y) => x.Value > y.Value ? x : y).Key);
        //return wordAndScore.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
    }

    static int countChars(char[] t) 
    {
        int addedScore = 0;
        foreach (char c in t) { addedScore += c - 96;}
        return addedScore;
    }
}
