using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Afisare : Form
    {
        int idCurentPrim = 0;
        int idCurentUltim = 0;
        int randuriFilmeDT; // Numarul de filme adus, poate avea valoarea 0, 1, 2 sau 3
        DataTable filmeDT; // "Recipientul" pentru filmele aduse din baza de date
        DataRow filmeDR; // va pastra, pe rand, cate o inregistrare -film- din DataTable 

        public Afisare()
        {
            InitializeComponent();
            labelTitlu.Text += DateTime.Now.ToShortDateString();
            completeazaFilme(ref idCurentPrim, ref idCurentUltim, 1);
        }

        private void reseteazaFilme()
        {
            pictureBox1.Image = null;
            textBox1.Text = "";
            pictureBox2.Image = null;
            textBox2.Text = "";
            pictureBox3.Image = null;
            textBox3.Text = "";
        }

        public void completeazaFilme(ref int idCurentPrim, ref int idCurentUltim, int dir)
        {
            try
            {
                filmeDT = Interogari_DB.selectez_Filme(idCurentPrim, idCurentUltim, dir);
                randuriFilmeDT = filmeDT.Rows.Count;

                if (randuriFilmeDT > 0)
                {
                    reseteazaFilme();
                    filmeDR = filmeDT.Rows[0];
                    idCurentPrim = Convert.ToInt32(filmeDR["idf"]);
                    idCurentUltim = Convert.ToInt32(filmeDR["idf"]);
                    textBox1.Text = filmeDR["denFilm"] + Environment.NewLine + "Domeniul: " + filmeDR["denDomeniu"] + Environment.NewLine + "Disponibile: " + filmeDR["nrdisponibile"];
                    pictureBox1.Image = Image.FromFile("Poze\\" + filmeDR["imagine"]);
                    pictureBox1.Visible = true;

                    if (randuriFilmeDT > 1)
                    {
                        filmeDR = filmeDT.Rows[1];
                        idCurentUltim = Convert.ToInt32(filmeDR["idf"]);
                        textBox2.Text = filmeDR["denFilm"] + Environment.NewLine + "Domeniul: " + filmeDR["denDomeniu"] + Environment.NewLine + "Disponibile: " + filmeDR["nrdisponibile"];
                        pictureBox2.Image = Image.FromFile("Poze\\" + filmeDR["imagine"]);
                        pictureBox2.Visible = true;

                        if (randuriFilmeDT > 2)
                        {
                            filmeDR = filmeDT.Rows[2];
                            idCurentUltim = Convert.ToInt32(filmeDR["idf"]);
                            textBox3.Text = filmeDR["denFilm"] + Environment.NewLine + "Domeniul: " + filmeDR["denDomeniu"] + Environment.NewLine + "Disponibile: " + filmeDR["nrdisponibile"];
                            pictureBox3.Image = Image.FromFile("Poze\\" + filmeDR["imagine"]);
                            pictureBox3.Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInainte_Click(object sender, EventArgs e)
        {
            completeazaFilme(ref idCurentPrim, ref idCurentUltim, 1);
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            completeazaFilme(ref idCurentPrim, ref idCurentUltim, -1);
        }
    }
}
