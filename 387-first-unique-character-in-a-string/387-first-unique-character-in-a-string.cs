public class Solution {
    public int FirstUniqChar(string s) {
        for (int i = 0; i < s.Length; i++)
        {
            if (s.IndexOf(s[i], s.IndexOf(s[i]) + 1) == -1) {
                return i;
            }
        }
        return -1;
    }
}