using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        int[] vysledok = { i, j };
                        return vysledok;
                    }
                }

            }
            int[] nenaslo = { -1 };
            return nenaslo;
        }
    }
}
