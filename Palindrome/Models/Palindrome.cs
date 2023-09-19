using System;
using System.Linq;

namespace PalindromeChecker.Models
{
  public class Palindrome
  {
    public string Pal { get; set; }
  

    public Palindrome(string userInput)
    {
      Pal = userInput.ToLower();
      
    }

    // create and return an array containing each character of user's string
    public char[] UserArray()
    {
      char[] charArray = Pal.ToCharArray();
      return charArray;
    }
    // create and return an array containing each character of user's string, in reversed order
    public char[] ReverseArray()
    {
      char[] charArray = this.UserArray();
      Array.Reverse(charArray);
      return charArray;
    }

    public bool CheckArray()
    {
      char[] userInputArray = this.UserArray();
      char[] revUserInputArray = this.ReverseArray();
      bool compareArrays = userInputArray.SequenceEqual(revUserInputArray);
      if (compareArrays == true)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  }
}

