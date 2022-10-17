public class Solution {
    public bool CheckIfPangram(string sentence) {
        bool[] alphabet = new bool[26];
        
        foreach (char c in sentence)
        {
            int index = c - 'a';
            alphabet[index] = true;
        }
        
        return !alphabet.Contains(false);
    }
}