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
        private FileHelper fh;

        public MainForm()
        {
            InitializeComponent();
            fh = new FileHelper();
            //tbPrefix.Text = "=( >(A, B), |( ~(A) ,B) )";
            tbPrefix.Text = "&( ( | (A, ~(B) ), C)";
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            lbTruth.Items.Clear();
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

            List<Node> Nodes = formula.generateNodes(prefixList);

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

            List<string> tempRowList = formula.getTruthTableValue();
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

        private void btnViewTree_Click(object sender, EventArgs e)
        {
            fh.openGraph();
        }
    }
}
