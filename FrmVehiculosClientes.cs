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
    public partial class FrmVehiculosClientes : Form
    {
        public CSMuestrasGrid showG = new CSMuestrasGrid();
        public CSHerramientaBaseDatos datos = new CSHerramientaBaseDatos();
        public CSItems items = new CSItems();
        public int offset = 0;
        public int valid = 0;
        public FrmVehiculosClientes()
        {
            InitializeComponent();
        }

        private void FrmVehiculosClientes_Load(object sender, EventArgs e)
        {
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[CARROS] " +
                "WHERE CODIGO_CLIENTE = "+items.Codigo_Cliente.ToString());

            this.cbCant_Carros.Items.Add("S/F");
            this.cbCant_Carros.Items.Add(5);
            this.cbCant_Carros.Items.Add(10);
            this.cbCant_Carros.Items.Add(20);

            valid = Muestra_Grid.Rows.Count;
        }

        private void Muestra_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            items.Codigo_Carros = Convert.ToInt32(this.Muestra_Grid.CurrentRow.Cells[1].Value);

            string aux = Muestra_Grid.CurrentRow.Cells[5].Value.ToString();
            items.Porcentaje_Precio_Categoria1 = datos.GetValueD("SELECT PORCENTAJE_PRECIO " +
                "FROM CATEGORIA_AUTOS " +
                "WHERE CODIGO_CATEGORIA = "+ Muestra_Grid.CurrentRow.Cells[5].Value.ToString() + "");

            FrmDetallesFactura frmDetalles = new FrmDetallesFactura();
            this.Hide();
            frmDetalles.ShowDialog();
        }

        private void filtro_Grid(String filtro)
        {
            DataTable sourceDGV = showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM CARROS " +
                "WHERE CODIGO_CLIENTE = "+items.Codigo_Cliente.ToString()+" "+
                "AND NUM_PLACA LIKE '%" + filtro + "%' " +
                "OR MARCA_CARRO LIKE '%" + filtro + "%' " +
                "OR MODELO_CARRO LIKE '%" + filtro + "%' " +
                "OR CODIGO_CATEGORIA LIKE '%" + filtro + "%' ");

            this.Muestra_Grid.DataSource = sourceDGV;
        }

        private void txt_filtrocarro_TextChanged(object sender, EventArgs e)
        {
            this.filtro_Grid(txt_filtrocarro.Text);
        }

        private void cbCant_Carros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCant_Carros.SelectedIndex.Equals(0))
                showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[CARROS] " +
                "WHERE CODIGO_CLIENTE = " + items.Codigo_Cliente.ToString());

            else
            {
                this.offset = 0;
                showG.Show_Grid("SELECT * FROM [PROYECT_3].[dbo].[CARROS] " +
                    "WHERE CODIGO_CLIENTE = " + items.Codigo_Cliente.ToString()+
                    "ORDER BY CODIGO_CARROS", this.Muestra_Grid,
                    offset, Convert.ToInt32(cbCant_Carros.Text));
            }
        }

        private void pb_prev_carro_Click(object sender, EventArgs e)
        {
            if (!(cbCant_Carros.SelectedIndex.Equals(-1)) && !(cbCant_Carros.SelectedIndex.Equals(0) && offset > 0))
            {
                this.offset = Convert.ToInt32(cbCant_Carros.Text);
                showG.Show_Grid("SELECT * FROM [PROYECT_3].[dbo].[CARROS] " +
                    "WHERE CODIGO_CLIENTE = " + items.Codigo_Cliente.ToString() +
                    "ORDER BY CODIGO_CARROS", this.Muestra_Grid,
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
                showG.Show_Grid("SELECT * FROM [PROYECT_3].[dbo].[CARROS] " +
                    "WHERE CODIGO_CLIENTE = " + items.Codigo_Cliente.ToString() +
                    "ORDER BY CODIGO_CARROS", this.Muestra_Grid,
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
            carro.txt_CodC.Text = items.Codigo_Cliente.ToString();
            carro.ShowDialog();
            showG.Show_Grid(this.Muestra_Grid, "SELECT * FROM [PROYECT_3].[dbo].[CARROS] " +
                "WHERE CODIGO_CLIENTE = " + items.Codigo_Cliente.ToString());
        }

        private void FrmVehiculosClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmUsuarioEmpleado empleado = new FrmUsuarioEmpleado();
            empleado.Show();
        }
    }
}
