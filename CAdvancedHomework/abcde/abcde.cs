using System;
using System.Collections.Generic;
using System.Linq;
   
class abcde
{
    static void Main()
    {
        int beg = Int32.Parse(Console.ReadLine());
        int end = Int32.Parse(Console.ReadLine());
        Dictionary<char, int> letter = new Dictionary<char,int>();
        letter ['a'] = 5;
        letter ['b'] = -12;
        letter ['c'] = 47;
        letter ['d'] = 7;
        letter ['e'] = -32;
        bool noResults = true;
        for (char c1 = 'a'; c1 <= 'e'; c1++)
        {
            for (char c2 = 'a'; c2 <= 'e'; c2++)
            {
                for (char c3 = 'a'; c3 <= 'e'; c3++)
                {
                    for (char c4 = 'a'; c4 <= 'e'; c4++)
                    {
                        for (char c5 = 'a'; c5 <= 'e'; c5++)
                        {
                            string allVariants = ""+c1+c2+c3+c4+c5;
                            string stringValue = "" + c1;
                            foreach (var character in allVariants)
	                        {
	                            if (!stringValue.Contains(character.ToString()))
                                {
                                    stringValue += character;
                                }
	                        }
                            long currentWeight = CountWeight(stringValue, letter);
                            if (currentWeight>=beg && currentWeight<=end)
	                        {
		                        Console.Write(allVariants+" ");
                                noResults = false;
	                        }
                            
                            
                            
                        }
                        
                    }
                    
                }
                
            }
            
        }
        if (noResults)
	    {
		     Console.WriteLine("No");
	    }
    }
    static long CountWeight (string word, Dictionary<char, int> letter)
    {
        long weight = 0;
        int multyplyer = 1;
        foreach (var character in word)
	    {
		    weight += multyplyer * letter[character];
            multyplyer++;
	    }
        return weight;
    }
}

