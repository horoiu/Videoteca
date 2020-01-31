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
    public partial class Form1 : Form
    {
        int login; // login =0 cand nu este logat nimeni; =1 pt. admin; =2 pt. angajat;
        string userTastat, parolaTastata, user_role;

        public Form1()
        {
            InitializeComponent();
            ascundeMeniuTot();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adaugaDomeniiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Actiunea click pe optiunea "Adauga domeniu" va transmite
            // valoarea unui parametru "D" -domeniu- in clasa Adaugare
            Adaugare adaug = new Adaugare("D");
            adaug.ShowDialog();
        }

        private void adaugaFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adaugare adaug = new Adaugare("F");
            adaug.ShowDialog();
        }

        private void afisareFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Afisare afis = new Afisare();
            afis.ShowDialog();
        }

        private void imprumutaFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprumut impr = new Imprumut();
            impr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (login == 0)
                {
                    //Preluam user si parola, stergem eventualele spatii de la inceputul si sfarsitul numelui utilizator
                    userTastat = textBoxUser.Text.Trim();
                    parolaTastata = textBoxParola.Text;
                    if (userTastat == "") throw new Exception("Completati campul User");
                    if (parolaTastata == "") throw new Exception("Completati campul Parola");

                    // Cautam in baza de date DBvideoteca combinatia user+parola care au fost tastate
                    // Daca gasim o inregistrare ce corespunde: aducem din baza de date
                    // denumirea rolului acelui user, altfel user_role ramane sirul vid =""
                    user_role = Interogari_DB.caut_User(userTastat, parolaTastata);
                    if (user_role == "admin")
                    { // Daca rolul este de administrator ="admin" are drepturi depline
                        login = 1;
                        filmeToolStripMenuItem.Visible = true;
                        clientiToolStripMenuItem.Visible = true;
                        button1.Text = "Log out";
                    }
                    if (user_role == "angajat")
                    { //Daca rolul este ="angajat" nu are dreptul sa acceseze meniul Filme
                      // ca sa adauge un domeniu sau un film in BD
                        login = 2;
                        clientiToolStripMenuItem.Visible = true;
                        button1.Text = "Log out";
                    }
                    if (login == 0)
                        throw new Exception("User sau Parola incorecte");
                }
                else
                {
                    // A fost apasat butonul log-out. Resetam controalele, ascundem meniul
                    textBoxUser.Text = "";
                    textBoxParola.Text = "";
                    ascundeMeniuTot();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void restituieFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restituire restit = new Restituire();
            restit.ShowDialog();
        }

        private void ascundeMeniuTot()
        {
            // Ascundem din meniu optiunile Filme si Clienti .Visible = false;
            // (care va deveni vizibil dupa ce operatia log-in a avut succes)
            // Daca am vrea sa ascundem meniul in intregime:
            // menuStrip1.Hide(); menuStrip1.Show();
            filmeToolStripMenuItem.Visible = false;
            clientiToolStripMenuItem.Visible = false;
            button1.Text = "Log in";
            login = 0;
            userTastat = parolaTastata = "";
        }
    }
}
