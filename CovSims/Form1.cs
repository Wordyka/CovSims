using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovSims
{
    public partial class Form1 : Form
    {
        #region Global Variables
        List<graph> graphs = new List<graph>();
        List<graph> vertices = new List<graph>();
        int i = 1;
        int j = 1;

        #endregion


        #region Control Methods
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // clearItems();
            txtPath.Text = "";
            txtNodes.Text = "";
            txtRoot.Text = "";
                   
        }


        private void btnSubmitBFS_Click(object sender, EventArgs e)
        {
                int day = Convert.ToInt32(txtDays.Text.Split(' ')[0].Trim());

                char root = Convert.ToChar(txtRoot.Text.Split(' ')[0].Trim());

                long startDay = 0;
                double virus;
                long diffDay;
                double dayOff;
                bool isDone = false;

                Dictionary<string,double> newNode = new Dictionary<string, double>();
                Dictionary<string,long> listOfNode = new Dictionary<string, long>();


                //create a form 
                System.Windows.Forms.Form form = new System.Windows.Forms.Form();
                //create a viewer object 
                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                //create a graph object 
                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 


                foreach (graph item in vertices)
                { 
                    if (item != null)
                    {
                        listOfNode.Add(item.Node.ToString(), item.ValueOfNode);
                    }
                }

          

                while (isDone == false)
                {

                    foreach (graph item in graphs)
                    {

                        if (listOfNode.ContainsKey(item.NodeSrc.ToString()))
                        {
                            diffDay = day - startDay;
                            long val = listOfNode[item.NodeSrc.ToString()];
                            double eq1 = Math.Pow(val - 1.0, -(0.25 * diffDay));
                            virus = val / (1 + eq1);



                            dayOff = Math.Ceiling(Convert.ToDouble(virus) * Convert.ToDouble(val));

                            MessageBox.Show(String.Format("DAY OFF : {0}; Virus: {1}; Node Value : {2}; EQ1 : {3}; DiffDay : {4}", dayOff, virus, val, eq1, diffDay));

                            startDay = Convert.ToInt64(dayOff);

                            if (virus > 1)
                            {
                                if (item.NodeSrc.Equals(root))
                                {
                                    graph.AddEdge(item.NodeSrc.ToString(), item.NodeDest.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Green; ;
                                  
                                    newNode.Add(item.NodeDest.ToString(), dayOff);
                                }
                                else
                                {
                                    if (newNode.ContainsKey(item.NodeSrc.ToString()))
                                    {
                                        graph.AddEdge(item.NodeSrc.ToString(), item.NodeDest.ToString()).Attr.Color = Microsoft.Msagl.Drawing.Color.Green; ;
                                        newNode.Add(item.NodeDest.ToString(), dayOff);
                                    }
                                }

                                if (day - dayOff < 0)
                                {
                                    isDone = true;
                                    break;
                                }
                            } else
                            {
                                graph.AddEdge(item.NodeSrc.ToString(), item.NodeDest.ToString());
                            } 

                        } 
                    }
                }

                //graph.AddEdge("A", "B");
                //graph.AddEdge("B", "C");
                //graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                graph.FindNode(root.ToString()).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Yellow;
                //graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
                //Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
                //c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                //c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                //bind the graph to the viewer 
                viewer.Graph = graph;
                //associate the viewer with the form 
                form.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                form.Controls.Add(viewer);
                form.ResumeLayout();
                //show the form 
                form.ShowDialog();
            
            
        }

        private void btnAddNodesPath_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "" || txtNodesPath.Text != "")
            {
                char nodeSrc = Convert.ToChar(txtPath.Text.Split(' ')[0].Trim());
                char nodeDest = Convert.ToChar(txtPath.Text.Split(' ')[1].Trim());
                double pathChance = Convert.ToDouble(txtNodesPath.Text.Split(' ')[0].Trim());

                graph item = new graph();
                item.QueryId = i;
                i++;

                item.NodeSrc = nodeSrc;
                item.NodeDest = nodeDest;
                item.NodeValue = pathChance;
                graphs.Add(item);

                txtListNodes.Items.Add(String.Format("Path number {0} : {1} -> {2} ({3})", item.QueryId, item.NodeSrc, item.NodeDest, item.NodeValue));
                txtPath.Clear();
                txtNodesPath.Clear();
            } else
            {
                MessageBox.Show("Please input the field first !");
            }
        }

        private void btnAddNodes_Click(object sender, EventArgs e)
        {
            if (txtNodes.Text != "")
            {
                char node = Convert.ToChar(txtNodes.Text.Split(' ')[0].Trim());
                int nodeValue = Convert.ToInt32(txtNodes.Text.Split(' ')[1].Trim());

                graph item = new graph();
                item.QueryId = j;
                j++;

                item.Node = node;
                item.ValueOfNode= nodeValue;
                vertices.Add(item);
                graphs.Add(item);

                txtListTotal.Items.Add(String.Format("Node {0} : {1} = {2}", item.QueryId, item.Node, item.ValueOfNode));
                txtNodes.Clear();
            }
            else
            {
                MessageBox.Show("Please input the field first !");
            }
        }


        #endregion

    }
}
