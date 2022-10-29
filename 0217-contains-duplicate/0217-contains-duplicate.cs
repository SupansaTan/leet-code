public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numsNonDuplicate = new HashSet<int>(nums);
        
        if (numsNonDuplicate.Count < nums.Length)
        {
            return true;
        }
        return false;
    }
}
    