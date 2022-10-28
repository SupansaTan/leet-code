/* 
    buy -> sell
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int profit, maxProfit = 0;
        int left = 0;
        int right = 1;
        
        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                left = right;
            }
            right++;
        }
        return maxProfit;
    }
}