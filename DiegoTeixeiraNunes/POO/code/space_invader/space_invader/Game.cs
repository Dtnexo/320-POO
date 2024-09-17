using space_invader.Resources;
using System.Media;
using System.Numerics;

namespace space_invader
{
    public partial class Game : Form
    {
        SoundPlayer simpleSound = new SoundPlayer(@"D:\2eme\tr1\I320\POO\code\space_invader\space_invader\Resources\shoot.wav");
        bool left = false, right = false;
        int speed = 12;
        int maxBullets = 3;
        int nb;
        int life = 0;
        List<Bullet> bullets = new();
        List<ennemis> ennemis = new();
        List<ennemisBullet> ennemisBullets = new();
        public Game()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void KeyIsDown(object sender, KeyEventArgs e)                                                                   // Key pressed
        {
            if (e.KeyCode == Keys.A)
                left = true;
            if (e.KeyCode == Keys.D)
                right = true;
            if (e.KeyCode == Keys.Escape)
                Environment.Exit(0);
        }
        private void KeyIsPress(object sender, KeyPressEventArgs e)
        {
            //presse sur ESPACE
            if (char.ToUpper(e.KeyChar) == ' ')
            {
                if (bullets.Count < maxBullets)
                {
                    bullets.Add(createBullet(ship.Left + 17, ship.Top - 5));
                    simpleSound.Play();
                }
            }
        }
        private ennemisBullet createEnnemisBullet(int x, int y)
        {
            var ennemisBullet = new ennemisBullet(this, x, y);

            return ennemisBullet;
        }
        private Bullet createBullet(int x, int y)
        {
            var bullet = new Bullet(this, x, y);

            return bullet;
        }
        private ennemis createEnnemis(int x, int y)
        {
            var ennemi = new ennemis(this, x, y);

            return ennemi;
        }
        private void KeyIsUp(object sender, KeyEventArgs e)                                                                     // Key not pressed
        {
            if (e.KeyCode == Keys.A)
                left = false;
            if (e.KeyCode == Keys.D)
                right = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {

            foreach (var ennemi in ennemis.ToList())
            {
                if (ennemi.Bounds.IntersectsWith(ship.Bounds))
                {
                    ennemis.Remove(ennemi);
                    ennemi.Visible = false;
                    life++;
                    if (life == 1)
                        coeur_vide_1.Visible = true;

                    if (life == 2)
                        coeur_vide_2.Visible = true;

                    if (life == 3)
                    {
                        coeur_vide_3.Visible = true;
                        Environment.Exit(0);
                    }
                }
                if (ennemi.Top + speed >= 500)
                {
                    ennemi.Destroy();
                    ennemis.Remove(ennemi);
                    ennemi.Visible = false;
                    life++;
                    if (life == 1)
                        coeur_vide_1.Visible = true;

                    if (life == 2)
                        coeur_vide_2.Visible = true;

                    if (life == 3)
                    {
                        coeur_vide_3.Visible = true;
                        Environment.Exit(0);
                    }
                }
                ennemi.bounds();
            }
            if (left && ship.Left > 0)
                ship.Left -= speed;
            if (right && ship.Left < 820)
                ship.Left += speed;

            foreach (var bullet in bullets.ToList())
            {
                if (bullet.Top - speed <= 0)
                {
                    bullet.Destroy();
                    bullets.Remove(bullet);
                }
                else
                {
                    bullet.Top -= speed;
                }
            }
            foreach (var ennemisBullet in ennemisBullets.ToList())
            {
                if (ennemisBullet.Top - speed >= 500)
                {
                    ennemisBullet.Destroy();
                    ennemisBullets.Remove(ennemisBullet);
                }
                else
                {
                    ennemisBullet.Top += speed;
                }
                if (ennemisBullet.Bounds.IntersectsWith(ship.Bounds))
                {
                    ennemisBullet.Destroy();
                    ennemisBullets.Remove(ennemisBullet);
                    ennemisBullet.Visible = false;
                    life++;
                    if (life == 1)
                        coeur_vide_1.Visible = true;

                    if (life == 2)
                        coeur_vide_2.Visible = true;

                    if (life == 3)
                    {
                        coeur_vide_3.Visible = true;
                        Environment.Exit(0);
                    }
                }
            }
            foreach (var ennemi in ennemis.ToList())
            {
                foreach (var ennemi1 in ennemis.ToList())
                {
                    if (ennemi.Bounds.IntersectsWith(ennemi1.Bounds))
                    {
                        ennemi.colision();
                        ennemi1.colision();
                    }
                }
                foreach (var bullet in bullets.ToList())
                {
                    if (ennemi.Bounds.IntersectsWith(bullet.Bounds))
                    {
                        nb = Convert.ToInt32(nbscore.Text) + 1;
                        nbscore.Text = Convert.ToString(nb);
                        ennemis.Remove(ennemi);
                        bullets.Remove(bullet);
                        ennemi.Visible = false;
                        bullet.Visible = false;
                    }
                }
            }
            foreach (var ennemi in ennemis.ToList())
            {
                ennemi.bounds();
            }
            Random rnd = new Random();
            int timeRandom = rnd.Next(0, 40);
            int boundsen = rnd.Next(0, 30);
            int posx = rnd.Next(0, 800);
            int posy = rnd.Next(0, 200);
            int y = rnd.Next(0,50);
            int x = rnd.Next(0,800);
            if (timeRandom == 32)
            {
                ennemis.Add(createEnnemis(posx, posy));
            }
            if (boundsen == 26)
            {
                ennemisBullets.Add(createEnnemisBullet(x, y));
            }
        }
    }
}
