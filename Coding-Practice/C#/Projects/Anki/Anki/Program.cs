using System;
using System.IO;
using System.Collections.Generic;  
using System.Linq; 
using System.Text;  
using System.Text.RegularExpressions;  

public class checkForUniqueCharacters {

	public static void Main() {
		
		List<char> HSKListSplit = new List<char>(splitIntoArrayOfHanzi("HSK.txt"));
		List<char> ListToBeCompared = new List<char>(splitIntoArrayOfHanzi("test.txt"));
		List<char> ListOfNonHSKChars = new List<char> (compareArrayToHSK(HSKListSplit, ListToBeCompared));
		
		writeUniqueHanzi2TextFile(ListOfNonHSKChars);

	}
	
	//Method #1
	private static List<char> splitIntoArrayOfHanzi(string fileLocation) {
		string nonEnglishCharsPattern = "[^\x0000-\x036F]+";
		string textToBeChecked = System.IO.File.ReadAllText(@fileLocation);
		List<string> nonEnglish = new List<string>();
		List<char> charactersSplitIntoCharArray = new List<char>();
		
		nonEnglish = Regex	.Matches(textToBeChecked, nonEnglishCharsPattern)
							.OfType<Match>()
							.Select(m => m.Groups[0].Value)
							.ToList();
		
		foreach (string s in nonEnglish)
		{
			foreach (char c in s)
			{
				charactersSplitIntoCharArray.Add(c);
			}
		}
		
		return charactersSplitIntoCharArray;
	}
	
	//Method #2
	private static List<char> compareArrayToHSK(List<char> HSK, List<char> nonHSK) {
		
		List<char> nonHSKCharactersButNotUnique = new List<char>();
		
		foreach (char c in nonHSK)
		{
			if (!(HSK.Contains(c))) {
				Console.WriteLine("Yes, and the cool character is {0}", c);
				nonHSKCharactersButNotUnique.Add(c);
			} 
		}
		
		return nonHSKCharactersButNotUnique;
		
	}
	
	//Method #3
	private static void writeUniqueHanzi2TextFile(List<char> ListToPrint) {
		
		List<char> CheckThisListForDuplicatesThenWriteToFile = new List<char> ();
		
		//Check for duplicates
		foreach (char c in ListToPrint)
		{
			if (!(CheckThisListForDuplicatesThenWriteToFile.Contains(c)))
			{
				CheckThisListForDuplicatesThenWriteToFile.Add(c);
			}
		}
		
		//Write to file
		using (StreamWriter writer = new StreamWriter("writeText.txt"))
		{
			foreach (char c in CheckThisListForDuplicatesThenWriteToFile)
			{
				writer.Write(c);
			}
		}
	}
}