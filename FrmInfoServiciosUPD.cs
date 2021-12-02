using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectCarServices
{
    public partial class FrmInfoServiciosUPD : ProyectCarServices.FrmInfoServicios
    {
        public int id;
        public FrmInfoServiciosUPD()
        {
            InitializeComponent();
            id = 0;
        }

        public override void btn_accion_Click_1(object sender, EventArgs e)
        {
            bool valid = true;

            baseDatos.validacionTXT(this, valid);

            if (valid == false)
            {
                MessageBox.Show("Agregue valores a todos los Campos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else
            {
                this.dataItems(id);
                baseDatos.updateServicio(items);
                this.Close();
            }
        }
    }
}
