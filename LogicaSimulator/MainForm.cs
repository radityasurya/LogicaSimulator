using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace LogicaSimulator
{
    public partial class MainForm : Form
    {
        // Properties
        private Formula formula;
        private SimplifyFormula simplifyFormula;
        private DisjunctiveFormula disjunctiveFormula;
        private NandifyFormula nandifyFormula;
        private List<Node> Nodes;
        private FileHelper fh;
        private List<string[]> ListToSimplify;
        private List<string> tempRowList;
        private List<string> tempSimpleList;

        public MainForm()
        {
            ListToSimplify = new List<string[]>();
            tempSimpleList = new List<string>();
            Nodes = new List<Node>();

            InitializeComponent();
            fh = new FileHelper();
            //tbPrefix.Text = "=( >(A, B), |( ~(A) ,B) )";
            //tbPrefix.Text = "&( ( | (A, ~(B) ), C)";
            //tbPrefix.Text = ">(&(A, B), C)";
            tbPrefix.Text = "|(|(A, B), C)";
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            lbTruth.Items.Clear();
            lbSimplified.Items.Clear();
            tempSimpleList.Clear();

            tbDisInfix.Text = "";
            tbDisPrefix.Text = "";
            tbSimpleDisInfix.Text = "";
            tbSimpleDisPrefix.Text = "";

            string formulaText = tbPrefix.Text;
            formula = new Formula(formulaText, "prefix");
            formulaText = formula.getVariables(formulaText);

            // Generate infix
            tbInfix.Text = getInfix(tbPrefix.Text);

            // Print variables
            tbVariables.Text = formulaText;

            // Show Image
            pbTree.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "\\abc.png";

            // Generate Truth Table
            generateTable();

            // Simplify Table
            simplifyTable();

            // Get Disjunctive;
            disjunctiveFormula = new DisjunctiveFormula(tempRowList, tbVariables.Text.ToList(), tempSimpleList);
            tbDisInfix.Text = disjunctiveFormula.DisjunctiveFormInfix;
            tbDisPrefix.Text = disjunctiveFormula.DisjunctiveFormPrefix;
            tbSimpleDisInfix.Text = disjunctiveFormula.SimpleDisjunctiveFormInfix;
            tbSimpleDisPrefix.Text = disjunctiveFormula.SimpleDisjunctiveFormPrefix;

            // Get NAnd
            nandifyFormula = new NandifyFormula(Nodes, tbDisPrefix.Text, tbSimpleDisPrefix.Text);
            nandifyFormula.getNandForm();
            tbN.Text = nandifyFormula.Nand;
            tbNandHash.Text = tbHash.Text;

            tbNdisjunc.Text = nandifyFormula.NandDisjunc;
            tbNandDisjuncHash.Text = getHash(tbDisPrefix.Text);

            tbNSimple.Text = nandifyFormula.NandSimple;
            tbNandSimpleHash.Text = getHash(tbSimpleDisPrefix.Text);
        }

        private string getInfix(string prefix)
        {
            string infix = "";

            string pref = prefix.Replace(@" ", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Trim();

            List<string> prefixList = formula.getPrefixList(pref);

            Nodes = formula.generateNodes(prefixList);

            Nodes.Reverse();

            // Generate DOT
            fh.GenerateDot(Nodes);

            infix = formula.toInfix(Nodes[0], null);

            return infix;
        }

        public void generateTable()
        {
            string header = "";

            // Table Title
            for (int i = 0; i < tbVariables.Text.Length; i++)
            {
                header += tbVariables.Text[i] + "      ";    
            }

            // Table Title + infix
            header += tbInfix.Text;

            lbTruth.Items.Add(header);

            tempRowList = formula.getTruthTableValue();
            for (int i = 0; i < tempRowList.Count; i += tbVariables.Text.Length + 1)
            {
                var tempRow = "";
                tempRow = tempRowList[i];
           
                for (int j = 1; j < tbVariables.Text.Length + 1; j++)
                {

                    if (j == tbVariables.Text.Length)
                    {
                        tempRow += "      ";
                    }
                    tempRow = tempRow + "      " + tempRowList[i + j];
                }

                lbTruth.Items.Add(tempRow);
                
            }

            tbHash.Text = formula.getHash();

        }

        public void simplifyTable()
        {
            string header = "";

            // Table Title
            for (int i = 0; i < tbVariables.Text.Length; i++)
            {
                header += tbVariables.Text[i] + "      ";
            }

            // Table Title + infix
            header += tbInfix.Text;

            lbSimplified.Items.Add(header);

            // simplify formula
            simplifyFormula = new SimplifyFormula(tempRowList, tbVariables.Text.ToList());

            simplifyFormula.SimplifiedList.Count();

            for (int i = 0; i < simplifyFormula.SimplifiedList.Count; i++)
            {
                var tempRow = "";

                for (int j = 0; j < tbVariables.Text.Length + 1; j++)
                {
                    if (j == 0 )
                    {
                        tempRow = simplifyFormula.SimplifiedList[i][j];
                        tempSimpleList.Add(simplifyFormula.SimplifiedList[i][j]);
                    } else
                    {
                        tempRow += "       ";
                        tempRow += simplifyFormula.SimplifiedList[i][j];
                        tempSimpleList.Add(simplifyFormula.SimplifiedList[i][j]);
                    }
                }

                lbSimplified.Items.Add(tempRow);
            }
        }

        public string getHash(string prefix)
        {
            Formula tempFormula = new Formula(prefix, "prefix");
            string tempPref = prefix.Replace(@" ", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Trim();
            tempFormula.getVariables(tempPref);
            List<string> tempPrefixList = tempFormula.getPrefixList(tempPref);

            List<Node> tempNodes = tempFormula.generateNodes(tempPrefixList);
            tempFormula.nodes.Reverse();
            List<string> _tempRowList = tempFormula.getTruthTableValue();
            return tempFormula.getHash();
        }
        private void btnViewTree_Click(object sender, EventArgs e)
        {
            fh.openGraph();
        }
    }
}
