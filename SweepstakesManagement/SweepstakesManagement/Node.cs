using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    public class Node
    {
        public char data;
        public Node nextNode;

        public Node(char data)
        {
            this.data = data;
            nextNode = null;
        }
    }
}
