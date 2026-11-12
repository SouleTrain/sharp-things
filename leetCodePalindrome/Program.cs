using System.Runtime.InteropServices;

public class Solution {
    public bool IsPalindrome(int x) 
    {
        if (x < 0)
        {
            return false;
        }
        int[] digits = x.ToString().Select(c => c - '0').ToArray();
        int left = 0;
        int right = digits.Length - 1;
        while (left < right)
        {
            if (digits[left] != digits[right])
            {
                return false;
            }
            else
            {
                left++;
                right--;    
            }
        }
        return true;
    }
}