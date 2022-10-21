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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int N, Tam, i;
        public struct Procesos
        {
            public string proc;
        }
        Procesos[] Datos;

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Tam = int.Parse(txtcant.Text);
            Datos = new Procesos[Tam];
            N = 0;
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( N <= Tam - 1)
            {
                Datos[N].proc = cbprocesos.Text;
                limpiar();
                N++;
            }

            else
            {
                MessageBox.Show("No hay Espacio");
            }
        }

        private void btnagrega_Click(object sender, EventArgs e)
        {
            int i = 0;
            string x;
            x = cbprocesos.Text;

            while( i < N && x != Datos[i].proc )
            {
                i++;
            }

            if (i >= N)
            {
                MessageBox.Show(x + "No esta iniciado");
            }
            else
            {
                for (int k = i; k < N - 1; k++)
                {
                    Datos[k].proc = Datos[k + 1].proc;
                }
                N--;
                MessageBox.Show("El proceso " + x + "Se ha terminado");
            }
        }
        void imprimir()
        {
            lbp1.Items.Clear();
            lbp1.Items.Add("El proceso " + "\n");

            for (i = 0; i < N; i++)
            {
                lbp1.Items.Add(Datos[i].proc);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void txtcant_TextChanged(object sender, EventArgs e)
        {

        }

        void limpiar()
        {
            txtcant.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbprocesos.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
