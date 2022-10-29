public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i+=2)
        {
            if (nums[i] != nums[i-1])
            {
                return nums[i-1];
            }
        }
        return nums[nums.Length-1];
    }
}