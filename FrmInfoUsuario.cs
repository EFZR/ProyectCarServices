using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectCarServices
{
    public partial class FrmInfoUsuario : Form
    {
        public CSItems items;
        public CSHerramientaBaseDatos baseDatos;
        public FrmGridClientes gridClientes;
        public String directorio;
        private SqlConnection connection = new SqlConnection("Data Source =.; Initial Catalog = PROYECT_3;Integrated Security=True");

        public FrmInfoUsuario()
        {
            InitializeComponent();
            items = new CSItems();
            baseDatos = new CSHerramientaBaseDatos();
            gridClientes = new FrmGridClientes();
            this.comboBox_fill("SELECT * FROM [dbo].[DPTO]");
            this.comboBox_filldep(comboBox_Dpto.SelectedValue.ToString());
            directorio = "";
        }

        public void DataItem()
        {
            items.User = txt_User.Text;
            items.Password = txt_password.Text;
            items.Tipo_trabajador = comboBox_tipoTrabajador.Text;
            items.NombreUsuarios = textBox_Name.Text;
            items.ApellidoUsuarios = textBox_Apellido.Text;
            items.IdentidadUsuarios = textBox_Id.Text;
            items.TelefonoUsuarios = textBox_Tel.Text;
            items.CorreoUsuarios = textBox_Correo.Text;
            items.DireccionUsuarios = txt_Direccion.Text;
            items.DptoUsuarios = comboBox_Dpto.Text;
            items.Sucursales = comboBox_Sucursales.Text;
            items.Estado_civilUsuarios = comboBox_EstadoC.Text;
            items.Fecha_nacimientoUsuarios = dateTimePicker_FN.Value;
            items.Imagen = directorio;

            if (radioButton_F.Checked)
            {
                items.SexoUsuarios = "F";
            }

            else
            {
                items.SexoUsuarios = "M";
            }
        }

        public void DataItem(int id)
        {
            items.Codigo_Usuario = id;
            items.User = txt_User.Text;
            items.Password = txt_password.Text;
            items.Tipo_trabajador = comboBox_tipoTrabajador.Text;
            items.NombreUsuarios = textBox_Name.Text;
            items.ApellidoUsuarios = textBox_Apellido.Text;
            items.IdentidadUsuarios = textBox_Id.Text;
            items.TelefonoUsuarios = textBox_Tel.Text;
            items.CorreoUsuarios = textBox_Correo.Text;
            items.DireccionUsuarios = txt_Direccion.Text;
            items.DptoUsuarios = comboBox_Dpto.Text;
            items.Sucursales = comboBox_Sucursales.Text;
            items.Estado_civilUsuarios = comboBox_EstadoC.Text;
            items.Fecha_nacimientoUsuarios = dateTimePicker_FN.Value;
            items.Imagen = directorio;

            if (radioButton_F.Checked)
            {
                items.SexoUsuarios = "F";
            }

            else
            {
                items.SexoUsuarios = "M";
            }
        }

        private DataTable comboBox_fill(String sqlQuery)
        {
            DataTable table = this.baseDatos.GetData(sqlQuery);

            if (table != null)
            {
                this.comboBox_Dpto.DataSource = table;
                this.comboBox_Dpto.ValueMember = table.Columns[0].ToString();
                this.comboBox_Dpto.DisplayMember = table.Columns[1].ToString();
            }
            return table;
        }

        private void comboBox_filldep(String Sucursal)
        {
            String SqlQuery = "SELECT * FROM [dbo].[SUCURSAL] WHERE CODIGO_DPTO_NVARCHAR = @seleccion";

            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(SqlQuery, connection);
            command.Parameters.AddWithValue("seleccion", Sucursal);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table != null)
            {
                this.comboBox_Sucursales.DataSource = table;
                this.comboBox_Sucursales.ValueMember = table.Columns[2].ToString();
                this.comboBox_Sucursales.DisplayMember = table.Columns[3].ToString();
            }

            else
            {
                MessageBox.Show("Error al agregar datos", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
        }

        private void FrmInfoUsuario_Load(object sender, EventArgs e)
        {
            comboBox_tipoTrabajador.Items.Add("Empleado");
            comboBox_tipoTrabajador.Items.Add("Administrativo");

            this.comboBox_EstadoC.Items.Add("Soltero");
            this.comboBox_EstadoC.Items.Add("Casado");
            this.comboBox_EstadoC.Items.Add("Viudo");
            this.comboBox_EstadoC.Items.Add("Divorciado");
        }
        public virtual void btn_accion_Click(object sender, EventArgs e)
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
                this.DataItem();
                baseDatos.insertUsuario(items);
                this.Close();
            }
        }

        public void pictureBox_Imagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.openImage.ShowDialog() == DialogResult.OK)
                {
                    this.directorio = openImage.FileName;
                    pictureBox_Imagen.Image = Image.FromFile(directorio);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void comboBox_Dpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_filldep(comboBox_Dpto.SelectedValue.ToString());
        }
    }
}
