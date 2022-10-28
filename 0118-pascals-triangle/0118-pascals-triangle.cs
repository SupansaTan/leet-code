/*
    n = 3 -> [1, 2, 1]
    n = 4 -> [1, 3, 3, 1]
        curr[0] = prev[0]
        curr[1] = prev[0] + prev[1]
        curr[2] = prev[1] + prev[2]
        curr[3] = prev[2]
*/

public class Solution {
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> rowList = new List<IList<int>>();
        List<int> firstItem = new List<int>(new int[1]);
        
        firstItem[0] = 1;
        rowList.Add(firstItem);
        
        if (numRows == 1)
        {
            return (IList<IList<int>>)rowList;
        }
        
        for (int i = 1; i < numRows; i++)
        {
            rowList.Add(getRow(i+1, rowList[i-1]));
        }
        return rowList;
    }
    
    public List<int> getRow(int row, IList<int> prevRow)
    {
        List<int> numList = new List<int>(new int[row]);
        numList[0] = 1;
        numList[row-1] = 1;
        
        if (row <= 2)
        {
            return numList;
        }
        
        for (int i = 1; i < (row - 1); i++)
        {
            numList[i] = prevRow[i-1] + prevRow[i];
        }
        return numList;
    }
}