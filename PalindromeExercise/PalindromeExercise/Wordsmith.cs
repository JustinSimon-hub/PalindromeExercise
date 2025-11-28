using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public bool IsAPalindrome(string word)
        {

            // Normalize the input by removing spaces and converting to lowercase
            string normalizedWord = new string(word.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();
            // Get the reversed version of the normalized word
            char[] charArray = normalizedWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);
            // Check if the normalized word is equal to its reversed version
            return normalizedWord == reversedWord;

        }
    }
}



//Make sure the PalindromeExerciseTests project file has PalindromeExercise added as a reference.  
//→ Right click dependencies in PalindromeExerciseTests to check and add if need be

//Create a class named WordSmith in your PalindromeExercise project file.  This is where you will eventually create your IsAPalindrome() method

//In your WordSmith class, you will create a method (IsAPalindrome) that will take a parameter of type string and return a value of type bool.
//If the given input is a palindrome – return true, else return false. 

//Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file

//Remove the [Fact] portion and replace it with:
//[Theory]
//[InlineData()] ← you will need to put some test data and expected result here.  

//For example [InlineData(“racecar”, true)]

//Finish the test with arrange, act, assert and make your IsAPalindrome method pass the tests
