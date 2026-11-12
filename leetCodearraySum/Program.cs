public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        int left = 0;
        int[] solution = new int[2];
        for(int i = 1; i < nums.Length; i++)
        {
            Console.WriteLine($"i = {i}");
            while (left != nums.Length - 1)
            {
                Console.Write("loop started");
                if (nums[left] + nums[i] == target)
                {
                    solution[0] = left;
                    solution[1] = i;
                }
                left++;
                Console.WriteLine($"left now = {left}");
            }
            Console.WriteLine("loop ended");
            left = nums.Length - 1;
        }
        foreach(int num in solution)
        {
            Console.WriteLine(num);
        }
        return solution;
    }

    static void Main()
    {
        var test = new Solution();
        int[] testArray = [3,2,4];
        test.TwoSum(testArray, 6);
    }
}