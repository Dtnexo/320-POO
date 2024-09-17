using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    class building
    {
        protected int _x,_y;
        protected int _largeur;
        protected int _profondeur;
        protected string _couleur;
        private Pen build = new Pen(new SolidBrush(Color.Purple), 3);
        public building(int posx, int posy, int width , int height, string color) 
        { 
            _x = posx;
            _couleur = color;
            _y = posy;
            _largeur = width;
            _profondeur = height;
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(build, new Rectangle(_x - 4, _y - 2, 8, 8));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, _x + 5, _y - 5);
        }
    }
}
