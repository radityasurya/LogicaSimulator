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

        public List<Node> nodes;
        public string variables;
        public string Hash = "";


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
                    if(!variable.Contains(s[i].ToString()))
                    {
                        variable.Add(s[i].ToString());
                    }
                }
                i++;
            }

            variable.Sort();

            foreach (string v in variable)
            {
                temp += v;
            }

            variables = temp;

            return temp;
        }

        public List<string> getTruthTableValue()
        {
            List<string> TruthTableValue = new List<string>();
            nodes.Reverse();
            bool[,] truthTable = iterateTable(variables.Count());

            bool[] x = new bool[truthTable.GetLength(0)];
            bool[] y = new bool[truthTable.GetLength(0)];

            for (int i = 0; i < truthTable.GetLength(0); i++)
            {
                for (int j = 0; j < truthTable.GetLength(1); j++)
                {
                    // assign value to nodes
                    assignValue(variables[j], truthTable[i, j]);
                    assignValue(variables[j], truthTable[i, j]);
                }
                // calculate
                x[i] = calculate();
                y[i] = calculate();
            }

            for (int i = 0; i < truthTable.GetLength(0); i++)
            {
                TruthTableValue.Add(boolToString(truthTable[i, 0]));
                for (int j = 1; j < truthTable.GetLength(1); j++)
                {
                    TruthTableValue.Add(boolToString(truthTable[i, j]));
                }
                TruthTableValue.Add(boolToString(x[i]));
                Hash += boolToString(x[i]);
                if (!x.SequenceEqual(y)) TruthTableValue.Add(boolToString(y[i]));
            }

            return TruthTableValue;
        }

        public string getHash()
        {
            char[] chars = Hash.ToCharArray();
            Array.Reverse(chars);

            Hash = new string(chars);

            int divider = Hash.Length % 4;
            if (divider != 0)
            {
                Hash = new string('0', 4 - divider) + Hash;
            }

            string hash = "";

            for (int i = 0; i <= Hash.Length - 4; i+=4)
            {
                hash += string.Format("{0:X}", Convert.ToByte(Hash.Substring(i, 4), 2));
            }

            return hash;
        }

        public bool calculate()
        {
            Stack<bool> stack = new Stack<bool>();

            foreach (Node n in nodes)
            {
                if(!(isOperator(n.Label)) && !(isNot(n.Label)))
                {
                    stack.Push(n.Value);
                } else
                {
                    switch (n.Label)
                    {
                        case "|":
                            stack.Push(stack.Pop() | stack.Pop());
                            break;
                        case "=":
                            stack.Push(!stack.Pop() ^ stack.Pop());
                            break;
                        case ">":
                            stack.Push(!stack.Pop() | stack.Pop());
                            break;
                        case "&":
                            stack.Push(stack.Pop() & stack.Pop());
                            break;
                        case "~":
                            stack.Push(!stack.Pop());
                            break;
                        default:
                            break;
                    }
                }
            }

            return stack.Pop();
        }

        public bool assignValue(char c, bool val)
        {
            bool status = false;
            foreach (var t in nodes)
            {
                if (t.Label == c.ToString())
                {
                    t.Value = val;
                    status = true;
                }
            }

            return status;
        }

        public string boolToString(bool b)
        {
            if (b)
            {
                return "1";
            } else
            {
                return "0";
            }
        }

        public static bool[,] iterateTable(int column)
        {
            int rows = (int)Math.Pow(2, column);
            bool[,] table = new bool[rows, column];

            int divider = rows;

            for (int c = 0; c < column; c++)
            {
                divider /= 2;

                bool cell = false;

                for (int r = 0; r < rows; r++)
                {
                    table[r, c] = cell;

                    if ((divider == 1) || ((r + 1) % divider == 0))
                    {
                        cell = !cell;
                    }
                }
            }

            return table;
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

            nodes = tempList;

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
