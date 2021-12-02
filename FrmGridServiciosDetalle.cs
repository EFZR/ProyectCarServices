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
    public partial class FrmGridServiciosDetalle : Form
    {
        public CSMuestrasGrid showG = new CSMuestrasGrid();
        public CSHerramientaBaseDatos datos = new CSHerramientaBaseDatos();
        public int offset = 0;
        public int valid = 0;
        public FrmGridServiciosDetalle()
        {
            InitializeComponent();
        }

        private void Muestra_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                FrmServiciosDetalleInfoUPD formUpd = new FrmServiciosDetalleInfoUPD();

                formUpd.cb_categoriaS.Text = Muestra_Grid.CurrentRow.Cells[3].Value.ToString();
                formUpd.txt_name.Text = Muestra_Grid.CurrentRow.Cells[4].Value.ToString();
                formUpd.txt_precio.Text = Muestra_Grid.CurrentRow.Cells[5].Value.ToString();


                formUpd.ShowDialog();
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM SERVICIOS_DETALLE");
            }

            if (e.ColumnIndex.Equals(1))
            {
                this.datos.deleteServicioDetalle(Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value));
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM SERVICIOS_DETALLE");
            }
        }

        private void FrmGridServiciosDetalle_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM SERVICIOS_DETALLE");

            this.cmbCantS.Items.Add("S/F");
            this.cmbCantS.Items.Add(5);
            this.cmbCantS.Items.Add(10);
            this.cmbCantS.Items.Add(20);

            valid = Muestra_Grid.Rows.Count;

            this.Muestra_Grid.Columns[0].DisplayIndex = 5;
            this.Muestra_Grid.Columns[1].DisplayIndex = 5;
        }

        private void cmbCantS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantS.SelectedIndex.Equals(0))
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM SERVICIOS_DETALLE");

            else
            {
                this.offset = 0;
                showG.Show_Grid("SELECT * FROM SERVICIOS_DETALLE ORDER BY [CODIGO_SERVICIO_DETALLE]", this.Muestra_Grid,
                    offset, Convert.ToInt32(cmbCantS.Text));
            }
        }

        private void pictureBox_dirLeft_Click(object sender, EventArgs e)
        {
            if (!(cmbCantS.SelectedIndex.Equals(-1)) && !(cmbCantS.SelectedIndex.Equals(0)) && offset > 0)
            {
                this.offset -= Convert.ToInt32(cmbCantS.Text);
                showG.Show_Grid("SELECT * FROM SERVICIOS_DETALLE ORDER BY [CODIGO_SERVICIO_DETALLE]", this.Muestra_Grid,
                    offset, Convert.ToInt32(cmbCantS.Text));
            }

            else if ((cmbCantS.SelectedIndex.Equals(-1)) || (cmbCantS.SelectedIndex.Equals(0)))
            {
                MessageBox.Show("Cantidad no valida en el Filtro",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (offset >= valid - Convert.ToInt32(cmbCantS.Text))
            {
                MessageBox.Show("No hay mas registros",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox_dirRight_Click(object sender, EventArgs e)
        {
            if (!(cmbCantS.SelectedIndex.Equals(-1)) && !(cmbCantS.SelectedIndex.Equals(0)) && offset < valid - Convert.ToInt32(cmbCantS.Text))
            {
                this.offset += Convert.ToInt32(cmbCantS.Text);
                showG.Show_Grid("SELECT * FROM SERVICIOS_DETALLE ORDER BY [CODIGO_SERVICIO_DETALLE]", this.Muestra_Grid,
                    offset, Convert.ToInt32(cmbCantS.Text));
            }

            else if ((cmbCantS.SelectedIndex.Equals(-1)) || (cmbCantS.SelectedIndex.Equals(0)))
            {
                MessageBox.Show("Cantidad no valida en el Filtro",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (offset >= valid - Convert.ToInt32(cmbCantS.Text))
            {
                MessageBox.Show("No hay mas registros",
                "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            FrmServiciosDetalleInfo serviciod = new FrmServiciosDetalleInfo();
            serviciod.ShowDialog();
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM SERVICIOS_DETALLE");
        }
    }
}
