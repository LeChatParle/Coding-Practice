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
		
		compareArrayToHSK(HSKListSplit, ListToBeCompared);
		
		
		
		
		
		
		
		
		
		//compareArrayToHSK();
		
		//File.WriteAllLines(@"writeText.txt", charactersToBeWrittenToFile);
		
		//Console.WriteLine(nonEnglish);

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
		
		foreach (string s in nonEnglish) {
			
			foreach (char c in s)
			{
				charactersSplitIntoCharArray.Add(c);
				//Console.WriteLine("This is a character: {0}", c);
			}
		}
		
		return charactersSplitIntoCharArray;
	}
	
	//Method #2
	private static void compareArrayToHSK(List<char> HSK, List<char> nonHSK) {
		
		List<char> nonHSKCharactersButNotUnique = new List<char>();
		
		foreach (char c in nonHSK)
		{
			if (!(HSK.Contains(c))) {
				Console.WriteLine("Yes, and the cool character is {0}", c);
				nonHSKCharactersButNotUnique.Add(c);
			} 
		}
		
	}
	
	private static void writeUniqueHanzi2TextFile() {
		//make sure to check if char was already written
	}

}