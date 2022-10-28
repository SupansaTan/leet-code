/* 
    buy -> sell
*/

public class Solution {
    public int MaxProfit(int[] prices) {
        int dayLength = prices.Length;
        int maxProfit = 0;
        int left = 0;
        int right = 1;
        
        while (right < dayLength)
        {
            if (prices[left] < prices[right])
            {
                int profit = prices[right] - prices[left];
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