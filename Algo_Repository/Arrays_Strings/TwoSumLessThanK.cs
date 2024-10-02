using System;
using System.Text;

class Program
{
    
    public static int TwoSumLessThanK(int[] nums, int k)
    {

        Array.Sort(nums);

        int i = 0;
        int j = nums.Length - 1;
        int max = -1;
        while (i < j)
        {
            int sum = nums[i] + nums[j];
            if (sum < k)
            {
                max = Math.Max(sum, max);
                i++;
            }
            else
            {
                j--;
            }

        }
      return max;

    }
    

    static void Main()
    {
        // example usage
        int[] nums = new int[] { 10,20,30 };
        TwoSumLessThanK(nums, 15);
    }
}
