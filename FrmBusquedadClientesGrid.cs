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
    public partial class FrmBusquedadClientesGrid : Form
    {
        public CSMuestrasGrid showG = new CSMuestrasGrid();
        public CSHerramientaBaseDatos datos = new CSHerramientaBaseDatos();
        public CSItems items = new CSItems();
        public int offset = 0;
        public int valid = 0;
        public FrmBusquedadClientesGrid()
        {
            InitializeComponent();
        }

        private void FrmBusquedadClientesGrid_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CLIENTES");

            this.comboBox_cantS.Items.Add("S/F");
            this.comboBox_cantS.Items.Add(5);
            this.comboBox_cantS.Items.Add(10);
            this.comboBox_cantS.Items.Add(20);
        }
        private void filtro_Grid(String filtro)
        {
            DataTable sourceDGV = showG.GetData("SELECT * FROM CLIENTES " +
                "WHERE NOMBRE LIKE '%" + filtro + "%' " +
                "OR APELLIDO LIKE '%" + filtro + "%' " +
                "OR IDENTIDAD LIKE '%" + filtro + "%'");

            Muestra_Grid.DataSource = sourceDGV;
        }

        private void txt_FiltroB_TextChanged(object sender, EventArgs e)
        {
            this.filtro_Grid(txt_FiltroB.Text);
        }

        private void comboBox_cantS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_cantS.SelectedIndex.Equals(0))
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CLIENTES");

            else
            {
                this.offset = 0;
                showG.Show_Grid("SELECT * FROM CLIENTES ORDER BY CODIGO_CLIENTE", this.Muestra_Grid,
                    offset, Convert.ToInt32(comboBox_cantS.Text));
            }
        }

        private void pictureBox_dirLeft_Click(object sender, EventArgs e)
        {
            if (!(comboBox_cantS.SelectedIndex.Equals(-1)) && !(comboBox_cantS.SelectedIndex.Equals(0)) && offset > 0)
            {
                this.offset -= Convert.ToInt32(comboBox_cantS.Text);
                showG.Show_Grid("SELECT * FROM CLIENTES ORDER BY CODIGO_CLIENTE", this.Muestra_Grid,
                    offset, Convert.ToInt32(comboBox_cantS.Text));
            }

            else if ((comboBox_cantS.SelectedIndex.Equals(-1)) || (comboBox_cantS.SelectedIndex.Equals(0)))
            {
                MessageBox.Show("Cantidad no valida en el Filtro",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (offset >= valid - Convert.ToInt32(comboBox_cantS.Text))
            {
                MessageBox.Show("No hay mas registros",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox_dirRight_Click(object sender, EventArgs e)
        {
            if (!(comboBox_cantS.SelectedIndex.Equals(-1)) && !(comboBox_cantS.SelectedIndex.Equals(0)) && offset < valid - Convert.ToInt32(comboBox_cantS.Text))
            {
                this.offset += Convert.ToInt32(comboBox_cantS.Text);
                showG.Show_Grid("SELECT * FROM CLIENTES ORDER BY CODIGO_CLIENTE", this.Muestra_Grid,
                    offset, Convert.ToInt32(comboBox_cantS.Text));
            }

            else if ((comboBox_cantS.SelectedIndex.Equals(-1)) || (comboBox_cantS.SelectedIndex.Equals(0)))
            {
                MessageBox.Show("Cantidad no valida en el Filtro",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (offset >= valid - Convert.ToInt32(comboBox_cantS.Text))
            {
                MessageBox.Show("No hay mas registros",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Muestra_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                //MessageBox.Show("Desea Facturar al Cliente", "Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                FrmVehiculosClientes vc = new FrmVehiculosClientes();
                items.Codigo_Cliente = Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[1].Value);
                items.Edad_Clientes = this.Muestra_Grid.CurrentRow.Cells[12].Value.ToString();
                vc.ShowDialog();
                this.Hide();
            }
        }

        private void FrmBusquedadClientesGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmUsuarioEmpleado frmUsuario = new FrmUsuarioEmpleado();
            frmUsuario.Show();
        }
    }
}
