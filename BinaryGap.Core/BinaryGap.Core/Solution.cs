namespace BinaryGap.Core
{
    using System;

    public class Solution
    {
        public int BinaryGap(int n)
        {
            var binary = Convert.ToString(n, 2).Trim('0');
            var gaps = binary.Split('1');
            Array.Sort(gaps);
            return gaps[gaps.Length-1].Length;
        }
    }
}
