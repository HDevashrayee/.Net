using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewWinFormsApp
{
    public partial class Form1 : Form
    {
        private TreeView treeView1;
        private Button showCheckedNodeButton;
        private TreeViewCancelEventHandler checkForCheckedChildren;

        public Form1()
        {
            treeView1 = new TreeView();
            showCheckedNodeButton=new Button();
            checkForCheckedChildren = new TreeViewCancelEventHandler(CheckForCheckedChildrenHandler);

            this.SuspendLayout();

            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 25);
            treeView1.Size = new Size(292, 248);
            treeView1.Anchor = AnchorStyles.Top | AnchorStyles.Left |
                AnchorStyles.Bottom | AnchorStyles.Right;
            treeView1.CheckBoxes = true;

            TreeNode node;
            for (int x = 0; x < 3; x++)
            {
                // Add a root node.
                node = treeView1.Nodes.Add(String.Format("Node{0}", x * 4));
                for (int y = 0; y < 4; y++)
                {
                    // Add a node as a child of the previously added node.
                    node = node.Nodes.Add(String.Format("Node{0}", x * 4 + y));
                }
            }

            node = treeView1.Nodes.Add(string.Format("Node{0}", 12));
            node.Nodes.Add(String.Format("Node{0}", 13));
            node.Nodes.Add(String.Format("Node{0}", 14));
            // Set the checked state of one of the nodes to
            // demonstrate the showCheckedNodesButton button behavior.
            treeView1.Nodes[1].Nodes[0].Nodes[0].Checked = true;
            treeView1.Nodes[2].Nodes[0].Nodes[0].Nodes[0].Checked = true;
            treeView1.Nodes[3].Nodes[1].Checked = true;

            // Initialize showCheckedNodesButton.
            showCheckedNodeButton.Size = new Size(244, 24);
            showCheckedNodeButton.Text = "Show Checked Nodes";
            showCheckedNodeButton.Click += new EventHandler(showCheckedNodesButton_Click);

            this.ClientSize = new Size(292, 273);
            this.Controls.AddRange(new Control[] { showCheckedNodeButton, treeView1 });

            InitializeComponent();
        }

        private void showCheckedNodesButton_Click(object sender, EventArgs e)
        {
            // Disable redrawing of treeView1 to prevent flickering 
            // while changes are made.

            treeView1.BeginUpdate();

            // Collapse all nodes of treeView1.
            treeView1.ExpandAll();

            // Add the checkForCheckedChildren event handler to the BeforeExpand event.
            treeView1.BeforeCollapse += checkForCheckedChildren;

            // Expand all nodes of treeView1. Nodes without checked children are
            // prevented from expanding by the checkForCheckedChildren event handler.

            treeView1.CollapseAll();

            // Remove the checkForCheckedChildren event handler from the BeforeExpand 
            // event so manual node expansion will work correctly.

            treeView1.BeforeCollapse -= checkForCheckedChildren;

            treeView1.EndUpdate();

        }



        private void CheckForCheckedChildrenHandler(object sender, TreeViewCancelEventArgs e)
        {
            if (HasCheckedChildNodes(e.Node)) 
                e.Cancel = false;
        }

        private bool HasCheckedChildNodes(TreeNode node)
        {
            if(node.Nodes.Count == 0) return false;

            foreach (TreeNode childNode in node.Nodes)
            {
                if(childNode.Checked)return true;
                // Recursively check the children of the current child node.
                if(HasCheckedChildNodes(childNode)) return true;
            }
            return false;
        }

    }
}
