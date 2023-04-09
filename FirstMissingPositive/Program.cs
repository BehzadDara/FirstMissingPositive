﻿#region Problem
/*
Given an unsorted integer array nums, return the smallest missing positive integer.

You must implement an algorithm that runs in O(n) time and uses constant extra space.

Example 1:
Input: nums = [1,2,0]
Output: 3
Explanation: The numbers in the range [1,2] are all in the array.

Example 2:
Input: nums = [3,4,-1,1]
Output: 2
Explanation: 1 is in the array but 2 is missing.

Example 3:
Input: nums = [7,8,9,11,12]
Output: 1
Explanation: The smallest positive integer 1 is missing.

LeetCode link: https://leetcode.com/problems/first-missing-positive/
*/
#endregion

#region Solution

Console.WriteLine(FirstMissingPositive(new int[] { 7,8,9,11,12 }));
int FirstMissingPositive(int[] nums)
{
    var areNumbersExist = new bool[nums.Length];

    foreach (var num in nums.Where(x => x > 0 && x <= nums.Length))
        areNumbersExist[num - 1] = true;

    foreach (var isNumberExist in areNumbersExist.Select((value, index) => new { index, value }))
    {
        if (!isNumberExist.value)
            return isNumberExist.index;
    }
    return nums.Length + 1;
}

#endregion