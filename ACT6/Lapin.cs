using System;
using System.Collections.Generic;
using System.Text;

namespace ACT6
{
    class Lapin : Animal
    {
        
        private double _tailleDesOreilles;

        public double TailleDesOreilles
        {
            get { return _tailleDesOreilles; }
            set { _tailleDesOreilles = value; }
        }

        public Lapin(string nom, DateTime dateDeNaissance, string numeroDePuce, double taille,double tailleDesOreilles) : base(nom, dateDeNaissance, numeroDePuce, taille)
        {
            _nom = nom;
            _dateDeNaissance = dateDeNaissance;
            _numeroDePuce = numeroDePuce;
            _taille = taille;
            _tailleDesOreilles = tailleDesOreilles;
        }
        public string FaireDesBonds()
        {
            return "Le lapin fait des bonds.";
        }
    }
}
