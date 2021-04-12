using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Decorator.Advance
{
    class BorderedPhoto : Photo
    {
        Photo photo;
        Color color;
        public BorderedPhoto(Photo p, Color c)
        {
            photo = p;
            color = c;
        }
        public override void Drawer(Object source, PaintEventArgs e)
        {
            photo.Drawer(source, e);
            e.Graphics.DrawRectangle(new Pen(color, 10), 25, 15, 215, 225);
        }
    }
}
