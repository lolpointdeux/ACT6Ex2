using System;
using System.Collections.Generic;
using System.Text;

namespace ACT6
{
    class Chien : Animal
    {
        private bool _animalDeConcours;

        public bool AnimalDeConcours
        {
            get { return _animalDeConcours; }
            set { _animalDeConcours = value; }
        }

        public Chien(string nom, DateTime dateDeNaissance, string numeroDePuce, double taille, bool animalDeConcours):base(nom,dateDeNaissance,numeroDePuce,taille)
        {
            _nom = nom;
            _dateDeNaissance = dateDeNaissance;
            _numeroDePuce = numeroDePuce;
            _taille = taille;
            _animalDeConcours = animalDeConcours;
        }
    }
}
