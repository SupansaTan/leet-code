/*
    n:   0 1 2 3 4 5 6 7 8
    out: 0 1 1 2 1 2 2 3 1
    
    - power 1 -
    out[2] = out[0] + 1 => out[2-2] + 1
    out[3] = out[1] + 1 => out[3-2] + 1
    
    - power 2 -
    out[4] = out[0] + 1 => out[4-4] + 1
    out[5] = out[1] + 1 => out[5-4] + 1
    out[6] = out[2] + 1 => out[6-4] + 1
    out[7] = out[3] + 1 => out[7-4] + 1
    
    - power 3 -
    out[8] = out[0] + 1 => out[8-8] + 1
*/

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