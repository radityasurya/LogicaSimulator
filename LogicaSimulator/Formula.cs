using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSimulator
{
    public class Formula
    {
        // Attributes
        private string prefixFormula;
        public string PrefixFormula
        {
            get { return PrefixFormula; }
            set { prefixFormula = value; }
        }
        private string infixFormula;
        public string InfixFormula
        {
            get { return InfixFormula; }
            set { InfixFormula = value; }
        }

        public string infix = "";

        // Constructor
        public Formula(string formula, string type)
        {
            if (type == "prefix")
            {
                string[] tempFormula = formula.Split(' ');
                this.prefixFormula = formula;
            } else
            {
                this.infixFormula = formula;
            }
        }

        // Methods
        public string getVariables(string s)
        {
            string temp = "";
            int i = 0;
            List<string> variable = new List<string>();
            while (i < s.Length)
            {
                if (Char.IsLetter(s[i]))
                {
                    if(!temp.Contains(s[i]))
                    {
                        temp += s[i];
                    }
                }
                i++;
            }

            return temp;
        }

        public bool isOperator(string c)
        {
            switch (c)
            {
                case ">":
                case "=":
                case "&":
                case "|":
                    return true;
            }
            return false;
        } 

        public bool isNot(string c)
        {
            return c.Equals("~");
        }

        public List<Node> generateNodes(List<string> prefixList)
        {
            List<Node> tempList = new List<Node>();
            var stack = new Stack<Node>();

            foreach (var c in prefixList)
            {
                if (isOperator(c))
                {
                    Node l = stack.Pop();

                    if (stack.Count > 0)
                    {
                        Node r = stack.Pop();
                        var node = new Node(c, l, r);
                        tempList.Add(node);
                        stack.Push(node);
                    }
                    else
                    {
                        var node = new Node(c, l);
                        tempList.Add(node);
                        stack.Push(node);
                    }

                }
                else if (isNot(c))
                {
                    Node r = stack.Pop();
                    var node = new Node(c, r);
                    tempList.Add(node);
                    stack.Push(node);
                }
                else
                {
                    var node = new Node(c);
                    tempList.Add(node);
                    stack.Push(node);
                }
            }

            return tempList;
        }

        public List<string> getPrefixList(string prefix)
        {
            List<string> temp = new List<string>();

            foreach (char c in prefix)
            {
                temp.Add(c.ToString());
            }

            temp.Reverse();

            return temp;
        }

        public string toInfix(Node current, Node before)
        {

            if (current == null)
            {
                return "";
            }

            if (before != null && current.Right != null)
            {
                infix += "( ";
                toInfix(current.Left, current);

                if (isOperator(current.Label))
                {
                    infix += toSymbol(current.Label) + " ";
                }
                else if (isNot(current.Label))
                {
                    infix += toSymbol(current.Label) + " ";
                }
                else
                {
                    infix += current.Label + " ";
                }
                toInfix(current.Right, current);

                infix += ") ";

            }
            else
            {
                toInfix(current.Left, current);

                if (isOperator(current.Label))
                {
                    infix += toSymbol(current.Label) + " ";
                } else if(isNot(current.Label))
                {
                    infix += toSymbol(current.Label) + " ";
                }
                else
                {
                    infix += current.Label + " ";
                }

                toInfix(current.Right, current);
            }

            return infix;
        }

        public override string ToString()
        {
            return prefixFormula;
        }

        public string toSymbol(string s)
        {
            string temp = "";
            switch (s)
            {
                case "~":
                    temp = "¬";
                    break;
                case "=":
                    temp = "⇔";
                    break;
                case "&":
                    temp = "⋀";
                    break;
                case "|":
                    temp = "⋁";
                    break;
                case ">":
                    temp = "⇒";
                    break;
            }
            return temp;
        }
    }

}
