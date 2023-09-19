using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker.Models;
using System;

// ! NOTE:
// NAME CONVENTION FOR TESTS:
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//    Arrange
//    Act
//    Assert
// }

namespace PalindromeChecker.Tests
{
  [TestClass] 
  public class PalindromeTests
  {
    [TestMethod] 
    public void PalindromeConstructor_CreatesInstanceOfPalindrome_Palindrome()
    {
      // arrange & act
      Palindrome checkPalindrome = new Palindrome("string");
      // assert
      Assert.AreEqual(typeof(Palindrome), checkPalindrome.GetType());
    }

    [TestMethod]
    public void GetPal_ReturnPal_String()
    {
      //arrange
      string userInput = "string";
      Palindrome newPal = new Palindrome("string");
      //act
      string result = newPal.Pal;
      //assert
      Assert.AreEqual(result, userInput);
    }

    [TestMethod]
    public void UserArray_TransformUserStringIntoArray_Array()
    {
      //arrange 
      string userInput = "string";
      Palindrome newPal = new Palindrome("string");

      //act
      char[] pals = userInput.ToCharArray();
      char[] result = newPal.UserArray();
      //assert
      Assert.AreEqual(pals, result);
    }
  }
}
