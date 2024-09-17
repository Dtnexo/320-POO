using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoProf
{
    class compteBancaire    
    {
        protected int _Amount;
        protected int _pin;
        protected string _owner;
        protected int _devise;

        protected void afficherSolde() 
        {
            Console.WriteLine();
        }
        protected void Retirer() { }
        protected void Ajouter() { }
        public compteBancaire(int amount, int pin, string owner, int devise)
        {
            _Amount = amount;
            _pin = pin;
            _owner = owner;
            _devise = devise;
        }
    }
    class compteEpargne : compteBancaire 
    {
        private int _ohbien;
        public compteEpargne(int amount, int pin, string owner, int devise, int ohbien) : base(amount, pin, owner, devise) 
        {
            _ohbien = ohbien;
        }
        
            
        
    }

    class compteCourrant : compteBancaire 
    {
        private int _solde;
        public compteCourrant(int amount, int pin, string owner, int devise, int solde) : base(amount, pin, owner, devise) 
        {
            _solde = solde;
        }
    }
}
