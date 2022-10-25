public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string joinWord1 = String.Join("", word1);
        string joinWord2 = String.Join("", word2);
        
        return joinWord1 == joinWord2;
    }
}