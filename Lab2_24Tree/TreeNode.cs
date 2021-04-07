using System.Collections.Generic;
using System.Drawing;

namespace Lab2_24Tree
{
    internal class TreeNode<T> where T : IDrawable
    {
        // The data.
        public T Data;

        // Child nodes in the tree.
        public List<TreeNode<T>> Children = new List<TreeNode<T>>();

        // Space to skip horizontally between siblings
        // and vertically between generations.
        private const float Hoffset = 5;
        private const float Voffset = 10;

        // The node's center after arranging.
        private PointF _center;

        // Drawing properties.
        public Font MyFont = null;
        public Pen MyPen = Pens.Black;
        public Brush FontBrush = Brushes.Black;
        public Brush BgBrush = Brushes.White;

        // Constructor.
        public TreeNode(T newData) : this(newData, new Font("Segoe UI", 12))
        {
            Data = newData;
        }

        public TreeNode(T newData, Font fgFont)
        {
            Data = newData;
            MyFont = fgFont;
        }

        // Add a TreeNode to out Children list.
        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }

        // Arrange the node and its children in the allowed area.
        // Set xmin to indicate the right edge of our subtree.
        // Set ymin to indicate the bottom edge of our subtree.
        public void Arrange(Graphics gr, ref float xmin, ref float ymin)
        {
            // See how big this node is.
            var mySize = Data.GetSize(gr, MyFont);

            // Recursively arrange our children,
            // allowing room for this node.
            var x = xmin;
            var biggestYmin = ymin + mySize.Height;
            var subtreeYmin = ymin + mySize.Height + Voffset;
            foreach (var child in Children)
            {
                // Arrange this child's subtree.
                var childYmin = subtreeYmin;
                child.Arrange(gr, ref x, ref childYmin);

                // See if this increases the biggest ymin value.
                if (biggestYmin < childYmin) biggestYmin = childYmin;

                // Allow room before the next sibling.
                x += Hoffset;
            }

            // Remove the spacing after the last child.
            if (Children.Count > 0) x -= Hoffset;

            // See if this node is wider than the subtree under it.
            var subtreeWidth = x - xmin;
            if (mySize.Width > subtreeWidth)
            {
                // Center the subtree under this node.
                // Make the children rearrange themselves
                // moved to center their subtrees.
                x = xmin + (mySize.Width - subtreeWidth) / 2;
                foreach (var child in Children)
                {
                    // Arrange this child's subtree.
                    child.Arrange(gr, ref x, ref subtreeYmin);

                    // Allow room before the next sibling.
                    x += Hoffset;
                }

                // The subtree's width is this node's width.
                subtreeWidth = mySize.Width;
            }

            // Set this node's center position.
            _center = new PointF(xmin + subtreeWidth / 2, ymin + mySize.Height / 2);

            // Increase xmin to allow room for
            // the subtree before returning.
            xmin += subtreeWidth;

            // Set the return value for ymin.
            //ymin = biggest_ymin;
        }

        // Draw the subtree rooted at this node.
        public void DrawTree(Graphics gr)
        {
            // Draw the links.
            DrawSubtreeLinks(gr);

            // Draw the nodes.
            DrawSubtreeNodes(gr);
        }

        // Draw the links for the subtree rooted at this node.
        private void DrawSubtreeLinks(Graphics gr)
        {
            foreach (var child in Children)
            {
                // Draw the link between this node this child.
                gr.DrawLine(MyPen, _center, child._center);

                // Recursively make the child draw its subtree nodes.
                child.DrawSubtreeLinks(gr);
            }
        }

        // Draw the nodes for the subtree rooted at this node.
        private void DrawSubtreeNodes(Graphics gr)
        {
            // Draw this node.
            Data.Draw(_center.X, _center.Y, gr, MyPen, BgBrush, FontBrush, MyFont);

            // Recursively make the child draw its subtree nodes.
            foreach (var child in Children) child.DrawSubtreeNodes(gr);
        }
    }
}