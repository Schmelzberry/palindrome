using System;

namespace PalindromeChecker.Models
{
  public class Palindrome
  {
    public string Pal { get; set; }
  

    public Palindrome(string userInput)
    {
      Pal = userInput;
    }

    public char[] UserArray()
    {
      return Pal.ToCharArray();
    }
  }
}

