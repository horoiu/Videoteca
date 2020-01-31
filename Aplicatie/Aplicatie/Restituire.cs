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
    public partial class Restituire : Form
    {
        public Restituire()
        {
            InitializeComponent();
        }

        private void buttonRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
