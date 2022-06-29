using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ScrabbleScore.Models;


namespace ScrabbleScore.Tests
{
  [TestClass]
  public class LetterTests
  {
    [TestMethod]
    public void LetterConstructor_CreatesInstanceOfLetter_Letter()
    {
      Letter newLetter = new Letter();
      Assert.AreEqual(typeof(Letter), newLetter.GetType());
    }

    [TestMethod]
    public void GetKey_CreatesKeyValuePairs_True()
    {
      Letter newLetter = new Letter();
      Assert.AreEqual(1, newLetter.GetKey('A'));
    }

   //     [TestMethod]
   // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
   // {
   //   // any necessary logic to prep for test; instantiating new classes, etc.
   //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
   // }
  }
}