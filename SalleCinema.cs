using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinéma
{
    class SalleCinema
    {
        private int numeroSalle;
        private string nom;
        private int nbplace;
        private double tarifN;
        private int NormalVendu;
        private int ReduitVendu;

        public SalleCinema(string lenom,int lenbplace, double letarifN,int lenumero)
        {
            this.numeroSalle = lenumero;
            this.nom = lenom;
            this.nbplace = lenbplace;
            this.tarifN = letarifN;
            this.NormalVendu = 0;
            this.ReduitVendu = 0;
        }

        public int nbPlacesDisponibles()
        {
            return (nbplace - (NormalVendu + ReduitVendu));
        }

        public string vendrePlaces(int nbre, bool tarifReduit)
        {
            string affichage;
            if ((this.nbPlacesDisponibles() - nbre) >= 0)
            {
                double vendre;
                if (tarifReduit)
                {
                    vendre = ((this.tarifN * nbre) * 0.80);
                    affichage="Vous devez payer " + vendre + "€";
                    this.ReduitVendu += nbre;
                }
                else
                {
                    vendre = this.tarifN * nbre;
                    affichage="Vous devez payer " + vendre + "€";
                    this.NormalVendu += nbre;
                }
            }
            else
            {
               affichage="Il n'y a pas assez de place disponible pour vous";
            }

            return affichage;
        }

        public void remiseAZero()
        {
            this.NormalVendu = 0;
            this.ReduitVendu = 0;
        }

        public double chiffreAffaire()
        {
            return ((this.NormalVendu * tarifN) + (this.ReduitVendu * (tarifN * 0.80)));
        }

        public double tauxRemplissage()
        {
            double total = (this.NormalVendu + this.ReduitVendu);
            double division = total / this.nbplace;
            return division*100;
        }

        public string toString()
        {
            return ("Filme joué : " + this.nom + ", \n Nombre de places : " + this.nbplace + " , \n Prix d'une place : " + this.tarifN + " , \n" + this.NormalVendu + " places vendues au tarif normal , \n" + this.ReduitVendu + " places vendues au tarif réduit.");
        }

        public int getnumerosalle()
        {
            return this.numeroSalle;
        }
    }
}
