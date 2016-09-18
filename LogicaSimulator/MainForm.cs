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
            tbPrefix.Text = "=( >(A, B), |( ~(A) ,B) )";
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string formulaText = tbPrefix.Text;
            formula = new Formula(formulaText, "prefix");
            formulaText = formula.getVariables(formulaText);

            // Generate infix
            tbInfix.Text = getInfix(tbPrefix.Text);

            // Print variables
            tbVariables.Text = formulaText;

            // Show Image
            pbTree.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + "\\abc.png";

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

        private void btnViewTree_Click(object sender, EventArgs e)
        {
            fh.openGraph();
        }
    }
}
