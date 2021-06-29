using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace JeuCasino
{
    public partial class Form1 : Form
    {
        private double essais = 0;
        private double gg = 0;
        private double taux;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            pictureBox1.Visible = false;
            lblnb1.Text = Convert.ToString(rand.Next(2,13));
            lblnb2.Text = Convert.ToString(rand.Next(2,13));
            lblnb3.Text = Convert.ToString(rand.Next(2,13));
            lblessais.Text = "Nombre d'essais: "+Convert.ToString(essais = essais+1);

            if (Convert.ToDouble(lblnb1.Text) == 7)
            {
                lblgg.Text = "Jeux gagnés: " + Convert.ToString(gg = gg + 1);
                pictureBox1.Visible = true;
            }
            else
            {
                if (Convert.ToDouble(lblnb2.Text) == 7)
                {
                    lblgg.Text = "Jeux gagnés: " + Convert.ToString(gg = gg + 1);
                    pictureBox1.Visible = true;
                }
                else
                {
                    if (Convert.ToDouble(lblnb3.Text) == 7)
                    {
                        lblgg.Text = "Jeux gagnés: " + Convert.ToString(gg = gg + 1);
                        pictureBox1.Visible = true;
                    }
                }
            }
            taux = gg / essais;
            lbltaux.Text = (taux.ToString("P", CultureInfo.CreateSpecificCulture("hr-HR")));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
