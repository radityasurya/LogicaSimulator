using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSimulator
{
    public class SimplifyFormula
    {
        private List<string[]> ListToSimplify;
        public List<string[]> SimplifiedList { get; set; }

        public SimplifyFormula(List<string> TruthTableList, List<char> Variables)
        {
            ListToSimplify = new List<string[]>();

            string[] rows = new string[Variables.Count + 1];

            int counter = 0;

            for (int i = 0; i < TruthTableList.Count; i++)
            {
                rows[counter] = TruthTableList[i];
                counter++;

                if (counter > 3)
                {
                    counter = 0;
                    ListToSimplify.Add(rows);
                    rows = new string[Variables.Count + 1];
                }
            }

            simplify(new List<string[]>(), ListToSimplify);

        }

        public void simplify(List<string[]> list1, List<string[]> list2)
        {
            List<string[]> newList = new List<string[]>();
            List<string[]> combinedList = new List<string[]>();

            // Stop if the list is equal
            if (this.compare(list1, list2))
            {
                SimplifiedList = list2;
                return;
            }

            list1 = list2;

            foreach (var row1 in list1)
            {
                foreach (var row2 in list1)
                {
                    if (this.isAbleToSimplified(row1, row2))
                    {
                        string[] newValue = transform(row1, row2);
                        if (!newList.Any(a => a.SequenceEqual(newValue)))
                        {
                            newList.Add(newValue);
                        }
                        if (!combinedList.Any(a => a.SequenceEqual(row1)))
                        {
                            combinedList.Add(row1);
                        }
                        if (!combinedList.Any(a => a.SequenceEqual(row2)))
                        {
                            combinedList.Add(row2);
                        }
                    }
                }
            }

            //Add those truth values which can't be combined.
            list1.ForEach(strings =>
            {
                if (!combinedList.Contains(strings))
                {
                    newList.Add(strings);
                }
            });

            simplify(list1, newList);
        }

        public static string[] transform(string[] row1, string[] row2)
        {
            string[] transformedRow = new string[row1.Length];

            for (int i = 0; i < row1.Length; i++)
            {
                if(row1[i] != row2[i])
                {
                    transformedRow[i] = "*";
                } else
                {
                    transformedRow[i] = row1[i];
                }
            }

            return transformedRow;
        }

        public bool isAbleToSimplified(string[] row1, string[] row2)
        {
            int counter = 0;

            if(row1[row1.Length-1] != row2[row2.Length-1])
            {
                return false;
            }

            for (int i = 0; i < row1.Length-1; i++)
            {
                if(row1[i] != row2[i])
                {
                    counter++;
                }
            }

            if (counter == 1)
            {
                return true;
            }

            return false;
        }

        public bool compare(List<string[]> list1, List<string[]> list2)
        {
            var firstNotSecond = list1.Except(list2).ToList();
            var secondNotFirst = list2.Except(list1).ToList();

            return !firstNotSecond.Any() && !secondNotFirst.Any();
        }

    }
}
