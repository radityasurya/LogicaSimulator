using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;


namespace LogicaSimulator
{
    public class FileHelper
    {
        public FileHelper() { }
        
        public void GenerateDot(List<Node> nodes)
        {
            List<string> _nodes = new List<string>();

            _nodes.Add("graph logic {");
            _nodes.Add("node [ fontname = \"Arial\" ]");

            foreach (var node in nodes)
            {
                _nodes.Add(string.Format("node{0} [ label = \" {1} \" ]", nodes.IndexOf(node) + 1, node.Label));

                if (node.Left != null)
                {
                    _nodes.Add(string.Format("node{0} -- node{1}", nodes.IndexOf(node) + 1, nodes.IndexOf(node.Left) + 1));
                }
                if (node.Right != null)
                {
                    _nodes.Add(string.Format("node{0} -- node{1}", nodes.IndexOf(node) + 1, nodes.IndexOf(node.Right) + 1));
                }
            }

            _nodes.Add("}");

            using (StreamWriter sw = new StreamWriter("abc.dot", false))
            {
                foreach (var node in _nodes)
                {
                    sw.WriteLine(node);
                }
            }

            buildGraph();

        } 

        public void buildGraph()
        {
            Process dot = new Process();

            dot.StartInfo.FileName = @"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe";
            dot.StartInfo.Arguments = "-Tpng -oabc.png abc.dot";

            dot.Start();
            dot.WaitForExit();
        }

        public void openGraph()
        {
            string imagePath = AppDomain.CurrentDomain.BaseDirectory + "\\abc.png";
            string path = @"D:\school\Blok 13\ALE1\LogicaSimulator\LogicaSimulator\bin\Debug\abc.png";

            using (Process image = new Process())
            {
                image.StartInfo.FileName = imagePath;

                image.Start();
            }
        }
    }
}
