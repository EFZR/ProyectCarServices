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
    public partial class FrmUsuarioAdmin : Form
    {
        FrmGridUsuarios frmGridUsuarios;
        FrmGridClientes frmGridClientes;
        CSHerramientaBaseDatos datos;
        CSItems items;
        public FrmUsuarioAdmin()
        {
            InitializeComponent();
            frmGridUsuarios = new FrmGridUsuarios();
            frmGridClientes = new FrmGridClientes();
            datos = new CSHerramientaBaseDatos();
            items = new CSItems();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmGridUsuarios.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmGridClientes.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmVehiculosC vehiculosC = new FrmVehiculosC();
            vehiculosC.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmServicionsC servicionsC = new FrmServicionsC();
            servicionsC.ShowDialog();
        }

        private void FrmUsuarioAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.Show();
            this.Hide();
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            this.Close();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            DataTable table = datos.GetData("SELECT * FROM USUARIOS WHERE CODIGO_USUARIO = " + items.Codigo_Usuario);
            FrmInfoRepUser repUser = new FrmInfoRepUser();
            repUser.lbl_code.Text += " " + table.Rows[0][0].ToString();
            repUser.txt_User.Text = table.Rows[0][1].ToString();
            repUser.txt_password.Text = table.Rows[0][2].ToString();
            repUser.comboBox_tipoTrabajador.Text = table.Rows[0][4].ToString();
            repUser.textBox_Name.Text = table.Rows[0][5].ToString();
            repUser.textBox_Apellido.Text = table.Rows[0][6].ToString();
            repUser.textBox_Id.Text = table.Rows[0][7].ToString();
            repUser.textBox_Tel.Text = table.Rows[0][8].ToString();
            repUser.textBox_Correo.Text = table.Rows[0][9].ToString();
            repUser.txt_Direccion.Text = table.Rows[0][10].ToString();
            repUser.comboBox_Dpto.Text = table.Rows[0][11].ToString();
            repUser.comboBox_Sucursales.Text = table.Rows[0][12].ToString();
            repUser.comboBox_EstadoC.Text = table.Rows[0][14].ToString();

            if (table.Rows[0][13].ToString().Equals("F"))
            {
                repUser.radioButton_F.Checked = true;
                repUser.radioButton_M.Checked = false;
            }

            else
            {
                repUser.radioButton_F.Checked = false;
                repUser.radioButton_M.Checked = true;
            }

            try
            {
                repUser.pictureBox_Imagen.Image = Image.FromFile(table.Rows[0][17].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            repUser.Show();
        }
    }
}
