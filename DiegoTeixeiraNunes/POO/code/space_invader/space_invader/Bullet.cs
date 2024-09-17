using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace space_invader
{
    class Bullet : PictureBox
    {
        public bool IsDead {  get; set; }
        private Form parent;

        public Bullet(Form parent,int x,int y)
        {
            this.parent = parent;
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            this.Image = Properties.Resources.bullet1;
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
