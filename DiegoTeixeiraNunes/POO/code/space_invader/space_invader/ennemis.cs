using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace space_invader.Resources
{
    class ennemis : PictureBox
    {
        public bool IsDead { get; set; }
        private Form parent;
        Random rnd = new Random();
       // private int _image;
        private int _x;
        private int _y;
        bool direction;
        public ennemis(Form parent, int x, int y)
        {
           // _image = rnd.Next(0, 2);
            _x = x;
            _y = y;
            this.parent = parent;
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
          //  if (_image == 0)
                this.Image = Properties.Resources.ennemis_vert;
           // else
               // this.Image = Properties.Resources.ennemis1;
            this.Location = new Point(x, y);
            this.Name = "this";
            this.Size = new Size(70,42);
            this.TabIndex = 1;
            this.TabStop = false;
            parent.Controls.Add(this);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
        }
        public void Destroy()
        {
            parent.Controls.Remove(this);
            this.Visible = false;
            this.IsDead = true;
        }
        public void Move()
        {
            if (this.Right == parent.Width)
            {
                _x--;
            }
            else
                _x++;
            if (_x % 20 == 0)
            {

                for (int i = 0; i != 60; i++)
                {
                    _y++;
                }
            }
            this.Location = new Point(_x, _y);
        }
        public void bounds()
        {
            if (_x == 830)
            {
                direction = true;
            }
            if (_x == 0)
            {
                direction = false;
            }

            if (direction)
            {
                _x--;
                _y++;
            }
            if (!direction)
            {
                _x++;
                _y++;
            }
            this.Location = new Point(_x, _y);
        }
        public void colision () 
        {
            if (direction)
                direction = false;
            else 
                direction = true;
        }
    }
}
