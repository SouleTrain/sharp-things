public class Solution {
    public int[] Shuffle(int[] nums, int n) 
    {
        int counter = 0;
        int[] answerShuffle = new int[n * 2];
        for(int i=0; i<answerShuffle.Length; i+=2)
        {
            answerShuffle[i] = nums[counter];
            answerShuffle[i + 1] = nums[n];
            n++;
            counter++;
        }
        return answerShuffle;
    }
}
