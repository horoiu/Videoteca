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
    public partial class Imprumut : Form
    {
        int idDomeniu;
        DataTable clientiDT;
        DataTable domeniiDT;
        DataRow domeniiDR;
        DataTable filmeDT;

        public Imprumut()
        {
            InitializeComponent();
            // In dateTimePickerDataRest se vor afisa doar
            // datele calendaristice ulterioare datei de astazi
            dateTimePickerDataRest.MinDate = DateTime.Now.AddDays(1);
            try
            {
                // Completez la pornire lista clientilor si lista cu domeniile filmelor
                Completez_ComboBoxClienti();
                Completez_ComboBoxDomenii();
                // Completez la pornire toate filmele, parametrul: - idDomeniu = 0
                Completez_checkedListBoxFilme(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Imprumut_Load(object sender, EventArgs e)
        {

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
            // Denumirea domeniului afisata in comboBoxClienti, preluata din DataTable
            comboBoxClienti.DisplayMember = "informatii";
        }

        private void Completez_ComboBoxDomenii()
        {
            comboBoxDomenii.Items.Clear();
            // Apelam metoda care interogheaza tabela domenii si depune rezultatul intr-un DataTable
            domeniiDT = Interogari_DB.selectez_Domenii();
            // Pentru optiunea "--Toate domeniile--" adaugam un rand cu idd=0
            // la inceputul: DataTable domeniiDT
            domeniiDR = domeniiDT.NewRow();
            domeniiDR["idd"] = "0";
            domeniiDR["denumire"] = "--Toate domeniile--";
            domeniiDT.Rows.InsertAt(domeniiDR, 0);
            // DataTable din care sunt preluate datele pentru comboBoxDomenii
            comboBoxDomenii.DataSource = domeniiDT;
            // Valoarea din coloana idd nu se afiseaza in comboBoxDomenii
            comboBoxDomenii.ValueMember = "idd";
            // Denumirea domeniului afisata in comboBoxDomenii, preluata din:
            // DataTable domeniiDT - coloana "denumire"
            comboBoxDomenii.DisplayMember = "denumire";
        }

        public void Completez_checkedListBoxFilme(int idDomeniu)
        {
            try
            {
                filmeDT = Interogari_DB.selectez_FilmeDisponibile(idDomeniu);
                // Am incarcat in DataTable filmeDT filmele din domeniul selectat
                // apoi setez acest filmeDT ca sursa de date pentru checkedListBoxFilme
                // din care se afiseaza coloana "date_film" fiecare rand cu id asociat "idf"
                checkedListBoxFilme.DataSource = filmeDT;
                checkedListBoxFilme.ValueMember = "idf";
                checkedListBoxFilme.DisplayMember = "date_film";
                if (checkedListBoxFilme.Items.Count == 0)// sau: (filmeDT.Rows.Count == 0)
                {
                    MessageBox.Show("Nu mai sunt filme disponibile din domeniul " +
                   comboBoxDomenii.SelectedText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxDomenii_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                // Cand selectam un alt domeniu din comboBoxDomenii trebuie sa
                // reincarcam lista filmelor cu filmele din domeniul selectat
                idDomeniu = Convert.ToInt32(comboBoxDomenii.SelectedValue.ToString());
                Completez_checkedListBoxFilme(idDomeniu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInregistreaza_Click(object sender, EventArgs e)
        {
            ArrayList idFilmeArrayList = new ArrayList();
            int idFilm, idClient;

            try
            {
                idClient = Convert.ToInt32(comboBoxClienti.SelectedValue);
                // Parcurgem lista cu filmele bifate- .CheckedIndices
                // facem ca fiecare dintre cei bifati, pe rand, sa devina .SelectedIndex
                // preluam idFilm de la fiecare item devenit selected, pe rand, si il adaugam in lista "ArrayList idFilme"
            foreach (int i in checkedListBoxFilme.CheckedIndices)
                {
                    checkedListBoxFilme.SelectedIndex = i;
                    idFilm = Convert.ToInt32(checkedListBoxFilme.SelectedValue);
                    idFilmeArrayList.Add(idFilm);
                }
                if (idFilmeArrayList.Count == 0) throw new Exception("Bifati cel putin un film!");
                Confirmare c = new Confirmare("Confirmati imprumutul?");
                DialogResult dr = c.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    Imprumut_DB.inregistrez_imprumut_in_BD(idClient, idFilmeArrayList, dateTimePickerDataRest.Value.Date);
                    MessageBox.Show("Imprumutul a fost inregistrat in baza de date");
                    // Dupa inregistrarea imprumutului o parte din filme s-au epuizat, nu mai sunt disponibile pentru imprumut
                    // Reincarc in checkedListBoxFilme noua lista cu filmele ramase dupa imprumut 
                    // Pentru asta "resetez" datele din dataTable filmeDT (.DataSource pentru checkedListFilme)
                    filmeDT.Clear();
                    checkedListBoxFilme.DataSource = null;
                    idDomeniu = Convert.ToInt32(comboBoxDomenii.SelectedValue.ToString());
                    Completez_checkedListBoxFilme(idDomeniu);
                }
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Imprumutul nu a fost inregistrat");
                    // Nu facem nici o actiune
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void goleste_checkedListBoxFilme()
        {
            checkedListBoxFilme.ClearSelected();
            // deselecteaza filmul selectat
            foreach (int i in checkedListBoxFilme.CheckedIndices)
            checkedListBoxFilme.SetItemChecked(i, false);
            // debifeaza filmele bifate
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            // Parcurgem lista filmelor si debifam tot ce a fost bifat
            goleste_checkedListBoxFilme();
        }
    }
}
