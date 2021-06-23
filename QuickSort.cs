using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank
{
    class Sort
    {
        internal void QuickSort(int[] arr, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(arr, start, end);

                QuickSort(arr, start, i - 1);
                QuickSort(arr, i + 1, end);
            }
        }

        internal int Partition(int[] arr, int start, int end)
        {
            int temp;
            int pivot = arr[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = temp;
            return i + 1;
        }

        public void HeapSort(ref int[] arr)
        {
            int heapSize = arr.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; --p)
                MaxHeapify(ref arr, heapSize, p);

            for (int i = arr.Length - 1; i > 0; --i)
            {
                int temp = arr[i];
                arr[i] = arr[0];
                arr[0] = temp;

                --heapSize;
                MaxHeapify(ref arr, heapSize, 0);
            }
        }

        private void MaxHeapify(ref int[] arr, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && arr[left] > arr[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && arr[right] > arr[largest])
                largest = right;

            if (largest != index)
            {
                int temp = arr[index];
                arr[index] = arr[largest];
                arr[largest] = temp;

                MaxHeapify(ref arr, heapSize, largest);
            }
        }

    }
}
