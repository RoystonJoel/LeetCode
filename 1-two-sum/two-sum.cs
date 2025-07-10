public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> num_map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (num_map.ContainsKey(complement)) {
                return new int[] { num_map[complement], i };
            }
            num_map[nums[i]] = i;
        }
        return new int[] {}; 
    }
}