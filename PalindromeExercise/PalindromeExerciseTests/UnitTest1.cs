using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("noon", true)]
        [InlineData("level", true)]
        [InlineData("salaire", false)]
        [InlineData("Ca va aller", false)]
        [InlineData("radar", true)]
        [InlineData("madam", true)]
        [InlineData("refer", true)]
        
        public void Test1( string word, bool expected)
        {
            var Palindrome = new WordSmith();
            var actual = Palindrome.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
