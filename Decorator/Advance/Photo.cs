using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Decorator.Advance
{
    class Photo : Form
    {
        Image image;
        public Photo()
        {
            image = new Bitmap(@"C:\Users\s.diaz\source\repos\DesingPatterns\Decorator\letra.png");
            this.Text = "Lemonade";
            this.Paint += new PaintEventHandler(Drawer);
        }

        public virtual void Drawer(Object source, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, 30, 20);
        }

    }
}
