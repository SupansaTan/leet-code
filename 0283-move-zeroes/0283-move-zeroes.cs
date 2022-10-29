/*
    0 1 0 3 12 -> index = 0, 
    1 0 0 3 12 -> index = 1
    1 3 0 0 12 -> index = 2, move 3 to index 1, set old index of 3 to 0
    1 3 12 0 0 -> index = 3, move 12 to index 2, set old index of 12 to 0
*/


public class Solution {
    public void MoveZeroes(int[] nums) {
        int moveIndex = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (i != moveIndex)
                {
                    nums[moveIndex] = nums[i];
                    nums[i] = 0;
                }
                moveIndex++;
            }
        }
    }
}