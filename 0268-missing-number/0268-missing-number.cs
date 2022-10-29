public class Solution {
    public int MissingNumber(int[] nums) {
        int[] numRange = Enumerable.Range(0, nums.Length+1).ToArray();
        int expectSum = (nums.Length * (nums.Length + 1)) / 2;
        int actualSum = nums.Sum();
        
        return expectSum - actualSum;
    }
}