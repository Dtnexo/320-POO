using Drones.Helpers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Drones
{
    
    public enum EvacuationState
    {
        Evacuating,     // Limits known, moving out of the zone
        Free,           // No limits applied
        Evacuated       // Limits known, out of the zone
    }

    public interface IExpellable
    {
        // Signal the limits of the no-fly zone 
        // Return true if the drone is already outside the zone
        public bool Evacuate(Rectangle zone);

        // Terminate the no-fly zone
        public void FreeFlight();

        // Interrogate the drone
        public EvacuationState GetEvacuationState();
    }
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        Random alea = new Random();

        public static int charge;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x ;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        public bool zone;
        private Pen NoflyBrush = new Pen(new SolidBrush(Color.Black), 3);
        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public Drone (string nom, int corx, int cory)
        {
            _name = nom;
            _x = corx;
            _y  = cory;
            charge = GlobalHelper.Fullcharge.Next(1000);
        }
        public void Update(int interval)
        {
            _x += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            _y += alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            charge--;                                  // Il a dépensé de l'énergie
        }

        public bool Evacuate(Rectangle zone)
        {
            if (_x > zone.X && _x < zone.X+zone.Width && _y > zone.Y && _y < zone.Y+zone.Width)
            {
                while (_x > zone.X && _x < zone.X + zone.Width)
                {
                    _x--;
                }
                while (_y > zone.Y && _y < zone.Y + zone.Width)
                {
                    _y--;
                }
                return true;
            }
            return false;
        }
        public void FreeFlight() 
        {
            if (_x < 400)
            {
                zone = true;
            }
            zone = false;   

        }
        public EvacuationState GetEvacuationState()
        {
            if(zone)
                return EvacuationState.Free;
            if (zone!)
            {
                return EvacuationState.Evacuating;
            }
            return EvacuationState.Free;
        }
    }
}
