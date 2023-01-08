//2022-12-31
//This file is to keep reminders of things I've learned

using System;

public class Program
{
    public static void Main()
    {
        Program myConsoleApp = new Program();
        
        myConsoleApp.textBasedKnowledge();
    }
    
    public void textBasedKnowledge() {
        //letters are automatically converted to numbers when addition or subtraction are done on them
        Console.WriteLine('A' - 64); // Returns 1
        Console.WriteLine('a' - 96); // Returns 1d
        
        //you can just used curly braces with an index number if you put the values ...
        //separated by commas at the end
        string test1 = "test1";
        string test2 = "test2";
        
        Console.WriteLine("This is: {0} and {1}", test1, test2);
    }
    
}

