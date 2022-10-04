public class Solution {
    public int FirstUniqChar(string s) {
        int[] count = new int[26];
        int length = s.Length;
        
        // count char --> O(N)
        for (int i = 0; i < length; i++)
        {
            int index = (int)(s[i]- 'a');
            count[index]++;
        }
        
        // find index --> O(26)
        for (int i = 0; i < length; i++)
        {
            int index = (int)(s[i]- 'a');
            if (count[index] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}