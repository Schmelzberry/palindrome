using PalindromeChecker.Models;
using System;

namespace PalindromeChecker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Palindrome checker! You guessed it, we check for palindromes.");
      Console.WriteLine("Please enter a word you want to check:");
      string newUser = Console.ReadLine();
      Palindrome newPal = new Palindrome(newUser);
      bool result = newPal.CheckArray();
    //  Console.WriteLine(result);
      if (result) 
      {
      Console.WriteLine("That's definitely a palindrome!");
      }
      else
      {
      Console.WriteLine("That's not a palindrome. What are you thinking, you idiot sandwich?");
      }
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Do you want to try another possible palindrome?");
      Console.WriteLine("Enter 'yes' to go again, otherwise enter any key to exit.");
      string otherUser = Console.ReadLine();
      if (otherUser.ToLower() == "yes")
      {
      Main();
      }
      else
      {
      Console.WriteLine("Later skater.");
      }
    }
  }
}