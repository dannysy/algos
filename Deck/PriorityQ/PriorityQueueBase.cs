using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQ
{
    public abstract class PriorityQueueBase
    {
        public abstract void InsertWithPriority(int priority);
        public abstract int GetNext();
        public abstract int PeekAtNext();
    }
}
