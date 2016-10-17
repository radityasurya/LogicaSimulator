using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSimulator
{
    public class DisjunctiveFormula
    {
        private List<string> TruthTableList;
        private List<string> SimpleTruthTableList;

        public List<char> Variables;
        public List<string> DisjunctiveFormElements;
        public string DisjunctiveFormInfix { get; set; }
        public string DisjunctiveFormPrefix { get; set; }

        public string SimpleDisjunctiveFormInfix { get; set; }
        public string SimpleDisjunctiveFormPrefix { get; set; }

        public DisjunctiveFormula(List<String> TruthTableList, List<char> Variables, List<String> SimpleTruthTableList)
        {
            DisjunctiveFormElements = new List<string>();

            this.TruthTableList = TruthTableList;
            this.SimpleTruthTableList = SimpleTruthTableList;
            this.Variables = Variables;

            this.getDisjunctiveForm();
        }

        public void getDisjunctiveForm()
        {
            DisjunctiveFormElements.Clear();
            DisjunctiveFormInfix = string.Empty;
            this.getDisjunctiveFormInfix(0);
            //in case of contradiction or a tautology.
            if (this.DisjunctiveFormElements.Count > 0)
                this.DisjunctiveFormInfix = this.DisjunctiveAllElementsInfix(this.DisjunctiveFormElements);
            else
            {
                if (Convert.ToInt32(this.TruthTableList[TruthTableList.Count - 1]) == 1)
                    this.DisjunctiveFormInfix = "1";
                else
                    this.DisjunctiveFormInfix = "0";
            }

            DisjunctiveFormElements.Clear();
            DisjunctiveFormPrefix = string.Empty;
            this.getDisjunctiveFormPrefix(0);
            //in case of contradiction or a tautology.
            if (this.DisjunctiveFormElements.Count > 0)
                this.DisjunctiveFormPrefix = this.DisjunctiveAllElementsPrefix(this.DisjunctiveFormElements);
            else
            {
                if (Convert.ToInt32(this.TruthTableList[TruthTableList.Count - 1]) == 1)
                    this.DisjunctiveFormPrefix = "1";
                else
                    this.DisjunctiveFormPrefix = "0";
            }

            // Simplified Disjunctive
            DisjunctiveFormElements.Clear();
            SimpleDisjunctiveFormInfix = string.Empty;
            this.getSimpleDisjunctiveFormInfix(0);
            //in case of contradiction or a tautology.
            if (this.DisjunctiveFormElements.Count > 0)
                this.SimpleDisjunctiveFormInfix = this.DisjunctiveAllElementsInfix(this.DisjunctiveFormElements);
            else
            {
                if (Convert.ToInt32(this.TruthTableList[SimpleTruthTableList.Count - 1]) == 1)
                    this.SimpleDisjunctiveFormInfix = "1";
                else
                    this.SimpleDisjunctiveFormInfix = "0";
            }

            DisjunctiveFormElements.Clear();
            SimpleDisjunctiveFormPrefix = string.Empty;
            this.getSimpleDisjunctiveFormPrefix(0);
            
            //in case of contradiction or a tautology.
            if (this.DisjunctiveFormElements.Count > 0)
                this.SimpleDisjunctiveFormPrefix = this.DisjunctiveAllElementsPrefix(this.DisjunctiveFormElements);
            else
            {
                if (Convert.ToInt32(this.TruthTableList[SimpleTruthTableList.Count - 1]) == 1)
                    this.SimpleDisjunctiveFormPrefix = "1";
                else
                    this.SimpleDisjunctiveFormPrefix = "0";
            }


        }

        private void getDisjunctiveFormInfix(int startIndex)
        {
            //if the result of this row of the truth table is 1.
            if (Convert.ToInt32(this.TruthTableList[startIndex + this.Variables.Count]) == 1)
            {
                List<string> elements = new List<string>();

                for (int i = 0; i < Variables.Count; i++)
                {

                    if (Convert.ToInt32(this.TruthTableList[startIndex + i]) == 1)
                        elements.Add(Variables[i].ToString());
                    else
                        elements.Add(" ~ " + Variables[i].ToString());

                }
                //in case this is a contradiction or a tautology.
                if (elements.Count > 0)
                    DisjunctiveFormElements.Add(this.ConjunctiveAllVariablesInfix(elements));
            }

            //search for each row of the truth table.
            if (startIndex < this.TruthTableList.Count - this.Variables.Count - 1)
                getDisjunctiveFormInfix(startIndex + this.Variables.Count + 1);
        }

        private void getDisjunctiveFormPrefix(int startIndex)
        {
            //if the result of this row of the truth table is 1.
            if (Convert.ToInt32(this.TruthTableList[startIndex + this.Variables.Count]) == 1)
            {
                List<string> elements = new List<string>();

                for (int i = 0; i < Variables.Count; i++)
                {

                    if (Convert.ToInt32(this.TruthTableList[startIndex + i]) == 1)
                        elements.Add(Variables[i].ToString());
                    else
                        elements.Add(" ~ " + Variables[i].ToString());

                }
                //in case this is a contradiction or a tautology.
                if (elements.Count > 0)
                    DisjunctiveFormElements.Add(this.ConjunctiveAllVariablesPrefix(elements));
            }

            //search for each row of the truth table.
            if (startIndex < this.TruthTableList.Count - this.Variables.Count - 1)
                getDisjunctiveFormPrefix(startIndex + this.Variables.Count + 1);
        }

        private void getSimpleDisjunctiveFormInfix(int startIndex)
        {
            //if the result of this row of the truth table is 1.
            if (Convert.ToInt32(this.SimpleTruthTableList[startIndex + this.Variables.Count]) == 1)
            {
                List<string> elements = new List<string>();

                for (int i = 0; i < Variables.Count; i++)
                {
                    if (this.SimpleTruthTableList[startIndex + i] == "*")
                        continue;
                    if (Convert.ToInt32(this.SimpleTruthTableList[startIndex + i]) == 1)
                        elements.Add(Variables[i].ToString());
                    if (Convert.ToInt32(this.SimpleTruthTableList[startIndex + i]) == 0)
                        elements.Add(" ~ " + Variables[i].ToString());
                }
                //in case this is a contradiction or a tautology.
                if (elements.Count > 0)
                    DisjunctiveFormElements.Add(this.ConjunctiveAllVariablesInfix(elements));
            }

            //search for each row of the truth table.
            if (startIndex < this.SimpleTruthTableList.Count - this.Variables.Count - 1)
                getSimpleDisjunctiveFormInfix(startIndex + this.Variables.Count + 1);
        }

        private void getSimpleDisjunctiveFormPrefix(int startIndex)
        {

            //if the result of this row of the truth table is 1.
            if (Convert.ToInt32(this.SimpleTruthTableList[startIndex + this.Variables.Count]) == 1)
            {
                List<string> elements = new List<string>();

                for (int i = 0; i < Variables.Count; i++)
                {
                    if (this.SimpleTruthTableList[startIndex + i] == "*")
                        continue;
                    if (Convert.ToInt32(this.SimpleTruthTableList[startIndex + i]) == 1)
                        elements.Add(Variables[i].ToString());
                    if (Convert.ToInt32(this.SimpleTruthTableList[startIndex + i]) == 0)
                        elements.Add(" ~ " + Variables[i].ToString());
                }
                //in case this is a contradiction or a tautology.
                if (elements.Count > 0)
                    DisjunctiveFormElements.Add(this.ConjunctiveAllVariablesPrefix(elements));
            }

            //search for each row of the truth table.
            if (startIndex < this.SimpleTruthTableList.Count - this.Variables.Count - 1)
                getSimpleDisjunctiveFormPrefix(startIndex + this.Variables.Count + 1);
        }

        private string ConjunctiveAllVariablesInfix(List<string> elements)
        {
            if (elements.Count == 1)
                return elements[0];

            string returnValue = " ( " + elements[0] + " ⋀ " + elements[1] + " ) ";
            for (int i = 2; i < elements.Count; i++)
            {
                returnValue = " ( " + returnValue + " ⋀ " + elements[i] + " ) ";
            }
            return returnValue;
        }
        private string DisjunctiveAllElementsInfix(List<string> elements)
        {
            if (elements.Count == 1)
                return elements[0];

            string returnValue = elements[0] + " ⋁ " + elements[1] + " ";
            for (int i = 2; i < elements.Count; i++)
            {
                returnValue = returnValue + " ⋁ " + elements[i] + " ";
            }
            return returnValue;
        }
        private string ConjunctiveAllVariablesPrefix(List<string> elements)
        {
            if (elements.Count == 1)
                return elements[0];

            string returnValue = " & ( " + elements[0] + " , " + elements[1] + " ) ";
            for (int i = 2; i < elements.Count; i++)
            {
                returnValue = " & ( " + returnValue + " , " + elements[i] + " ) ";
            }
            return returnValue;
        }
        private string DisjunctiveAllElementsPrefix(List<string> elements)
        {
            if (elements.Count == 1)
                return elements[0];

            string returnValue = " | ( " + elements[0] + " , " + elements[1] + " ) ";
            for (int i = 2; i < elements.Count; i++)
            {
                returnValue = " | ( " + returnValue + " , " + elements[i] + " ) ";
            }
            return returnValue;
        }

    }
}
