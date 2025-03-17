using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeapExample
{
    public class MinHeap<T>
    {
        private List<T> heap = new List<T>();

        public void Insert(T value)
        {
            heap.Add(value);
            HeapifyUp(heap.Count - 1);
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (Comparer<T>.Default.Compare(heap[index], heap[parentIndex]) >= 0) break;
                (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);
                index = parentIndex;
            }
        }
        public T Peek()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            return heap[0];
        }
        public void DisplayHeap()
        {
            Console.WriteLine("\nHeap Elements: ");
            foreach (T value in heap)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        public T ExtractDown()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }
            T min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return min;
        }
        public void HeapifyDown(int index)
        {
            while (index < heap.Count)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = index;
                if (left < heap.Count && Comparer<T>.Default.Compare(heap[left], heap[smallest]) < 0)
                {
                    smallest = left;
                }
                if (right < heap.Count && Comparer<T>.Default.Compare(heap[right], heap[smallest]) < 0)
                {
                    smallest = right;
                }
                if (smallest == index)
                {
                    break;
                }
                (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
                index = smallest;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MinHeap<int> minHeap = new MinHeap<int>();
            minHeap.Insert(10);
            minHeap.Insert(5);
            minHeap.Insert(15);
            minHeap.Insert(20);
            minHeap.Insert(30);

            minHeap.DisplayHeap();
            


            Console.ReadKey();
        }
    }
}
