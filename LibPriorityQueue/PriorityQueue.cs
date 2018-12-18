using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPriorityQueue
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> priorityQueue;
        public PriorityQueue()
        {
            priorityQueue = new List<T>();
        }

        public void Enqueue(T item)
        {
            priorityQueue.Add(item);
            int length = priorityQueue.Count - 1;

            while(length > 0)
            {
                int middle = (length - 1) / 2;
                if (priorityQueue[length].CompareTo(priorityQueue[middle]) >= 0)
                    break;
                T tmp = priorityQueue[length];
                priorityQueue[length] = priorityQueue[middle];
                priorityQueue[middle] = tmp;
                length = middle;
            }
        }

        public T Peek()
        {
            return priorityQueue[0];
        }

        public T Dequeue()
        {
            if (priorityQueue.Count == 0)
                throw new Exception("Queue is empty");
            int lastIndex = priorityQueue.Count - 1;
            
            T frontItem = priorityQueue[0];
            priorityQueue[0] = priorityQueue[lastIndex];
            priorityQueue.RemoveAt(lastIndex);
            --lastIndex;

            int parent = 0;
            while(true)
            {
                int left = parent*2 + 1;
                if (left > lastIndex)
                    break;
                int right = left + 1;
                if (right <= lastIndex && priorityQueue[right].CompareTo(priorityQueue[left]) < 0)
                    left = right;

                if (priorityQueue[parent].CompareTo(priorityQueue[left]) < 0)
                    break;
                T temp = priorityQueue[parent];
                priorityQueue[parent] = priorityQueue[left];
                priorityQueue[left] = temp;

                parent = left;
            }

            return frontItem;
        }

        public int Count()
        {
            return priorityQueue.Count;
        }

        public bool IsConsistent()
        {
            if (priorityQueue.Count == 0)
                return true;
            int last = priorityQueue.Count - 1;

            for(int parent = 0; parent < priorityQueue.Count; parent++)
            {
                int left = 2 * parent + 1;
                int right = 2 * parent + 2;
                if (left <= last && priorityQueue[parent].CompareTo(priorityQueue[left]) > 0)
                    return false;
                if (right <= last && priorityQueue[parent].CompareTo(priorityQueue[right]) > 0)
                    return false;
            }

            return true;
        }

    }
}
