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
    public partial class FormInfoCarro : Form
    {
        public CSItems items;
        public CSHerramientaBaseDatos baseDatos;

        public FormInfoCarro()
        {
            InitializeComponent();
            items = new CSItems();
            baseDatos = new CSHerramientaBaseDatos();
        }

        public void DataItems()
        {
            items.Num_Placa = tbPlaca.Text;
            items.Marca_carro = tbMarca.Text;
            items.Modelo_carro = tbModelo.Text;
            items.Categoria_carro = (cbCarro.SelectedValue).ToString();
            items.Codigo_clientes_carros = txt_CodC.Text;
        }

        public void DataItems(int id)
        {
            items.Num_Placa = tbPlaca.Text;
            items.Marca_carro = tbMarca.Text;
            items.Modelo_carro = tbModelo.Text;
            items.Categoria_carro = (cbCarro.SelectedValue).ToString();
            items.Codigo_clientes_carros = txt_CodC.Text;
        }

        public virtual void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool valid = true;
            valid = baseDatos.validacionTXT(this, valid);
            valid = baseDatos.validacionCB(this, valid);

            if (valid == false)
            {
                MessageBox.Show("Agregue valores a todos los Campos", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPlaca.Focus();
            }
            else
            {
                this.DataItems();
                baseDatos.insertCarro(items);
                this.Close();
            }
        }

        private void FormInfoCarro_Load(object sender, EventArgs e)
        {
            this.baseDatos.comboBox_fill(this.cbCarro, "SELECT CODIGO_CATEGORIA, TIPO_CARRO " +
                "FROM CATEGORIA_AUTOS");
        }
    }
}
