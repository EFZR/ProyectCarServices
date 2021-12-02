using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ProyectCarServices
{
    public partial class FrmGridUsuarios : Form
    {
        public CSMuestrasGrid showG;
        public CSHerramientaBaseDatos datos;
        public CSItems items;
        public int offset = 0;
        public int valid = 0;

        public FrmGridUsuarios()
        {
            InitializeComponent();
            showG = new CSMuestrasGrid();
            datos = new CSHerramientaBaseDatos();
            items = new CSItems();
            offset = 0;
            valid = 0;

        }

        private void FrmGridUsuarios_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM USUARIOS");
            Muestra_Grid.Columns[0].DisplayIndex = 18;
            Muestra_Grid.Columns[1].DisplayIndex = 18;

            this.cmbCantS.Items.Add("S/F");
            this.cmbCantS.Items.Add(5);
            this.cmbCantS.Items.Add(10);
            this.cmbCantS.Items.Add(20);

            valid = Muestra_Grid.Rows.Count;

            Muestra_Grid.Columns[0].DisplayIndex = 19;
            Muestra_Grid.Columns[1].DisplayIndex = 19;
        }

        private void Muestra_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                FrmInfoUsuariosUPD formUpd = new FrmInfoUsuariosUPD();
                formUpd.id = Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value.ToString());
                formUpd.txt_User.Text = this.Muestra_Grid.CurrentRow.Cells[3].Value.ToString();
                formUpd.txt_password.Text = this.Muestra_Grid.CurrentRow.Cells[4].Value.ToString();
                formUpd.comboBox_tipoTrabajador.Text = this.Muestra_Grid.CurrentRow.Cells[6].Value.ToString();
                formUpd.textBox_Name.Text = this.Muestra_Grid.CurrentRow.Cells[7].Value.ToString();
                formUpd.textBox_Apellido.Text = this.Muestra_Grid.CurrentRow.Cells[8].Value.ToString();
                formUpd.textBox_Id.Text = this.Muestra_Grid.CurrentRow.Cells[9].Value.ToString();
                formUpd.textBox_Tel.Text = this.Muestra_Grid.CurrentRow.Cells[10].Value.ToString();
                formUpd.textBox_Correo.Text = this.Muestra_Grid.CurrentRow.Cells[11].Value.ToString();
                formUpd.txt_Direccion.Text = this.Muestra_Grid.CurrentRow.Cells[12].Value.ToString();
                formUpd.comboBox_Dpto.Text = this.Muestra_Grid.CurrentRow.Cells[13].Value.ToString();
                formUpd.comboBox_Sucursales.Text = this.Muestra_Grid.CurrentRow.Cells[14].Value.ToString();
                formUpd.comboBox_EstadoC.Text = this.Muestra_Grid.CurrentRow.Cells[16].Value.ToString();
                formUpd.directorio = this.Muestra_Grid.CurrentRow.Cells[19].Value.ToString();
                try
                {
                    formUpd.pictureBox_Imagen.Image = Image.FromFile(items.Imagen);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Usuario sin Imagen", "DATOS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                //formUpd.dateTimePicker_FN.Text=Cdate;
                //formUpd.dateTimePicker1

                if (this.Muestra_Grid.CurrentRow.Cells[15].Value.ToString().Equals("M"))
                {
                    formUpd.radioButton_F.Checked = false;
                    formUpd.radioButton_M.Checked = true;
                }

                else
                {
                    formUpd.radioButton_F.Checked = true;
                    formUpd.radioButton_M.Checked = false;
                }

                formUpd.ShowDialog();
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM USUARIOS");
            }

            if (e.ColumnIndex.Equals(1))
            {
                this.datos.deleteUsuario(Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value));
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM USUARIOS");
            }
        }

        private void filtro_Grid(String filtro)
        {
            DataTable sourceDGV = showG.GetData("SELECT * FROM USUARIOS " +
                "WHERE USER LIKE '%" + filtro + "%' " +
                "OR PASSWORD LIKE '%" + filtro + "%'" +
                "OR NOMBRE LIKE '%" + filtro + "%'" +
                "OR IDENTIDAD LIKE '%" + filtro + "%'");

            Muestra_Grid.DataSource = sourceDGV;
        }
        private void txtFiltroB_TextChanged(object sender, EventArgs e)
        {
            this.filtro_Grid(txtFiltroB.Text);
        }

        private void cmbCantS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantS.SelectedIndex.Equals(0))
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM USUARIOS");

            else
            {
                this.offset = 0;
                showG.Show_Grid("SELECT * FROM USUARIOS ORDER BY CODIGO_USUARIO", this.Muestra_Grid,
                    offset, Convert.ToInt32(cmbCantS.Text));
            }
        }

        private void pictureBox_dirLeft_Click(object sender, EventArgs e)
        {
            if (!(cmbCantS.SelectedIndex.Equals(-1)) && !(cmbCantS.SelectedIndex.Equals(0)) && offset > 0)
            {
                this.offset -= Convert.ToInt32(cmbCantS.Text);
                showG.Show_Grid("SELECT * FROM USUARIOS ORDER BY CODIGO_USUARIO", this.Muestra_Grid,
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
                showG.Show_Grid("SELECT * FROM USUARIOS ORDER BY CODIGO_USUARIO", this.Muestra_Grid,
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
            FrmInfoUsuario usuario = new FrmInfoUsuario();
            usuario.ShowDialog();
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM USUARIOS");
        }
    }
}
