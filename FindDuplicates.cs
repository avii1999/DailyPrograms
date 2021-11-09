static int FindDuplicateByFrequency()
        {
            int[] arr = new[] {2,5,9,6,9,3,8,9,7,1};
            int[] frequency = new int[arr.Length - 1];
            int l = arr.Length - 1;
            
            foreach (int x in arr)
            {
                if (frequency[x - 1] == 1)
                    return x;
                frequency[x - 1]++;
            }
            return -1;
        }
        //By Tortoise Method
        static int FindDuplicateByTortoise()
        {
            int[] arr = new[] {2,5,9,6,9,3,8,9,7,1};
            int fast = arr[0];
            int slow = arr[0];
            do
            {
                slow = arr[slow];
                fast = arr[arr[fast]];
            } while (fast!=slow);

            slow = arr[0];
            while (slow!=fast)
            {
                slow = arr[slow];
                fast = arr[fast];
            }
            return fast;
        }
