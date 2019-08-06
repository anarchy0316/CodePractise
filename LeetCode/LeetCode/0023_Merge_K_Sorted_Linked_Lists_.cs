using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    //https://leetcode-cn.com/problems/merge-k-sorted-lists/
    public class _0023_Merge_K_Sorted_Linked_Lists_
    {

        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode result = new ListNode(0);
            ListNode current = result;

            PriorityQueue<ListNode> a = new PriorityQueue<ListNode>(new Com());

            foreach (var item in lists)
            {
                if (item != null)
                {
                    a.Push(item);
                }
            }
            while (true)
            {
                if (a.Count == 0)
                {
                    break;
                }
                var temp = a.Pop();
                current.next = temp;
                current = current.next;

                if (temp.next != null)
                {
                    a.Push(temp.next);
                }
            }
            return result.next;
        }
    }
    public class Com : IComparer<ListNode>
    {
        public int Compare(ListNode x, ListNode y)
        {

            if (x.val > y.val)
            {
                return -1;
            }
            else if (x.val < y.val)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
    class PriorityQueue<T>
    {
        IComparer<T> comparer;
        T[] heap;
        public int Count { get; private set; }

        public PriorityQueue() : this(null) { }
        public PriorityQueue(int capacity) : this(capacity, null) { }
        public PriorityQueue(IComparer<T> comparer) : this(16, comparer) { }
        public PriorityQueue(int capacity, IComparer<T> comparer)
        {
            this.comparer = (comparer == null) ? Comparer<T>.Default : comparer;
            this.heap = new T[capacity];
        }

        public void Push(T v)
        {
            if (Count >= heap.Length) Array.Resize(ref heap, Count * 2);
            heap[Count] = v;
            SiftUp(Count++);
        }

        public T Pop()
        {
            var v = Top();
            heap[0] = heap[--Count];
            if (Count > 0) SiftDown(0);
            return v;
        }

        public T Top()
        {
            if (Count > 0) return heap[0];
            throw new InvalidOperationException("优先队列为空");
        }

        void SiftUp(int n)
        {
            var v = heap[n];
            for (var n2 = n / 2; n > 0 && comparer.Compare(v, heap[n2]) > 0; n = n2, n2 /= 2) heap[n] = heap[n2];
            heap[n] = v;
        }

        void SiftDown(int n)
        {
            var v = heap[n];
            for (var n2 = n * 2; n2 < Count; n = n2, n2 *= 2)
            {
                if (n2 + 1 < Count && comparer.Compare(heap[n2 + 1], heap[n2]) > 0) n2++;
                if (comparer.Compare(v, heap[n2]) >= 0) break;
                heap[n] = heap[n2];
            }
            heap[n] = v;
        }
    }
}