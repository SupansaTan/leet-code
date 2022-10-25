/*
    n = (n - 1) + (n - 2)
    
    n = 1 -> 1
    n = 2 -> 2
    n = 3 -> 3
    
    n = 4 -> 3  -> n(3) + n(2)
    n = 5 -> 6  -> n(4) + n(3)
    n = 6 -> 9  -> n(5) + n(4)
*/

public class Solution {
    public int ClimbStairs(int n) {
        // base case
        if (n <= 3)
        {
            return n;
        }
        
        int[] steps = new int[n+1];
        steps[1] = 1;
        steps[2] = 2;
        steps[3] = 3;
        
        for (int i = 4; i < n + 1; i++)
        {
            steps[i] = steps[i-1] + steps[i-2];
        }
        return steps[n];
    }
}