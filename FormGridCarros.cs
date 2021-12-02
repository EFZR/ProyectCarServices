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
    public partial class FormGridCarros : Form
    {
        public CSMuestrasGrid showG = new CSMuestrasGrid();
        public CSHerramientaBaseDatos datos = new CSHerramientaBaseDatos();
        public int offset = 0;
        public int valid = 0;
        public FormGridCarros()
        {
            InitializeComponent();
        }

        private void FormGridCarros_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[CARROS]");

            this.cbCant_Carros.Items.Add("S/F");
            this.cbCant_Carros.Items.Add(5);
            this.cbCant_Carros.Items.Add(10);
            this.cbCant_Carros.Items.Add(20);

            valid = Muestra_Grid.Rows.Count;

            this.Muestra_Grid.Columns[0].DisplayIndex = 7;
            this.Muestra_Grid.Columns[1].DisplayIndex = 7;
        }

        private void Muestra_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                FormInfoCarrosUPD formUpd = new FormInfoCarrosUPD();
                formUpd.id = Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value);
                formUpd.tbPlaca.Text = this.Muestra_Grid.CurrentRow.Cells[3].Value.ToString();
                formUpd.tbMarca.Text = this.Muestra_Grid.CurrentRow.Cells[4].Value.ToString();
                formUpd.tbModelo.Text = this.Muestra_Grid.CurrentRow.Cells[5].Value.ToString();

                if(this.Muestra_Grid.CurrentRow.Cells[6].Value.ToString().Equals("1"))
                {
                    formUpd.cbCarro.Text = "Sedan";
                }

                else if (this.Muestra_Grid.CurrentRow.Cells[6].Value.ToString().Equals("2"))
                {
                    formUpd.cbCarro.Text = "Camioneta";
                }

                else if (this.Muestra_Grid.CurrentRow.Cells[6].Value.ToString().Equals("3"))
                {
                    formUpd.cbCarro.Text = "Pickup";
                }
                formUpd.txt_CodC.Text= this.Muestra_Grid.CurrentRow.Cells[7].Value.ToString();
                formUpd.ShowDialog();
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[CARROS]");
            }

            if (e.ColumnIndex.Equals(1))
            {
                if (e.ColumnIndex.Equals(1))
                {
                    this.datos.deleteCarro(Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[2].Value));
                    showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [dbo].[CARROS]");
                }
            }
        }

        private void filtro_Grid(String filtro)
        {
            DataTable sourceDGV = showG.GetData("SELECT * FROM [PROYECT_3].[dbo].[CARROS]" +
                "WHERE NUM_PLACA LIKE '%" + filtro + "%' " +
                "OR MARCA_CARRO '%" + filtro + "%' " +
                "OR MODELO_CARRO '%" + filtro + "%' " +
                "OR CODIGO_CATEGORIA '%" + filtro + "%' ");

            this.Muestra_Grid.DataSource = sourceDGV;
        }

        private void txt_filtrocarro_TextChanged(object sender, EventArgs e)
        {
            this.filtro_Grid(txt_filtrocarro.Text);
        }

        private void cbCant_Carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCant_Carros.SelectedIndex.Equals(0))
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[CARROS]");

            else
            {
                this.offset = 0;
                showG.Show_Grid("SELECT * FROM [PROYECT_3].[dbo].[CARROS] ORDER BY CODIGO_CARROS", this.Muestra_Grid,
                    offset, Convert.ToInt32(cbCant_Carros.Text));
            }
        }

        private void pb_prev_carro_Click(object sender, EventArgs e)
        {
            if (!(cbCant_Carros.SelectedIndex.Equals(-1)) && !(cbCant_Carros.SelectedIndex.Equals(0) && offset > 0))
            {
                this.offset = Convert.ToInt32(cbCant_Carros.Text);
                showG.Show_Grid("SELECT * FROM [PROYECT_3].[dbo].[CARROS] ORDER BY CODIGO_CARROS", this.Muestra_Grid,
                    offset, Convert.ToInt32(cbCant_Carros.Text));
            }
            else if ((cbCant_Carros.SelectedIndex.Equals(-1)) || (cbCant_Carros.SelectedIndex.Equals(0)))
            {
                MessageBox.Show("Cantidad no valida en el Filtro",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (offset >= valid - Convert.ToInt32(cbCant_Carros.Text))
            {
                MessageBox.Show("No hay mas registros",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pb_next_carro_Click(object sender, EventArgs e)
        {
            if (!(cbCant_Carros.SelectedIndex.Equals(-1)) && !(cbCant_Carros.SelectedIndex.Equals(0) && offset < valid - Convert.ToInt32(cbCant_Carros.Text)))
            {
                this.offset += Convert.ToInt32(cbCant_Carros.Text);
                showG.Show_Grid("SELECT * FROM CARROS ORDER BY CODIGO_CARROS", this.Muestra_Grid,
                    offset, Convert.ToInt32(cbCant_Carros.Text));
            }
            else if ((cbCant_Carros.SelectedIndex.Equals(-1)) || (cbCant_Carros.SelectedIndex.Equals(0)))
            {
                MessageBox.Show("Cantidad no valida en el Filtro",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (offset >= valid - Convert.ToInt32(cbCant_Carros.Text))
            {
                MessageBox.Show("No hay mas registros",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_insertar_Carros_Click(object sender, EventArgs e)
        {
            FormInfoCarro carro = new FormInfoCarro();
            carro.ShowDialog();
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[CARROS]");
        }
    }
}
