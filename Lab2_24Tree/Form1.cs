using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using Alg_Lab2;

namespace howto_generic_treenode
{
    public partial class Form1 : Form
    {
        int counter = 1;
        TwoThreeFourTree tree;
        private TreeNode<CircleNode> root =
           new TreeNode<CircleNode>(new CircleNode("[]"));
        public Form1()
        {
            InitializeComponent();
            tree = null;
        }

        private void RenderTree()
        {
            if (tree != null)
                AddInTree(TwoThreeFourTree.GetHead(tree));
            using (Graphics gr = this.CreateGraphics())
            {
                // Arrange the tree once to see how big it is.
                float xmin = 0, ymin = 0;
                root.Arrange(gr, ref xmin, ref ymin);

                // Arrange the tree again to center it.
                xmin = (this.ClientSize.Width - xmin) / 2;
                //ymin = (this.ClientSize.Height - ymin) / 2;
                root.Arrange(gr, ref xmin, ref ymin);
            }

            // Redraw.
            this.Refresh();
        }

        private void AddInTree(TwoThreeFourTree tree, TreeNode<CircleNode> parent = null)
        {
            if (tree == null)
            {
                if (checkBox1.Checked)
                    parent.AddChild(new TreeNode<CircleNode>(new CircleNode("[]")));
                return;

            }
            string text = "";
            for (int i = 0; i < tree.Values.Count; i++)
            {
                text += tree.Values[i];
                if (i != tree.Values.Count - 1)
                    text += " | ";
            }
            text += "";
            var node = new TreeNode<CircleNode>(new CircleNode(text));

            if (tree.Parent == null)
            {
                root = node;
            }
            else
            {
                parent.AddChild(node);
            }

            parent = node;
            for (int i = 0; i < tree.Children.Length; i++)
            {
                AddInTree(tree.Children[i], parent);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            root.DrawTree(e.Graphics);
        }

        // Arrange the tree to center it.
        private void Form1_Resize(object sender, EventArgs e)
        {
            RenderTree();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(textBox1.Text);
            if (tree == null)
                tree = new TwoThreeFourTree(value);
            else
                TwoThreeFourTree.Add(value, tree);
            RenderTree();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            int value = counter++;
            if (tree == null)
                tree = new TwoThreeFourTree(value);
            else
                TwoThreeFourTree.Add(value, tree);
            RenderTree();
        }

        private void button_redrav_Click(object sender, EventArgs e)
        {
            RenderTree();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //Это уже не к нам:)
        }
    }
}
