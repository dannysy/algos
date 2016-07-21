using System.Collections.Generic;

namespace PriorityQ
{
    public static class VovaLogic
    {
        public static int Solve(int count, int[] fruits, int maxWeght)
        {
            var steps = 0;
            var priorityQueue = new PriorityQueue(fruits, count);
            while (priorityQueue.Length != 0)
            {
                var next = priorityQueue.GetNext();
                int sum = next;
                var toInsert = new List<int>();
                AddToList(next, toInsert);
                while (priorityQueue.Length > 0 && sum + priorityQueue.PeekAtNext() <= maxWeght)
                {
                    next = priorityQueue.GetNext();
                    AddToList(next, toInsert);
                    sum += next;
                }
                foreach (var fruit in toInsert)
                {
                    priorityQueue.InsertWithPriority(fruit);
                }
                steps++;
            }
            return steps;
        }

        private static void AddToList(int next, List<int> toInsert)
        {
            if (next > 1)
                toInsert.Add(next / 2);
        }
    }
}