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
    public partial class FormFacturacion : Form
    {
        CSItems items = new CSItems();
        public FormFacturacion()
        {
            InitializeComponent();
        }

        private void FormFacturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PROYECT_3DataSet.DataTable1' Puede moverla o quitarla según sea necesario.
            this.factura.Fill(this.PROYECT_3DataSet.DataTable1, items.Codigo_Factura);

            this.reportViewer1.RefreshReport();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su compra", "CarWash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmUsuarioEmpleado usuarioEmpleado = new FrmUsuarioEmpleado();
            this.Hide();
        }
    }
}
