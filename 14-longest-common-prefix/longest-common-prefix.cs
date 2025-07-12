public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
        {
            return "";
        }
        int commonPrefixLength = strs[0].Length;
        for (int i = 1; i < strs.Length; i++)
        {
            int j = 0;
            while (j < strs[i].Length && j < commonPrefixLength && strs[i][j] == strs[0][j])
            {
                j++;
            }
            commonPrefixLength = Math.Min(commonPrefixLength, j);
            if (commonPrefixLength == 0)
            {
                return "";
            }
        }
        return strs[0].Substring(0, commonPrefixLength);
    }   
}