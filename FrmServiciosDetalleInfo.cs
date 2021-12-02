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
    public partial class FrmServiciosDetalleInfo : Form
    {
        public CSItems items;
        public CSHerramientaBaseDatos baseDatos;
        public FrmServiciosDetalleInfo()
        {
            InitializeComponent();
            this.btn_accion.Text = "Insertar";
            baseDatos = new CSHerramientaBaseDatos();
            items = new CSItems();
        }

        public void dataItems()
        {
            items.Nombre_Servicio_detalle = this.txt_name.Text;
            items.Precio_Servicio_detalle = Convert.ToDouble(this.txt_precio.Text);
            items.Tipo_Servicio_Detalle1 = cb_categoriaS.SelectedIndex + 1;
        }

        public virtual void btn_accion_Click(object sender, EventArgs e)
        {
            bool valid = true;
            baseDatos.validacionTXT(this, valid);
            baseDatos.validacionCB(this, valid);

            if (valid == false)
            {
                MessageBox.Show("Agregue valores a todos los Campos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_name.Focus();
            }

            else
            {
                this.dataItems();
                if (items.Precio_Servicio_detalle.Equals(-1))
                {
                    MessageBox.Show("Agregue un valor positivo al precio", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_precio.Focus();
                }

                else
                {
                    baseDatos.insertServicioDetalle(items);
                    this.Close();
                }
            }
        }

        private void FrmServiciosDetalleInfo_Load(object sender, EventArgs e)
        {
            baseDatos.comboBox_fill(cb_categoriaS, "SELECT [CODIGO_SERVICIO], [TIPO_SERVICIO] FROM SERVICIOS");
        }
    }
}
