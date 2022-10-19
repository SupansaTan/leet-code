public class Solution {
    public int[] CountBits(int n) {
        // base case
        if (n == 0) return new int[1];
        
        int[] count = new int[n+1];
        int pow = 1;
        for (int i = 1; i < n+1; i++)
        {
            if (i == pow * 2)
            {
                pow *= 2;
            }
            count[i] = count[i-pow] + 1;
        }
        return count;
    }
}