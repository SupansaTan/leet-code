public class Solution {
    public int MajorityElement(int[] nums) {
        int maxAppear = 1;
        int maxAppearElement = nums[0];
        int count = 1;
        
        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i-1])
            {
                count++;
                if (i == (nums.Length - 1) && count > maxAppear)
                {
                    maxAppearElement = nums[i];
                }
            }
            else
            {
                if (count > maxAppear)
                {
                    maxAppear = count;
                    maxAppearElement = nums[i-1];
                }
                count = 1;
            }
        }
        return maxAppearElement;
    }
}