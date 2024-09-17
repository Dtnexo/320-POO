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
    public partial class Menue : Form
    {

        public Menue()
        {
            InitializeComponent();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)                                                                   // Key pressed
        {
            if (e.KeyCode == Keys.Escape)
                Environment.Exit(0);
        }
        private void Start_Click(object sender, EventArgs e)
        {
        Game game = new Game();
        game.Show();
        Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
