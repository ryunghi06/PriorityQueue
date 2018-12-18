using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPriorityQueue
{
    
    public class MockObject : IComparable<MockObject>
    {
        public string Name { get; set; }
        double Priority { get; set; }

        public MockObject(string n, double p)
        {
            Name = n;
            Priority = p;
        }
        public override string ToString()
        {
            return $"Name {Name} Priority {Priority}";
        }

        public int CompareTo(MockObject obj)
        {
            if (Priority < obj.Priority)
                return -1;
            else if (Priority > obj.Priority)
                return 1;
            else
                return 0;

        }
    }
}
