using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // Pentru ArrayList

namespace Aplicatie
{
    public partial class Restituire : Form
    {
        DataTable clientiDT = new DataTable();
        // dataTable pentru umplere lista clienti
        DataTable filmeDT = new DataTable();
        // dataTable pentru umplere lista filme

        public Restituire()
        {
            InitializeComponent();
            Completez_ComboBoxClienti();
            int idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);
            Completez_CheckList_FilmeImprumutateDeUnClient(idClient);
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            // Parcurgem lista filmelor si debifam tot ce a fost bifat
            goleste_checkedListBoxFilme();
            this.Close();
        }

        private void Completez_ComboBoxClienti()
        {
            comboBoxClienti.Items.Clear();
            // Apelam metoda care interogheaza tabela clienti si depune rezultatul in: DataTable clientiDT
             clientiDT = Interogari_DB.selectez_Clienti();
            // DataTable clientiDT este folosit ca sursa de date pentru comboBoxClienti
            comboBoxClienti.DataSource = clientiDT;
            // Valoarea din coloana "idc" se asociaza fiecarui item
            // din comboBoxClienti dar nu se afiseaza in comboBoxClienti
            comboBoxClienti.ValueMember = "idc";
            // Infirmatiile (nume, adresa, CNP) afisate in comboBoxClienti, preluate din clientiDT
            comboBoxClienti.DisplayMember = "informatii";
        }

        void Completez_CheckList_FilmeImprumutateDeUnClient(int idClient)
        {
            filmeDT = Interogari_DB.selectez_FilmeDeRestituit(idClient);
            checkedListBoxFilme.Items.Clear();
            checkedListBoxFilme.DataSource = filmeDT;
            checkedListBoxFilme.ValueMember = "idf";
            // Elementele afisate in ComboBox, preluate din concatenarea mai multor coloane din DataTable
            checkedListBoxFilme.DisplayMember = "date_film";
        }

        private void comboBoxClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                int idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);
                filmeDT.Clear();
                checkedListBoxFilme.DataSource = null;
                Completez_CheckList_FilmeImprumutateDeUnClient(idClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Restituire_Load(object sender, EventArgs e)
        {

        }

        private void buttonInregistreaza_Click(object sender, EventArgs e)
        {
            if (checkedListBoxFilme.CheckedIndices.Count > 0)
            {
                Confirmare c = new Confirmare("Confirmati restituirea?");
                DialogResult dr = c.ShowDialog();
                ArrayList listaFilmeDeRestituit = new ArrayList();
                if (dr == DialogResult.Yes)
                {
                    int idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);
                    int idFilm;
                    try
                    {
                        foreach (int i in checkedListBoxFilme.CheckedIndices)
                        {
                            checkedListBoxFilme.SelectedIndex = i;
                            idFilm = Convert.ToInt32(checkedListBoxFilme.SelectedValue);
                            listaFilmeDeRestituit.Add(idFilm);
                        }
                        Restituire_DB.Inregistrez_restituire_in_BD(listaFilmeDeRestituit, idClient);
                        // Dupa inregistrarea restituirii o parte din filme au fost restituite iar altele nu, sau toate au fost restituite
                     // Reincarc in CheckList cu Filme noua lista cu filmele ramase nerestituite
                     // Pentru asta "resetez" datele din dataTable filmeT (sursa pentru checkedListFilme.DataSource)
                        MessageBox.Show("Restituirea s-a efectuat cu succes");
                        filmeDT.Clear();
                        checkedListBoxFilme.DataSource = null;
                        Completez_CheckList_FilmeImprumutateDeUnClient(idClient);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Restituirea NU a fost inregistrata");
                    goleste_checkedListBoxFilme();
                }
            }
            else MessageBox.Show("NU ati selectat nici un film!");
        }

        private void goleste_checkedListBoxFilme()
        {
            checkedListBoxFilme.ClearSelected();
            // deselecteaza filmul selectat
            foreach (int i in checkedListBoxFilme.CheckedIndices)
                checkedListBoxFilme.SetItemChecked(i, false);
            // debifeaza filmele bifate
        }


    }
}
