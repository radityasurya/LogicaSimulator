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
        public void GetVariableTest()
        {
            string prefixFormula = "=( >(A,B), |( ~(A) ,B) )";

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
    }
}
