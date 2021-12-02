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
    public partial class FrmGridClientes : Form
    {
        public CSMuestrasGrid showG = new CSMuestrasGrid();
        public CSHerramientaBaseDatos datos = new CSHerramientaBaseDatos();
        public int offset = 0;
        public int valid = 0;
        public FrmGridClientes()
        {
            InitializeComponent();
        }

        private void FrmGridClientes_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CLIENTES");

            this.comboBox_cantS.Items.Add("S/F");
            this.comboBox_cantS.Items.Add(5);
            this.comboBox_cantS.Items.Add(10);
            this.comboBox_cantS.Items.Add(20);

            valid = Muestra_Grid.Rows.Count;
        }

        private void Muestra_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                FormInfoClientesUPD formUpd = new FormInfoClientesUPD();
                formUpd.id= Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value.ToString());
                formUpd.textBox_Name.Text = this.Muestra_Grid.CurrentRow.Cells[3].Value.ToString();
                formUpd.textBox_Apellido.Text=this.Muestra_Grid.CurrentRow.Cells[4].Value.ToString();
                formUpd.textBox_Id.Text = this.Muestra_Grid.CurrentRow.Cells[5].Value.ToString();
                formUpd.textBox_Tel.Text = this.Muestra_Grid.CurrentRow.Cells[6].Value.ToString();
                formUpd.textBox_Correo.Text = this.Muestra_Grid.CurrentRow.Cells[7].Value.ToString();
                formUpd.txt_Direccion.Text = this.Muestra_Grid.CurrentRow.Cells[8].Value.ToString();
                formUpd.comboBox_Dpto.Text = this.Muestra_Grid.CurrentRow.Cells[9].Value.ToString();
                formUpd.comboBox_EstadoC.Text = this.Muestra_Grid.CurrentRow.Cells[10].Value.ToString();

                //formUpd.dateTimePicker_FN.Text=Cdate;
                //formUpd.dateTimePicker1

                if (this.Muestra_Grid.CurrentRow.Cells[8].Value.ToString().Equals("M"))
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
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CLIENTES");
            }

            if (e.ColumnIndex.Equals(1))
            {
                this.datos.deleteClientes(Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value));
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CLIENTES");
            }
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

        private void button_insertar_Click(object sender, EventArgs e)
        {
            FormInfoCliente cliente = new FormInfoCliente();
            cliente.ShowDialog();
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CLIENTES");
        }
    }
}