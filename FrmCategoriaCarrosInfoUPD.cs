using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectCarServices
{
    public partial class FrmCategoriaCarrosInfoUPD : ProyectCarServices.FrmCategoriaCarrosInfo
    {
        public int id;
        public FrmCategoriaCarrosInfoUPD()
        {
            InitializeComponent();
            id = 0;
            btn_accion.Text = "Actualizar";
        }

        public override void btn_accion_Click(object sender, EventArgs e)
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
                baseDatos.updateCategoria(items);
                this.Close();
            }
        }
    }
}
