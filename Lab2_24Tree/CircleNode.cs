using System.Drawing;

namespace Lab2_24Tree
{
    class CircleNode : IDrawable
    {
        // The string we will draw.
        public string Text;

        // Constructor.
        public CircleNode(string newText)
        {
            Text = newText;
        }

        // Return the size of the string plus a 10 pixel margin.
        public SizeF GetSize(Graphics gr, Font font)
        {
            return gr.MeasureString(Text, font) + new SizeF(10, 10);
        }

        // Draw the object centered at (x, y).
        void IDrawable.Draw(float x, float y, Graphics gr, Pen pen, Brush bgBrush, Brush textBrush, Font font)
        {
            // Fill and draw an ellipse at our location.
            var mySize = GetSize(gr, font);
            var rect = new RectangleF(x - mySize.Width / 2, y - mySize.Height / 2, mySize.Width, mySize.Height);
            gr.FillEllipse(bgBrush, rect);
            gr.DrawEllipse(pen, rect);

            // Draw the text.
            using (var stringFormat = new StringFormat())
            {
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                gr.DrawString(Text, font, textBrush, x, y, stringFormat);
            }
        }
    }
}