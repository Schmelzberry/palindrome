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
      CollectionAssert.AreEqual(pals, result);
    }

    [TestMethod]
    public void ReverseArray_ReversesUserArray_Array()
    {
      // arrange
      char[] expectedArray = {'g','n','i','r','t','s'};
      Palindrome newPal = new Palindrome("string");
      // act
      char[] result = newPal.ReverseArray();
      // assert
      CollectionAssert.AreEqual(expectedArray, result);
    }
    
    [TestMethod]
    public void ReverseArray_ReversesUserArrayWithUpper_Array()
    {
      // arrange
      char[] expectedArray = {'g','n','i','r','t','s'};
      Palindrome newPal = new Palindrome("String");
      // act
      char[] result = newPal.ReverseArray();
      // assert
      CollectionAssert.AreEqual(expectedArray, result);
    }

    [TestMethod]
    public void CheckArray_CompareUserArrayWithReverseUserArrayTrue_Bool()
    {
      //arrange 
      Palindrome newPal = new Palindrome("tacocat");
      //act
      bool arrayCheck = newPal.CheckArray();
      //assert
      Assert.AreEqual(arrayCheck, true);
    }

    [TestMethod]
    public void CheckArray_CompareUserArrayWithReverseUserArrayFalse_Bool()
    {
      //arrange 
      Palindrome newPal = new Palindrome("notreal");
      //act
      bool arrayCheck = newPal.CheckArray();
      //assert
      Assert.AreEqual(arrayCheck, false);
    }
  }
}
