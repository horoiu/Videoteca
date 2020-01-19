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
    public partial class Confirmare : Form
    {
        public Confirmare(string mesaj)
        {
            InitializeComponent();
            labelConfirmare.Text = mesaj;
        }

        private void Confirmare_Load(object sender, EventArgs e)
        {

        }
    }
}
