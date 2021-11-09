public static int[] TwoSum(int[] nums, int target)
        {
            // Find the target by adding sum of two elements in the array
            int l = nums.Length;
            for (int i = 0; i < l; i++)
            {
                for (int j = i + 1; j < l; j++)
                {
                    if (i + j == target)
                        return new[] {i, j};
                }
            }
            return Array.Empty<int>();
        }
