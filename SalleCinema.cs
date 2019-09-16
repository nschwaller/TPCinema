using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinéma
{
    class SalleCinema
    {
        private string nom;
        private int nbplace;
        private double tarifN;
        private int NormalVendu;
        private int ReduitVendu;

        public SalleCinema(string lenom,int lenbplace, double letarifN)
        {
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

        public void vendrePlaces(int nbre, bool tarifReduit)
        {
            if ((this.nbPlacesDisponibles() - nbre) > 0)
            {
                double vendre;
                if (tarifReduit)
                {
                    vendre = ((this.tarifN * nbre) * 0.80);
                    MessageBox.show("Vous devez payer " + vendre);
                    this.ReduitVendu += nbre;
                }
                else
                {
                    vendre = this.tarifN = nbre;
                    MessageBox.show("Vous devez payer " + vendre);
                    this.NormalVendu += nbre;
                }
            }
            else
            {
                MessageBox.show("Il n'y a pas assez de place disponible pour vous" + vendre);
            }

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

            return ((this.NormalVendu + this.ReduitVendu) / this.nbplace * 100);
        }
    }
}
