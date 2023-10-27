using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsAnagram("hola", "aloh")); 
        Console.WriteLine(solution.SwapCharacters("CardioloGo", 0, 8));
        Console.WriteLine(solution.ReverseWords("Campus programmers"));
        Console.WriteLine(solution.IsPalindrome("Oro"));
        Console.WriteLine(solution.ReverseString("campus"));
        Console.WriteLine(solution.CountVowels("campus"));       
    }
}

public class Solution
{
    public bool IsAnagram(string input1, string input2)
    {
        input1 = new string(input1.OrderBy(c => c).ToArray());
        input2 = String.Concat(input2.OrderBy(c => c));
        return input1 == input2;
    }

    public string  SwapCharacters(string input, int index1, int index2) 
{
    StringBuilder inputString = new StringBuilder(input);
    char temp =  inputString[index1];
    inputString[index1] = inputString[index2];
    inputString[index2] = temp;
    return inputString.ToString();  

}

    public string ReverseWords(string sentence)
{
    string[] reverseSentence = sentence.Split(" ");     
    for (int i = 0; i < reverseSentence.Count(); i++)
    {
        reverseSentence[i] = new string( reverseSentence[i].ToCharArray().Reverse().ToArray());
    }

    return String.Join(" ",reverseSentence);
     
}

    public bool IsPalindrome(string input) 
{
        
    char[] letters = input.ToLower().ToCharArray();
    var filteredString = new string(letters.Where(c => !char.IsPunctuation(c) && !char.IsWhiteSpace(c)).ToArray());
    var ReversedString = new string(filteredString.Reverse().ToArray());
    return filteredString == ReversedString;
}

 public string ReverseString(string input)
    {
        // Your code here
        char[] letters = input.ToCharArray();
        int longitude = letters.Length;  
        int corte = longitude % 2 == 0 ? longitude / 2 : (longitude + 1) / 2;
        for(int i = longitude - 1; i > corte - 1; i--)
        {
            char a = letters[(longitude - 1) - i];
            letters[longitude - (i + 1)] = letters[i];
            letters[i] = a;
        }
        return new string(letters);
    }

    public int CountVowels(string input) {
        int total = 0;
        var vowelSet = new HashSet<char>{'a','e','i','o','u'}; 
        for(int i = 0; i<input.Length; i++)
        {
            foreach(char vowel in vowelSet)
            {
                if(input[i].ToString().ToLower() == vowel.ToString())
                {
                    total++;
                }

            }
        }
        return total;
    }    
}
// algoritmo de dijkstra
/*
    cabeza
    cola
    informacion
    estado
*/
// - teoria computacional
    
//plural linq
//clean ariquitecture