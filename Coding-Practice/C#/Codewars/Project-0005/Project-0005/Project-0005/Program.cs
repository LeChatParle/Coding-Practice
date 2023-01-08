using System.Collections;

public class Persist { 
	
	static int n = 999;
	static int Main() {
		
		List<int> splitNumbers = new List<int>();
		int intermediateNumber = 0;

		//splits one number off right side
		//then makes n the new number
		while (n >= 9) {
			splitNumbers.Add(n % 10);
			Console.WriteLine("The list is ");
			n = n / 10;
			Console.WriteLine(n);
		}

		foreach (int i in splitNumbers) {
			Console.WriteLine("i is " + i);
			intermediateNumber = intermediateNumber * i;
			Console.WriteLine("intermediate is " + intermediateNumber);
		}
      
		//recursion
		if (!(intermediateNumber <= 9)) {      
			Main();
		} else {
			Console.WriteLine(intermediateNumber);
			return intermediateNumber;
		}
			

		return 0;
	}
}