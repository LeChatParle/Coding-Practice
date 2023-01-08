public class DNAStrand 
{
	public static void Main()
	{
		string dna = "GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA";
		char[] DNA_Array = dna.ToCharArray();
		string complement = "";
          
		foreach (char c in DNA_Array) {
            
			switch (c) {
				case 'A': 
					complement += "T";
					break;
				case 'T': 
					complement += "A";
					break;
				case 'C': 
					complement += "G";
					break;
				case 'G': 
					complement += "C";
					break;
			} 
		}
          
		Console.WriteLine(complement);
	}
}