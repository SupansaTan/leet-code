public class Solution {
    public int[] PlusOne(int[] digits) {
        int length = digits.Length;
        List<int> nums = digits.ToList();
        
        for (int i = length-1; i >= 0; i--)
        {
            if (nums[i] < 9)
            {
                nums[i]++;
                break;
            }
            else
            {
                nums[i] = 0;
                if (i == 0) nums.Insert(0, 1);
            }
        }
        return nums.ToArray();
    }
}