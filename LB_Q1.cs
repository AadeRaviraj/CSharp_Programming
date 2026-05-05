using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice
{
    internal class LB_Q1
    {
      public List<int> add()
        {
            // Given an array nums and integer target, return indices of two numbers such that they add up to target. 
            // 
            //nums = { 6,4,2, 7, 11, 15,3,60,33,5,7,3}
            // target = 10
            // Output: [0, 1]

            int[] nums = { 6,4,2, 7, 11, 15,3,60,33,5,7,3};
            int target = 10, temp;
            List<int> result = new List<int>();
             
            Dictionary<int, int> dict = new Dictionary<int, int>();

           

            for(int i = 0; i< nums.Length; i++)
            {

                temp = target - nums[i];

                if (dict.ContainsKey(temp))
                {
                    result.Add(dict[temp]);
                    result.Add(i);
                    break;
                }
                dict[nums[i]] = i;

             
            }

            return result;
        }
    }
}
