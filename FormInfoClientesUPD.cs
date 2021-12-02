using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectCarServices
{
    public partial class FormInfoClientesUPD : ProyectCarServices.FormInfoCliente
    {
        public int id;
        public FrmGridClientes gridClientes = new FrmGridClientes();
        public FormInfoClientesUPD()
        {
            InitializeComponent();
            btn_accion.Text = "Actualizar";
            id = 0;
        }

        public override void btn_accion_Click(object sender, EventArgs e)
        {
            bool valid = true;

            valid = baseDatos.validacionTXT(this, valid);
            valid = baseDatos.validacionCB(this, valid);
            valid = baseDatos.validacionRB(this.radioButton_F, this.radioButton_M, valid);

            if (valid == false)
            {
                MessageBox.Show("Agregue valores a todos los Campos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_Name.Focus();
            }

            else
            {
                this.DataItems(id);
                baseDatos.updateCliente(items);
                this.Close();
                gridClientes.showG.Show_Grid(gridClientes.Muestra_Grid, "SELECT * FROM CLIENTES");
            }
        }
    }
}
