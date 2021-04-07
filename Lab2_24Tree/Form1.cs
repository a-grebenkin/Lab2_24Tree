using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Lab2_24Tree
{
    public partial class Form1 : Form
    {
        private int _counter = 1;
        private TwoThreeFourTree _tree;
        private TreeNode<CircleNode> _root =
           new TreeNode<CircleNode>(new CircleNode("[]"));
        public Form1()
        {
            InitializeComponent();
            _tree = null;
        }

        private void RenderTree()
        {
            if (_tree != null)
                AddInTree(TwoThreeFourTree.GetHead(_tree));
            using (var gr = this.CreateGraphics())
            {
                // Arrange the tree once to see how big it is.
                float xmin = 0, ymin = 0;
                _root.Arrange(gr, ref xmin, ref ymin);

                // Arrange the tree again to center it.
                xmin = (ClientSize.Width - xmin) / 2;
                //ymin = (this.ClientSize.Height - ymin) / 2;
                _root.Arrange(gr, ref xmin, ref ymin);
            }

            // Redraw.
            Refresh();
        }

        private void AddInTree(TwoThreeFourTree tree, TreeNode<CircleNode> parent = null)
        {
            if (tree == null)
            {
                if (checkBox1.Checked)
                    parent?.AddChild(new TreeNode<CircleNode>(new CircleNode("[]")));
                return;

            }
            var text = "";
            for (var i = 0; i < tree.Values.Count; i++)
            {
                text += tree.Values[i];
                if (i != tree.Values.Count - 1)
                    text += " | ";
            }
            text += "";
            var node = new TreeNode<CircleNode>(new CircleNode(text));

            if (tree.Parent == null)
            {
                _root = node;
            }
            else
            {
                parent?.AddChild(node);
            }

            parent = node;
            foreach (var t in tree.Children)
            {
                AddInTree(t, parent);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            _root.DrawTree(e.Graphics);
        }

        // Arrange the tree to center it.
        private void Form1_Resize(object sender, EventArgs e)
        {
            RenderTree();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var value = Int32.Parse(textBox1.Text);
            if (_tree == null)
                _tree = new TwoThreeFourTree(value);
            else
                TwoThreeFourTree.Add(value, _tree);
            textBox1.Text = string.Empty;
            RenderTree();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            var value = _counter++;
            if (_tree == null)
                _tree = new TwoThreeFourTree(value);
            else
                TwoThreeFourTree.Add(value, _tree);
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
