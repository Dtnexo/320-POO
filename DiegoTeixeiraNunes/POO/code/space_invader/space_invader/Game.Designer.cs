namespace space_invader
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ship = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.nbscore = new System.Windows.Forms.Label();
            this.coeur_3 = new System.Windows.Forms.PictureBox();
            this.coeur_2 = new System.Windows.Forms.PictureBox();
            this.coeur_1 = new System.Windows.Forms.PictureBox();
            this.coeur_vide_1 = new System.Windows.Forms.PictureBox();
            this.coeur_vide_2 = new System.Windows.Forms.PictureBox();
            this.coeur_vide_3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_vide_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_vide_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_vide_3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(343, 337);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ship
            // 
            this.ship.Image = global::space_invader.Properties.Resources.ship_removebg_preview2;
            this.ship.Location = new System.Drawing.Point(416, 514);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(58, 56);
            this.ship.TabIndex = 0;
            this.ship.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // score
            // 
            this.score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.score.AutoEllipsis = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Cursor = System.Windows.Forms.Cursors.Hand;
            this.score.Font = new System.Drawing.Font("ISOCPEUR", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(721, 6);
            this.score.Margin = new System.Windows.Forms.Padding(0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(99, 36);
            this.score.TabIndex = 8;
            this.score.Text = "score :";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nbscore
            // 
            this.nbscore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nbscore.AutoEllipsis = true;
            this.nbscore.BackColor = System.Drawing.Color.Transparent;
            this.nbscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nbscore.Font = new System.Drawing.Font("ISOCPEUR", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbscore.ForeColor = System.Drawing.Color.White;
            this.nbscore.Location = new System.Drawing.Point(820, 6);
            this.nbscore.Margin = new System.Windows.Forms.Padding(0);
            this.nbscore.Name = "nbscore";
            this.nbscore.Size = new System.Drawing.Size(58, 36);
            this.nbscore.TabIndex = 9;
            this.nbscore.Text = "0";
            this.nbscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coeur_3
            // 
            this.coeur_3.BackColor = System.Drawing.Color.Transparent;
            this.coeur_3.Image = global::space_invader.Properties.Resources.coeur;
            this.coeur_3.Location = new System.Drawing.Point(30, 6);
            this.coeur_3.Name = "coeur_3";
            this.coeur_3.Size = new System.Drawing.Size(45, 38);
            this.coeur_3.TabIndex = 10;
            this.coeur_3.TabStop = false;
            // 
            // coeur_2
            // 
            this.coeur_2.BackColor = System.Drawing.Color.Transparent;
            this.coeur_2.Image = global::space_invader.Properties.Resources.coeur;
            this.coeur_2.Location = new System.Drawing.Point(77, 6);
            this.coeur_2.Name = "coeur_2";
            this.coeur_2.Size = new System.Drawing.Size(45, 38);
            this.coeur_2.TabIndex = 11;
            this.coeur_2.TabStop = false;
            // 
            // coeur_1
            // 
            this.coeur_1.BackColor = System.Drawing.Color.Transparent;
            this.coeur_1.Image = global::space_invader.Properties.Resources.coeur;
            this.coeur_1.Location = new System.Drawing.Point(124, 6);
            this.coeur_1.Name = "coeur_1";
            this.coeur_1.Size = new System.Drawing.Size(45, 38);
            this.coeur_1.TabIndex = 12;
            this.coeur_1.TabStop = false;
            // 
            // coeur_vide_1
            // 
            this.coeur_vide_1.Image = global::space_invader.Properties.Resources.coeur_vide;
            this.coeur_vide_1.Location = new System.Drawing.Point(124, 6);
            this.coeur_vide_1.Name = "coeur_vide_1";
            this.coeur_vide_1.Size = new System.Drawing.Size(41, 36);
            this.coeur_vide_1.TabIndex = 13;
            this.coeur_vide_1.TabStop = false;
            this.coeur_vide_1.Visible = false;
            // 
            // coeur_vide_2
            // 
            this.coeur_vide_2.Image = global::space_invader.Properties.Resources.coeur_vide;
            this.coeur_vide_2.Location = new System.Drawing.Point(77, 6);
            this.coeur_vide_2.Name = "coeur_vide_2";
            this.coeur_vide_2.Size = new System.Drawing.Size(41, 36);
            this.coeur_vide_2.TabIndex = 14;
            this.coeur_vide_2.TabStop = false;
            this.coeur_vide_2.Visible = false;
            // 
            // coeur_vide_3
            // 
            this.coeur_vide_3.Image = global::space_invader.Properties.Resources.coeur_vide;
            this.coeur_vide_3.Location = new System.Drawing.Point(30, 6);
            this.coeur_vide_3.Name = "coeur_vide_3";
            this.coeur_vide_3.Size = new System.Drawing.Size(41, 36);
            this.coeur_vide_3.TabIndex = 15;
            this.coeur_vide_3.TabStop = false;
            this.coeur_vide_3.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(878, 53);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // Game
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(877, 570);
            this.Controls.Add(this.coeur_vide_3);
            this.Controls.Add(this.coeur_vide_2);
            this.Controls.Add(this.coeur_vide_1);
            this.Controls.Add(this.coeur_1);
            this.Controls.Add(this.coeur_2);
            this.Controls.Add(this.coeur_3);
            this.Controls.Add(this.nbscore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.ship);
            this.Controls.Add(this.label2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyIsPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_vide_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_vide_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeur_vide_3)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private PictureBox pictureBox1;
        private PictureBox ship;
        private System.Windows.Forms.Timer moveTimer;
        private Label score;
        private Label nbscore;
        private PictureBox coeur_3;
        private PictureBox coeur_2;
        private PictureBox coeur_1;
        private PictureBox coeur_vide_1;
        private PictureBox coeur_vide_2;
        private PictureBox coeur_vide_3;
        private Label label2;
    }
}