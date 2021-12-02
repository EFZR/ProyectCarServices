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
    public partial class FrmInfoServicios : Form
    {
        public CSItems items;
        public CSHerramientaBaseDatos baseDatos;
        public FrmInfoServicios()
        {
            InitializeComponent();
            this.btn_accion.Text = "Insertar";
            baseDatos = new CSHerramientaBaseDatos();
            items = new CSItems();
        }
        public void dataItems()
        {
            items.Nombre_Servicio = this.txtName.Text;
        }

        public void dataItems(int id)
        {
            items.Codigo_Servicio = id;
            items.Nombre_Servicio = this.txtName.Text;
        }

        public virtual void btn_accion_Click_1(object sender, EventArgs e)
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
                this.dataItems();
                baseDatos.insertServicio(items);
                this.Close();
            }
        }
    }
}
