using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagina
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void ejecucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Nuevo = new Form1();
            Nuevo.MdiParent = this;
            Nuevo.Show();

        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manual Nuevo = new Manual();
            Nuevo.MdiParent = this;
            Nuevo.Show();
        }
    }
}
