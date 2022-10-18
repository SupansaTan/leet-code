/*
  n = 1;   1
  n = 2;   1 -> 11
  n = 3;   11 -> 21
  n = 4;   21 -> 1211
  n = 5;   1211 -> 111221
*/

public class Solution {
    public string CountAndSay(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        return count(CountAndSay(n-1));
    }
    
    public string count(string say)
    {
        string countStr = "";
        int sayLength = say.Length;
        int count = 1;
        
        for (int i = 0; i < sayLength; i++)
        {
            if (i == sayLength - 1)
            {
                countStr += $"{count}{say[i]}";
            }
            else if (say[i+1] != say[i])
            {
                countStr += $"{count}{say[i]}";
                count = 1;
            }
            else
            {
                count++;
            }
        }
        return countStr;
    }
}