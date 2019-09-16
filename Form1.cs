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
        public Form1()
        {
            InitializeComponent();
        }

        SalleCinema cine = new SalleCinema("Gozilla", 60, 4.75, 1);
        SalleCinema cine2 = new SalleCinema("HarryPotter", 100, 3.75, 2);
        SalleCinema cine3 = new SalleCinema("Romain", 50, 2.50, 3);
        SalleCinema cine4 = new SalleCinema("Théo", 40, 5.50, 4);

        private void Valider_Click(object sender, EventArgs e)
        {

        }
    }
}
