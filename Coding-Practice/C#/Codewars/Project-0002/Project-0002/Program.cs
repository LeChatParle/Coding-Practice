//2023-01-01
//https://www.codewars.com/kata/5264d2b162488dc400000001/

/*
Write a function that takes in a string of one or more words, and returns the same string, 
but with all five or more letter words reversed (Just like the name of this Kata). 
Strings passed in will consist of only letters and spaces. 
Spaces will be included only when more than one word is present.
 */

using System.Xml;

namespace Project_0002;

public class Kata
{
    private const string myTestString = "My brother is a good person";
    
    public static void Main()
    {
        string[] words = myTestString.Split(" ");
        string newString = "";
        
        //for each word, split into char array
        //if > 4 chars, reverse then add to newString; 
        //otherwise just add to newString

        foreach (string s in words)
        {
            char[] testCharLength = s.ToCharArray();
            
            if (testCharLength.Length > 4)
            {
                Array.Reverse(testCharLength);
                newString += new string(testCharLength) + " ";
            }
            else
            {
                newString += new string(testCharLength) + " ";
            }
            
        }
        newString = newString.Trim();
        Console.WriteLine(newString);

    }
}