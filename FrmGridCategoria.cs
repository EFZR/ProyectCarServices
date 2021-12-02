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
    public partial class FrmGridCategoria : Form
    {
        public CSMuestrasGrid showG = new CSMuestrasGrid();
        public CSHerramientaBaseDatos datos = new CSHerramientaBaseDatos();
        public int offset = 0;
        public int valid = 0;
        public FrmGridCategoria()
        {
            InitializeComponent();
        }

        private void FrmGridCategoria_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CATEGORIA_AUTOS");

            this.comboBox_cantS.Items.Add("S/F");
            this.comboBox_cantS.Items.Add(5);
            this.comboBox_cantS.Items.Add(10);
            this.comboBox_cantS.Items.Add(20);

            valid = Muestra_Grid.Rows.Count;

            this.Muestra_Grid.Columns[0].DisplayIndex = 4;
            this.Muestra_Grid.Columns[1].DisplayIndex = 4;
        }
        private void Muestra_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                FrmCategoriaCarrosInfoUPD formUpd = new FrmCategoriaCarrosInfoUPD();

                formUpd.id = Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value.ToString());
                formUpd.txtTipoCarro.Text = this.Muestra_Grid.CurrentRow.Cells[3].Value.ToString();
                formUpd.txtProcentajeCosto.Text = this.Muestra_Grid.CurrentRow.Cells[4].Value.ToString();

                //formUpd.dateTimePicker_FN.Text=Cdate;
                //formUpd.dateTimePicker1      

                formUpd.ShowDialog();
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CATEGORIA_AUTOS");
            }

            if (e.ColumnIndex.Equals(1))
            {
                this.datos.deleteCategoria(Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value));
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CATEGORIA_AUTOS");
            }
        }
        private void filtro_Grid(String filtro)
        {
            DataTable sourceDGV = showG.GetData("SELECT * FROM CATEGORIA_AUTOS " +
                "WHERE [TIPO_CARRO] LIKE '%" + filtro + "%' " +
                "OR [PORCENTAJE_PRECIO] LIKE '%" + filtro + "%'");

            Muestra_Grid.DataSource = sourceDGV;
        }

        private void txt_FiltroB_TextChanged(object sender, EventArgs e)
        {
            this.filtro_Grid(txt_FiltroB.Text);
        }

        private void comboBox_cantS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_cantS.SelectedIndex.Equals(0))
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CATEGORIA_AUTOS");

            else
            {
                this.offset = 0;
                showG.Show_Grid("SELECT * FROM CATEGORIA_AUTOS ORDER BY [CODIGO_CATEGORIA]", this.Muestra_Grid,
                    offset, Convert.ToInt32(comboBox_cantS.Text));
            }
        }

        private void pictureBox_dirLeft_Click(object sender, EventArgs e)
        {
            if (!(comboBox_cantS.SelectedIndex.Equals(-1)) && !(comboBox_cantS.SelectedIndex.Equals(0)) && offset > 0)
            {
                this.offset -= Convert.ToInt32(comboBox_cantS.Text);
                showG.Show_Grid("SELECT * FROM CATEGORIA_AUTOS ORDER BY [CODIGO_CATEGORIA]", this.Muestra_Grid,
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
                showG.Show_Grid("SELECT * FROM CATEGORIA_AUTOS ORDER BY [CODIGO_CATEGORIA]", this.Muestra_Grid,
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

        private void button_insertar_Click(object sender, EventArgs e)
        {
            FrmCategoriaCarrosInfo categoria = new FrmCategoriaCarrosInfo();
            categoria.ShowDialog();
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CATEGORIA_AUTOS");
        }
    }
}
