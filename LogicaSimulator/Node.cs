using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSimulator
{
    public class Node
    {
        public string Label { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
        public bool Value { get; set; }

        public Node(string label, Node left, Node Right )
        {
            this.Label = label;
            this.Left = left;
            this.Right = Right;
        }

        public Node(string label)
        {
            this.Label = label;
        }

        public Node(string label, Node Right)
        {
            this.Label = label;
            this.Right = Right;
        }
    }
}
