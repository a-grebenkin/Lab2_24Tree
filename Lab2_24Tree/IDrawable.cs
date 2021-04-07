using System.Drawing;

namespace Lab2_24Tree
{
    // Represents something that a TreeNode can draw.
    interface IDrawable
    {
        // Return the object's needed size.
        SizeF GetSize(Graphics gr, Font font);

        // Draw the object centered at (x, y).
        void Draw(float x, float y, Graphics gr, Pen pen, Brush bgBrush, Brush textBrush, Font font);
    }
}