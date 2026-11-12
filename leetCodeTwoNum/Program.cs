public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int left = 0;
        int right = 1;
        int[] solution = new int[2];
        while (true)
        {
            if (nums.Length == 2)
            {
                solution[0] = nums[0];
                solution[1] = nums[1];
            }
            if (nums[left] + nums[right] == target)
            {
                solution[0] = left;
                solution[1] = right;
                break;
            }
            if (right == nums.Length - 1 && nums[left] + nums[right] != target)
            {
                left++;
                right = left + 1;
            }
            else
            {
                right++;
            }
        }
        return solution;
    }
}