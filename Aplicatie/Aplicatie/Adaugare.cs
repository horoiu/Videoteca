using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Pentru lucrul cu fisiere si directoare

namespace Aplicatie
{
    public partial class Adaugare : Form
    {
        // Fereastra de dialog pentru alegere fisier
        OpenFileDialog fleDlg = new OpenFileDialog();
        DataTable domeniiDT;
        String denumire, imagineFilm, anFilm, totalFilme;
        Int16 idDomeniu;
        // Folderul implicit - directorul curent relativ la fis. .exe
        // String selFldr = Application.StartupPath;

        public Adaugare(string tipAdaugare)
        {
            InitializeComponent();
            if (tipAdaugare == "D")
                elimin_Obiecte();
            else
            {
                completez_ComboBoxDomeniul();
                buttonAdauga.Text = "Adauga filmul";
                buttonAdauga.AutoSize = true;
            }
        }

        private void buttonSelectImg_Click(object sender, EventArgs e)
        {
            // Selectam fisierul imagine - afisul filmului - din folderul \Poze
            fleDlg.Filter = "Image Files|*.jpg"; // Ce tip de fisiere sa fie aratate in fereastra
            fleDlg.Title = "Selecteaza fisierul imagine"; // Textul din titlul ferestrei
                                                          // Deschidem o fereastra de dialog (folderul cu imaginile, \Poze) pentru selectarea imaginii
            fleDlg.InitialDirectory = Directory.GetCurrentDirectory() + @"\Poze";
            if (fleDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) //A fost apasat butonul OK
            {
                // Calea completa a fisierului:
                string caleFisier = fleDlg.FileName;
                // Separam bucatile din path complet - ce se afla intre \\
                string[] numeFisier = @caleFisier.Split('\\');
                // Luam doar ultima parte (bucata) - numele fisierului - este la sfarsitul path-ului
                textBoxImagine.Text = numeFisier[numeFisier.Length - 1];
            }
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            if (buttonAdauga.Text == "Adauga domeniul")
            {
                denumire = textBoxDenumire.Text;
                try
                {
                    // Daca nu au fost completate toate datele "aruncam" o exceptie
                    if (denumire == "") throw new Exception("Completati denumirea domeniului");
                    // Daca nu a iesit din cauza exceptiei scriem cate o informatie pe un rand
                    Adaugare_DB.inregistrez_domeniu_in_BD(denumire);
                    MessageBox.Show("Am adaugat");
                    // Golim continutul obiectelor din interfata
                    textBoxDenumire.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                denumire = textBoxDenumire.Text;
                idDomeniu = Convert.ToInt16(comboBoxDomeniul.SelectedValue.ToString());
                anFilm = textBoxAnul.Text;
                imagineFilm = textBoxImagine.Text;
                totalFilme = textBoxNrTotal.Text;
                try
                {
                    // Daca nu au fost completate toate datele "aruncam" o exceptie
                    if (denumire == "" || imagineFilm == "" || anFilm == "" || totalFilme == "")
                        throw new Exception("Completati toate informatiile");
                    // Daca nu a iesit din cauza exceptiei scriem cate o informatie pe un rand
                    Adaugare_DB.inregistrez_film_in_BD(denumire, imagineFilm,
                    Convert.ToInt16(idDomeniu), Convert.ToInt16(anFilm), Convert.ToInt16(totalFilme));
                    MessageBox.Show("Am adaugat");
                    // Golim continutul obiectelor din interfata
                    textBoxDenumire.Text = "";
                    textBoxNrTotal.Text = "";
                    textBoxAnul.Text = "";
                    textBoxImagine.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            textBoxDenumire.Text = "";
            textBoxNrTotal.Text = "";
            textBoxAnul.Text = "";
            textBoxImagine.Text = "";
            this.Close();
        }

        private void completez_ComboBoxDomeniul()
        {
            comboBoxDomeniul.Items.Clear();
            // Apelam metoda care interogheaza tabela domenii si depune rezultatul intr-un DataTable
            domeniiDT = Interogari_DB.selectez_Domenii();
            // DataTable din care sunt preluate datele pentru comboBoxDomenii
            comboBoxDomeniul.DataSource = domeniiDT;
            // Valoarea din coloana idd nu se afiseaza in comboBoxDomenii
            comboBoxDomeniul.ValueMember = "idd";
            // Denumirea domeniului afisata in comboBoxDomenii, preluata din:
            // DataTable domeniiDT - coloana "denumire"
            comboBoxDomeniul.DisplayMember = "denumire";
        }

        private void elimin_Obiecte()
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            comboBoxDomeniul.Hide();
            textBoxAnul.Hide();
            textBoxImagine.Hide();
            textBoxNrTotal.Hide();
            buttonRenunta.Hide();
            buttonSelectImg.Hide();
            buttonAdauga.Location = new System.Drawing.Point(114, 65);
            buttonAdauga.Text = "Adauga domeniul";
            buttonAdauga.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(317, 120);
        }

        private void Adaugare_Load(object sender, EventArgs e)
        {

        }
    }
}
