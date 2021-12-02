using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectCarServices
{
    public partial class FormInfoCarrosUPD : ProyectCarServices.FormInfoCarro
    {
        public int id;
        public FormInfoCarrosUPD()
        {
            InitializeComponent();
            id = 0;
        }

        public override void buttonAgregar_Click(object sender, EventArgs e)
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
                this.DataItems(id);
                baseDatos.updateCarro(this.items);
                this.Close();
            }
        }

        private void FormInfoCarrosUPD_Load(object sender, EventArgs e)
        {
            this.buttonAgregar.Text = "Actualizar";
        }
    }
}
