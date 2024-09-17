using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace space_invader
{
    class ennemisBullet : PictureBox
    {
        public bool IsDead { get; set; }
        private Form parent;

        public ennemisBullet(Form parent, int x, int y)
        {
            this.parent = parent;
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            this.Image = Properties.Resources.bullet;
            this.Location = new Point(x, y);
            this.Name = "this";
            this.Size = new Size(20, 51);
            this.TabIndex = 1;
            this.TabStop = false;
            this.Visible = true;
            parent.Controls.Add(this);
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
        }
        public void Destroy()
        {
            parent.Controls.Remove(this);
            this.Visible = false;
            this.IsDead = true;
        }
    }
}

