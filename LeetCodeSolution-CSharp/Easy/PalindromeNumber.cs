using System.Linq;

namespace LeetCodeSolution_CSharp.Easy;

public class PalindromeNumber
{
    public bool IsPalindrome(int num)
    {
        var charArray = num.ToString().ToCharArray();
        var length = charArray.Length;
        for (var i = 0; i < length / 2; i++)
        {
            if (charArray[i] != charArray[length - i - 1])
                return false;
        }

        return true;
    }
}