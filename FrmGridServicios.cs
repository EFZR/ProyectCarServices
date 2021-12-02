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
    public partial class FrmGridServicios : Form
    {
        public CSMuestrasGrid showG = new CSMuestrasGrid();
        public CSHerramientaBaseDatos datos = new CSHerramientaBaseDatos();
        public int offset = 0;
        public int valid = 0;
        public FrmGridServicios()
        {
            InitializeComponent();
        }

        private void Muestra_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                FrmInfoServiciosUPD formUpd = new FrmInfoServiciosUPD();
                formUpd.id = Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value.ToString());
                formUpd.txtName.Text = this.Muestra_Grid.CurrentRow.Cells[3].Value.ToString();

                //formUpd.dateTimePicker_FN.Text=Cdate;
                //formUpd.dateTimePicker1

                formUpd.ShowDialog();
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM TIPO_SERVICIOS");
            }

            if (e.ColumnIndex.Equals(1))
            {
                this.datos.deleteServicio(Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value));
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM TIPO_SERVICIOS");
            }
        }
        private void filtro_Grid(String filtro)
        {
            DataTable sourceDGV = showG.GetData("SELECT * FROM TIPO_SERVICIOS " +
                "WHERE NOMBRE LIKE '%" + filtro + "%' ");

            Muestra_Grid.DataSource = sourceDGV;
        }
        private void txtFiltroB_TextChanged(object sender, EventArgs e)
        {
            this.filtro_Grid(txtFiltroB.Text);
        }

        private void cmbCantS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantS.SelectedIndex.Equals(0))
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[TIPO_SERVICIOS]");

            else
            {
                this.offset = 0;
                showG.Show_Grid("SELECT * FROM [PROYECT_3].[dbo].[TIPO_SERVICIOS] ORDER BY [CODIGO_SERVICIO]", this.Muestra_Grid,
                    offset, Convert.ToInt32(cmbCantS.Text));
            }
        }

        private void pictureBox_dirLeft_Click(object sender, EventArgs e)
        {
            if (!(cmbCantS.SelectedIndex.Equals(-1)) && !(cmbCantS.SelectedIndex.Equals(0)) && offset > 0)
            {
                this.offset -= Convert.ToInt32(cmbCantS.Text);
                showG.Show_Grid("SELECT * FROM [PROYECT_3].[dbo].[TIPO_SERVICIOS] ORDER BY [CODIGO_SERVICIO]", this.Muestra_Grid,
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
                showG.Show_Grid("SELECT * FROM TIPO_SERVICIOS ORDER BY [CODIGO_SERVICIO]", this.Muestra_Grid,
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
            FrmInfoServicios servicios = new FrmInfoServicios();
            servicios.ShowDialog();
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM TIPO_SERVICIOS");
        }

        private void FrmGridServicios_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM TIPO_SERVICIOS");

            this.cmbCantS.Items.Add("S/F");
            this.cmbCantS.Items.Add(5);
            this.cmbCantS.Items.Add(10);
            this.cmbCantS.Items.Add(20);

            valid = Muestra_Grid.Rows.Count;
        }
    }
}