using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectCarServices
{
    public partial class FrmVehiculosC : Form
    {
        public FrmVehiculosC()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormGridCarros carro = new FormGridCarros();
            carro.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmGridCategoria frmGridCategoria = new FrmGridCategoria();
            frmGridCategoria.ShowDialog();
        }
    }
}
