using System.ComponentModel.DataAnnotations;

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
       int counter1 = 0;
       int counter2 = 0;
       for(int i = 0; i < nums.Length; i++)
       {
            if (nums[i] == 1)
            {
                counter1 += 1;
                counter2 = Math.Max(counter2, counter1);
            }

            else
            {
                counter1 = 0;
            }
       }
       return counter2;
    }
}