using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Runtime.CompilerServices;

namespace Boat
{

    public class Boat : IBoat 
    {
        // Propriétés du bateau
        string Name { get; set; }
        float MaxCargoWeight { get; set; }
        int MaxSpeed { get; set; }

        public Boat(string nom, float largeurMaxCargo, int Maxvitesse)
        {
            Name = nom;
            MaxCargoWeight = largeurMaxCargo;
            MaxSpeed = Maxvitesse;
        }
        public void Start() 
        { }  // Démarrer le bateau
        public bool LoadContainer(IContainer container) 
        {
            return true;
        }
        // Charger un container
        bool UnloadContainer(IContainer container) 
        {
            return true;
        }  // Décharger un container
    }
}