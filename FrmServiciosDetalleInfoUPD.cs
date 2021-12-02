using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectCarServices
{
    public partial class FrmServiciosDetalleInfoUPD : ProyectCarServices.FrmServiciosDetalleInfo
    {
        public int id;
        //public FrmGridServiciosDetalleInfo gridServiciosDetalle = new FrmGridServiciosDetalleInfo();
        public FrmServiciosDetalleInfoUPD()
        {
            InitializeComponent();
        }

        public override void btn_accion_Click(object sender, EventArgs e)
        {
            bool valid = true;

            valid = baseDatos.validacionTXT(this, valid);
            valid = baseDatos.validacionCB(this, valid);

            if (valid == false)
            {
                MessageBox.Show("Agregue valores a todos los Campos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_name.Focus();
            }
            else
            {
                baseDatos.UpdateServicioDetalle(items);
                this.Close();
                //gridServiciosDetalle.showG.Show_Grid(gridServiciosDetalle.Muestra_Grid, "SELECT * FROM SERVICIOS_DETALLE");
            }
        }
    }
}
