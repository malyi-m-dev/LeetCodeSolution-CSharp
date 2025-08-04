using System;
using System.Collections.Generic;

namespace LeetCodeSolution_CSharp.Easy;

public class TwoSum
{
    public int[] Main(int[] nums, int target)
    {
        Dictionary<int, int> map = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        return Array.Empty<int>();
    }
}