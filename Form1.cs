using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinéma
{
    public partial class Form1 : Form
    {
        private List<SalleCinema> lesSalles;

        public Form1()
        {
            InitializeComponent();
            creerJeuEssai();
        }

        public void creerJeuEssai()
        {
            SalleCinema cine = new SalleCinema("Gozilla", 60, 4.75, 1);
            SalleCinema cine2 = new SalleCinema("HarryPotter", 100, 3.75, 2);
            SalleCinema cine3 = new SalleCinema("Romain", 50, 2.50, 3);
            SalleCinema cine4 = new SalleCinema("Théo", 40, 5.50, 4);

            lesSalles = new List<SalleCinema>();

            lesSalles.Add(cine);
            lesSalles.Add(cine2);
            lesSalles.Add(cine3);
            lesSalles.Add(cine4);
        }
    

        private void Valider_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(tb_numerosalle.Text) > 4)|| (Convert.ToInt32(tb_numerosalle.Text) == 0))
            {
                MessageBox.Show("Erreur de numero de salle");
            }
            else
            {
                foreach (SalleCinema salle in lesSalles)
                {
                    if (Convert.ToInt32(tb_numerosalle.Text) == salle.getnumerosalle())
                    {
                        //panel1.Visible = false;
                        cache.Visible = true;
                        lestring.Text = salle.toString();
                        labelcache.Text = tb_numerosalle.Text;
                    }
                }
            }
        }

        private void Nbplace_Click(object sender, EventArgs e)
        {
            foreach (SalleCinema salle in lesSalles)
            {
                if (Convert.ToInt32(labelcache.Text) == salle.getnumerosalle())
                {
                  affiche.Text=salle.vendrePlaces(Convert.ToInt32(tb_nbplace.Text), cb_reduction.Checked);
                  lestring.Text = salle.toString();
                  chiffreaf.Text =Convert.ToString(salle.chiffreAffaire());
                 // MessageBox.Show(Convert.ToString(salle.tauxRemplissage()));
                  taux.Text = Convert.ToString(salle.tauxRemplissage());
                  pntout.Visible = true;
                }
            }
        }

    }
}
