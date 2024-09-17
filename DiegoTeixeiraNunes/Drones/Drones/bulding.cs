using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    class bulding
    {
        protected int _x, y;
        protected int _largeur;
        protected int _profondeur;
        protected string _couleur;
        
        public bulding(int posx, int posy, int width , int height, string color) 
        { 
            _x = posx;
            _couleur = color;
            _y = posy;
            _largeur = width;
        }    
    }
}
