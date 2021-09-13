using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // bubble sort
    // Selection sort
    // Insertion sort
    // Merge Sort
    // quick sort
    // quick select
    // heap sort
    class Sort
    {
        internal void BubbleSort(List<int> nums)
        {

            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = 0; j < nums.Count - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

        }

        internal void SelectionSort(List<int> nums)
        {
            for(int i = 0; i < nums.Count - 1; i++)
            {
                // find the least val
                int minidx = i;
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[j] < nums[minidx]) minidx = j;
                }

                if (nums[i] > nums[minidx])
                {
                    var temp = nums[minidx];
                    nums[minidx] = nums[i];
                    nums[i] = temp;
                }
            }
        }

        internal void InsertionSort(List<int> nums)
        {
            for (int i = 1; i < nums.Count; i++)
            {
                var insert = nums[i];
                var idx = i - 1;
                while(idx >= 0 && nums[idx] > insert)
                {
                    nums[idx + 1] = nums[idx];
                    idx--;
                }
                nums[idx + 1] = insert;
            }
        }

        internal List<int> MergeSort(List<int> nums)
        {
            int len = nums.Count;
            if (len <= 1) return nums;

            var start = 0;
            var end = len - 1;
            var mid = (start + end) / 2;

            var left = this.MergeSort(nums.GetRange(0, mid + 1));
            var right = this.MergeSort(nums.GetRange(mid + 1, len - mid - 1));

            return this.Combine(left, right);
        }

        private List<int> Combine(List<int> leftlst, List<int> rightlst)
        {
            int idxl = 0;
            int idxr = 0;
            List<int> res = new List<int>();
            while (idxl < leftlst.Count && idxr < rightlst.Count)
            {
                if (leftlst[idxl] <= rightlst[idxr])
                {
                    res.Add(leftlst[idxl]);
                    idxl++;
                }
                else
                {
                    res.Add(rightlst[idxr]);
                    idxr++;
                }
            }

            if (idxl == leftlst.Count)
            {
                for (int j = idxr; j < rightlst.Count; j++) res.Add(rightlst[j]);
            }
            else
            {
                for (int i = idxl; i < leftlst.Count; i++) res.Add(leftlst[i]);
            }

            return res;
        }

        internal void QuickSort(List<int> nums)
        {
            if (nums.Count > 1)
            {
                QSHelper(nums, 0, nums.Count - 1);
            }
        }

        private void QSHelper(List<int> nums, int left, int right)
        {
            if (left >= right) return;
            int start = left, end = right;
            int pivot = nums[(start + end) / 2];

            while (start <= end)
            {
                while (start <= end && nums[start] < pivot) start++;
                while (start <= end && nums[end] > pivot) end--;

                if(start <= end)
                {
                    int temp = nums[end];
                    nums[end] = nums[start];
                    nums[start] = temp;

                    start++;
                    end--;
                }
            }

            QSHelper(nums, left, end);
            QSHelper(nums, start, right);

        }

        internal void QuickSelect(List<int> nums)
        {
        }


    }
}
