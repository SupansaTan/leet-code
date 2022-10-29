public class Solution {
    public int MissingNumber(int[] nums) {
        int[] numRange = Enumerable.Range(0, nums.Length+1).ToArray();
        
        foreach (int num in numRange)
        {
            if (!nums.Contains(num))
            {
                return num;
            }
        }
        return 0;
    }
}