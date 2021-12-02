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
    public partial class FrmCategoriaCarrosInfo : Form
    {
        public CSItems items;
        public CSHerramientaBaseDatos baseDatos;
        public FrmCategoriaCarrosInfo()
        {
            InitializeComponent();
            items = new CSItems();
            baseDatos = new CSHerramientaBaseDatos();
            btn_accion.Text = "Insertar";
        }

        public void DataItem()
        {
            items.Tipo_Carro_Categoria1 = txtTipoCarro.Text;
            items.Porcentaje_Precio_Categoria1 = Convert.ToDouble(this.txtProcentajeCosto.Text);
        }

        public virtual void btn_accion_Click(object sender, EventArgs e)
        {
            bool valid = true;

            valid = baseDatos.validacionTXT(this, valid);
            this.DataItem();

            if (valid == false)
            {
                MessageBox.Show("Agregue valores a todos los Campos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTipoCarro.Focus();
            }

            else if (items.Porcentaje_Precio_Categoria1 < 0)
            {
                System.Windows.Forms.MessageBox.Show("Ingrese un numero positivo", "ERROR",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                baseDatos.insertCategoria(items);
                this.Close();
            }
        }
    }
}
