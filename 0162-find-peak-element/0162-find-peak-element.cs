public class Solution {
    public int FindPeakElement(int[] nums) {
        int index = 0;
        int arrLength = nums.Length;
        int peakElementIndex = 0;
        
        while (index < arrLength - 1)
        {
            if (nums[index] > nums[index+1] && nums[index] > nums[peakElementIndex])
            {
                peakElementIndex = index;
                index += 2;
            }
            else
            {
                index++;
            }
        }
        
        if (nums[arrLength - 1] > nums[peakElementIndex])
        {
            peakElementIndex = arrLength - 1;
        }
        return peakElementIndex;
    }
}