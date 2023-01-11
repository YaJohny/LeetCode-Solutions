namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int number in TwoSum(new int[] { 2, 7, 11, 15, }, 9))
            {
                Console.WriteLine(number);
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
    }
}