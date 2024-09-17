using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace space_invader
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)                                                                   // Key pressed
        {
            if (e.KeyCode == Keys.Escape)
                Environment.Exit(0);
        }
        private void back_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
