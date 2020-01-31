using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicatie
{
    public partial class ModificareDate : Form
    {
        static MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID=root; database = dbvideoteca");
        MySqlDataAdapter adapt;
        DataTable filmeleDT = new DataTable();
        MySqlCommandBuilder cb;

        public ModificareDate()
        {
            InitializeComponent();
        }

        private void ModificareDate_Load(object sender, EventArgs e)
        {

        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                adapt = new MySqlDataAdapter("SELECT * FROM filme", conn);
                // Doar pentru vizualizare date comanda SELECT poate contine date din mai multe tabele: 
                // nr total AS 'Numar total', nrdisponibile AS Disponibile, d.denumire AS Domeniul FROM filme f JOIN domenii d on idd = iddomeniu order by f.denumire", conn);
                //dataGridView1.ReadOnly = true; // Nu pot fi facute modificari - ReadOnly
                filmeleDT.Clear();
                adapt.Fill(filmeleDT);
                dataGridViewFilme.DataSource = filmeleDT;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModificare_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cb = new MySqlCommandBuilder(adapt);
                adapt.Update(filmeleDT);
                MessageBox.Show("Am modificat tabela Filme");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
