using System;
using System.Collections.Generic;
using System.Text;

namespace ACT6
{
    class Animal
    {
        protected string _nom;
        protected DateTime _dateDeNaissance;
        protected string _numeroDePuce;
        protected double _taille;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }       
        public DateTime DateDeNaissance
        {
            get { return _dateDeNaissance; }
            set { _dateDeNaissance = value; }
        }
        public  string NumeroDePuce
        {
            get { return _numeroDePuce; }
            set { _numeroDePuce = value; }
        }
        public double Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }


        public string Dormir()
        {
            return "L'animal dort.";
        }

        public string Manger()
        {
            return "L'animal mange.";
        }
    }

}
