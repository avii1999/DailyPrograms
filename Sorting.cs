int[] SortArray(int[] arr)
        {
            int mid;
            int low = mid = 0;
            int high = arr.Length-1;

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                    {
                        swapMyNumbers(ref arr[low++],ref arr[mid++]);
                        break;
                    }
                    case 1:
                        mid++;
                        break;
                    case 2:
                    {
                        swapMyNumbers(ref arr[mid], ref arr[high--]);
                        break;
                    }
                }
            }
            return arr;
        }
        private void swapMyNumbers(ref int x, ref int y)
        {
            (x, y) = (y, x);
        }
