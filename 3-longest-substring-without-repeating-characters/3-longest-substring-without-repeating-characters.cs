public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastPos = new Dictionary<char, int>();
        int maxLength = 0;
        
        for (int start = 0, end = 0; end < s.Length; end++)
        {
            // already found the element -> move start pointer
            if (lastPos.ContainsKey(s[end]))
            {
                start = Math.Max(start, lastPos[s[end]] + 1);
            }
            
            // update last position & max length
            maxLength = Math.Max(maxLength, end - start + 1);
            lastPos[s[end]] = end;
        }
        return maxLength;
    }
}