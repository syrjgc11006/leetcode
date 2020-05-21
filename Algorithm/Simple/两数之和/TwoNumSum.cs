using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple.两数之和
{
    public class TwoNumSum
    {
        /// <summary>
        /// 暴力法，双重循环
        /// 时间复杂度：o(n²) 对于每个元素，我们试图遍历数组中的其余部分来寻找它所对应的目标元素。这将耗费o(n)的时间。因此时间复杂度为 o(n²)
        /// 空间复杂度为：o(1)
        /// </summary>
        /// <param name="inputarray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] OutPutTowSumArrayIndex_Violence(int[] inputarray, int target)
        {
            try
            {
                for (int i = 0; i < inputarray.Length; i++)
                {
                    for (int j = i + 1; j < inputarray.Length; j++)
                    {
                        if (inputarray[i] + inputarray[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
                throw new Exception("can not find target item ");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 两遍hash表
        /// 时间复杂度 o(n)，对于某一个元素，我们只需要查询一次hash表即可，时间复杂度为o(1)，因此总的时间复杂度为o(n)
        /// 
        /// </summary>
        /// <param name="inputarray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] OutPutTowSumArrayIndex_Hash(int[] inputarray, int target)
        {
            Dictionary<int, int> dic_nums = new Dictionary<int, int>();
            for (int i = 0; i < inputarray.Length; i++)
            {
                dic_nums.Add(i, inputarray[i]);
            }

            for (int i = 0; i < inputarray.Length; i++)
            {
                int tempnum = target - inputarray[i];

                if (dic_nums.ContainsValue(tempnum))
                {
                    return new int[] { i, dic_nums.Keys.First(n => dic_nums[n] == tempnum) };
                }
            }
            throw new Exception("can not find target item ");
        }

        /// <summary>
        /// 一遍hash表
        /// </summary>
        /// <param name="inputarray"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] OutPutTowSumArrayIndex_Hash2(int[] inputarray, int target)
        {
            Dictionary<int, int> dic_nums = new Dictionary<int, int>();
            for (int i = 0; i < inputarray.Length; i++)
            {
                int tempnum = target - inputarray[i];
                if (dic_nums.ContainsValue(tempnum))
                {
                    return new int[] { i, dic_nums.Keys.First(n => dic_nums[n] == tempnum) };
                }
                dic_nums.Add(i, inputarray[i]);
            }
            throw new Exception("can not find target item ");
        }
    }
}
