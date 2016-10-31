using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSimulator
{
    public class NandifyFormula
    {
        public Formula f { get; set; }
        public Node Root { get; set; }
        public Node RootDisjunc { get; set; }
        public Node RootSimple { get; set; }

        public string Nand { get; set; }
        public string NandDisjunc { get; set; }
        public string NandSimple { get; set; }

        public string DisjunctivePrefix { get; set; }
        public string SimpleDisjunctivePrefix { get; set; }

        public NandifyFormula(List<Node> nodes, string disjunctivePrefix, string simpleDisjunctivePrefix)
        {
            nodes.Reverse();

            this.Root = nodes[0];
            this.RootDisjunc = generateNodes(disjunctivePrefix)[0];
            this.RootSimple = generateNodes(simpleDisjunctivePrefix)[0];

            this.DisjunctivePrefix = disjunctivePrefix;
            this.SimpleDisjunctivePrefix = simpleDisjunctivePrefix;
        }

        public void getNandForm()
        {
            // get nand
            getPrefixNAND(Root);
            Nand = Root.NANDPRefix;

            // get nand disjunctive
            if (this.DisjunctivePrefix != "0" && this.DisjunctivePrefix != "1")
            {
                getPrefixNAND(RootDisjunc);

                if (RootDisjunc.NANDPRefix.Length > 200)
                {
                    NandDisjunc = RootDisjunc.NANDPRefix.Substring(0, 200);
                } else
                {
                    NandDisjunc = RootDisjunc.NANDPRefix;
                }
            }

            // get nand simple
            if (this.SimpleDisjunctivePrefix != "0" && this.SimpleDisjunctivePrefix != "1")
            {
                getPrefixNAND(RootSimple);
                NandSimple = RootSimple.NANDPRefix;
            }
        }

        public void getPrefixNAND(Node n)
        {
            if (n != null)
            {
                getPrefixNAND(n.Left);
                getPrefixNAND(n.Right);

                if(n.Right != null)
                {
                    if(n.Left != null)
                    {
                        if(n.Left.NANDPRefix == null || n.Right.NANDPRefix == null)
                        {
                            n.NANDPRefix = "";
                            return;
                        } 
                    } else
                    {
                        if (n.Right.NANDPRefix == "")
                        {
                            n.NANDPRefix = "";
                            return;
                        }
                    }
                }
                
                if (Char.IsLetter(Convert.ToChar(n.Label)))
                {
                    n.NANDPRefix = n.Label;
                }

                if (n.Label == "~")
                {
                    n.NANDPRefix = toNand("~", n.Right.NANDPRefix, null);
                }

                if (n.Label != "~" && !char.IsLetter(Convert.ToChar(n.Label)))
                {
                    n.NANDPRefix = toNand(n.Label, n.Left.NANDPRefix, n.Right.NANDPRefix);
                }

            }
        }


        public List<Node> generateNodes(string prefix)
        {
            string pref = prefix.Replace(@" ", "")
               .Replace("(", "")
               .Replace(")", "")
               .Replace(",", "")
               .Trim();

            f = new Formula(prefix, "prefix");

            List<string> prefixList = f.getPrefixList(pref);

            List<Node> Nodes = f.generateNodes(prefixList);

            Nodes.Reverse();

            return Nodes;
        }

        public string toNand(string symbol, string left, string right)
        {
            switch (symbol)
            {
                case "~":
                    return "%(" + left + "," + left + ")";
                case "|":
                    return "%(%(" + left + "," + left + "),%(" + right + "," + right + "))";
                case "&":
                    return "%(%(" + left + "," + right + "),%(" + left + "," + right + "))";
                case ">":
                    return "%(" + left + ",%(" + right + "," + right + "))";
                case "=":
                    return toNand("|", toNand("&", toNand("~", left, null), toNand("~", right, null)), toNand("&", left, right));
            }
            return null;
        }
    }
}
