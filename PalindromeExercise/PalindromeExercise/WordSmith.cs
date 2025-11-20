using System.Linq;
namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        string reversed = new string(word.Reverse().ToArray());
        if (word == reversed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}