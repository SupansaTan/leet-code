public class Solution {
    public int SingleNumber(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums.Where(x => x == nums[i]).ToArray().Length == 1)
            {
                return nums[i];
            }
        }
        return 0;
    }
}