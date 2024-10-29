using System;
using System.Collections.Generic;



namespace Boat
{
    public interface IBoat
    {
        // Propriétés du bateau
        public string Name { get; }
        public float MaxCargoWeight { get; }
        public int MaxSpeed { get; }

        // Méthodes pour le bateau
        void Start();  // Démarrer le bateau
        bool LoadContainer(IContainer container);  // Charger un container
        bool UnloadContainer(IContainer container);  // Décharger un container
    }
}
