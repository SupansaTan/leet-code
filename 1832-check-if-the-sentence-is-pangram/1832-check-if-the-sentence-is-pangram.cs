public class Solution {
    public bool CheckIfPangram(string sentence) {
        bool[] alphabet = new bool[26];
        
        for (int i = 0; i < 26; i++)
        {
            char currentChar = (char)('a' + i);
            if (sentence.Contains(currentChar))
            {
                alphabet[i] = true;
            }
            else
            {
                // not found some char
                return false;
            }
        }
        
        return true;
    }
}