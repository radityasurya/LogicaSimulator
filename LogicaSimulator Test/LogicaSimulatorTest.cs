using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaSimulator;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LogicaSimulator_Test
{
    [TestClass]
    public class LogicaSimulatorTest
    {
        [TestMethod]
        public void PropositionTest()
        {
            string prefixFormula = "=( >(A,B), |( ~(A) ,B) )";
            string prefixFormula2 = "&( ( |(A, ~(B) ), C)";
            string prefixFormula3 = "&( ( &(A, ~B) ), C)";
            string prefixFormula4 = "&( ( & (A, ~(B) ), &((C, &(D,&(E,G)))))";
            string prefixFormula5 = "&(A, C)";

            Assert.AreEqual("( A ⇒ B ) ⇔ ( ( ¬ A ) ⋁ B ) ", toInfix(prefixFormula));
            Assert.AreEqual("( A ⋁ ( ¬ B ) ) ⋀ C ", toInfix(prefixFormula2));
            Assert.AreEqual("( A ⋀ ( ¬ B ) ) ⋀ C ", toInfix(prefixFormula3));
            Assert.AreEqual("( A ⋀ ( ¬ B ) ) ⋀ ( C ⋀ ( D ⋀ ( E ⋀ G ) ) ) ", toInfix(prefixFormula4));
            Assert.AreEqual("A ⋀ C ", toInfix(prefixFormula5));

        }

        [TestMethod]
        public void GenerateHashTest()
        {
            string prefixFormula = "&( ( |(A, ~(B) ), C)";
            string prefixFormula2 = "&( ( &(A, ~B) ), C";
            string prefixFormula3 = "&(A, C)";

            Assert.AreEqual("A2", getHash(prefixFormula));
            Assert.AreEqual("20", getHash(prefixFormula2));
            Assert.AreEqual("8", getHash(prefixFormula3));

        }

        [TestMethod]
        public void GetVariableTest()
        {
            string prefixFormula = "=( >(B,A), |( ~(B) ,A) )";

            string formulaVariables = "";
            Formula formula = new Formula(prefixFormula, "prefix");
            formulaVariables = formula.getVariables(prefixFormula);

            Assert.AreEqual("AB", formulaVariables);
        }

        [TestMethod]
        public void PrefixToInfixTest()
        {
            string prefixFormula = "=( >(A,B), |( ~(A) ,B) )";

            Formula formula = new Formula(prefixFormula, "prefix");

            string pref = prefixFormula.Replace(@" ", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Trim();

            List<string> prefixList = formula.getPrefixList(pref);

            List<Node> Nodes = formula.generateNodes(prefixList);

            Nodes.Reverse();

            string infixResult = formula.toInfix(Nodes[0], null);

            Assert.AreEqual("( A ⇒ B ) ⇔ ( ( ¬ A ) ⋁ B ) ", infixResult);
        }

        [TestMethod]
        public void ConvertToSymbolTest()
        {
            Formula f = new Formula("A", "prefix");

            string symbol = "";
            symbol += f.toSymbol("&");
            symbol += f.toSymbol("~");
            symbol += f.toSymbol("=");
            symbol += f.toSymbol("|");
            symbol += f.toSymbol(">");

            Assert.AreEqual("⋀¬⇔⋁⇒", symbol);
        }

        [TestMethod]
        public void GenerateTreeTest()
        {
            string prefixFormula = "=( >(A,B), |( ~(A) ,B) )";

            Formula formula = new Formula(prefixFormula, "prefix");
            FileHelper fh = new FileHelper();

            string fileName = AppDomain.CurrentDomain.BaseDirectory + "\\abc.png";
            FileInfo fileInfo = new FileInfo(fileName);

            File.Delete(fileName);

            string pref = prefixFormula.Replace(@" ", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Trim();

            List<string> prefixList = formula.getPrefixList(pref);

            List<Node> Nodes = formula.generateNodes(prefixList);

            Nodes.Reverse();

            fh.GenerateDot(Nodes);

            bool exists = File.Exists(fileName);

            Assert.IsTrue(exists);
        }

        [TestMethod]
        public void TestTruthTable() {
            string prefixFormula = "=( >(A,B), |( ~(A) ,B) )";

            Formula formula = new Formula(prefixFormula, "prefix");

            string formulaVariables = formula.getVariables(prefixFormula);
            List<string> prefixList = formula.getPrefixList(prefixFormula);
            List<Node> Nodes = formula.generateNodes(prefixList);
            //List<string> tempRowList = formula.getTruthTableValue();
            Nodes.Reverse();
            List<string> expectedTruthTable = new List<string>();

            expectedTruthTable.Add("0");
            expectedTruthTable.Add("0");
            expectedTruthTable.Add("0");
            expectedTruthTable.Add("0");

            expectedTruthTable.Add("0");
            expectedTruthTable.Add("0");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");

            expectedTruthTable.Add("0");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("0");
            expectedTruthTable.Add("1");
            
            expectedTruthTable.Add("0");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");

            expectedTruthTable.Add("1");
            expectedTruthTable.Add("0");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");

            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("0");
            expectedTruthTable.Add("1");

            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");
            expectedTruthTable.Add("1");
            
            //List<string> tempRowList = formula.getTruthTableValue();

            //Assert.AreEqual(expectedTruthTable, tempRowList);

        }

        [TestMethod]
        public void TestSimplifiedTable() {

        }

        public string toInfix(string prefix)
        {

            Formula formula = new Formula(prefix, "prefix");

            string pref = prefix.Replace(@" ", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Trim();

            List<string> prefixList = formula.getPrefixList(pref);

            List<Node> Nodes = formula.generateNodes(prefixList);

            Nodes.Reverse();

            return formula.toInfix(Nodes[0], null);
        }

        public string getHash(string prefixFormula) {
            Formula formula = new Formula(prefixFormula, "prefix");
            string pref = prefixFormula.Replace(@" ", "")
                .Replace("(", "")
                .Replace(")", "")
                .Replace(",", "")
                .Trim();
            formula.getVariables(pref);
            List<string> prefixList = formula.getPrefixList(pref);

            List<Node> Nodes = formula.generateNodes(prefixList);
            formula.nodes.Reverse();
            List<string> tempRowList = formula.getTruthTableValue();
            return formula.getHash();
        }

    }
}
