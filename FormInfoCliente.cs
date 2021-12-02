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
    public partial class FormInfoCliente : Form
    {
        public CSItems items;
        public CSHerramientaBaseDatos baseDatos;
        public FormInfoCliente()
        {
            InitializeComponent();
            items = new CSItems();
            baseDatos = new CSHerramientaBaseDatos();
            btn_accion.Text = "Insertar";
        }
        public void DataItems()
        {
            items.NombreClientes = textBox_Name.Text;
            items.ApellidoClientes = textBox_Apellido.Text;
            items.IdentidadClientes = textBox_Id.Text;
            items.TelefonoClientes = textBox_Tel.Text;
            items.CorreoClientes = textBox_Correo.Text;
            items.DireccionClientes = txt_Direccion.Text;
            items.DptoClientes = comboBox_Dpto.Text;
            items.Estado_civilClientes = comboBox_EstadoC.Text;
            items.Fecha_nacimientoClientes = dateTimePicker_FN.Value;

            if (radioButton_F.Checked)
                items.SexoClientes = "F";

            else
                items.SexoClientes = "M";
        }

        public void DataItems(int id)
        {
            items.Codigo_Cliente = id;
            items.NombreClientes = textBox_Name.Text;
            items.ApellidoClientes = textBox_Apellido.Text;
            items.IdentidadClientes = textBox_Id.Text;
            items.TelefonoClientes = textBox_Tel.Text;
            items.CorreoClientes = textBox_Correo.Text;
            items.DireccionClientes = txt_Direccion.Text;
            items.DptoClientes = comboBox_Dpto.Text;
            items.Estado_civilClientes = comboBox_EstadoC.Text;
            items.Fecha_nacimientoClientes = dateTimePicker_FN.Value;

            if (radioButton_F.Checked)
                items.SexoClientes = "F";

            else
                items.SexoClientes = "M";
        }

        public virtual void btn_accion_Click(object sender, EventArgs e)
        {
            bool valid=true;

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
                this.DataItems();
                baseDatos.insertCliente(items);
                this.Close();
            }
        }

        private void FormInfoCliente_Load(object sender, EventArgs e)
        {
            comboBox_Dpto.Items.Add("Seleccione una Opcion");
            baseDatos.comboBox_fill(this.comboBox_Dpto, "SELECT * FROM [dbo].[DPTO]");
            this.comboBox_EstadoC.Items.Add("Soltero");
            this.comboBox_EstadoC.Items.Add("Casado");
            this.comboBox_EstadoC.Items.Add("Viudo");
            this.comboBox_EstadoC.Items.Add("Divorciado");
        }
    }
}
