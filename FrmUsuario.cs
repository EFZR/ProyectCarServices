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
    public partial class FrmUsuario : Form
    {
        CSMuestrasGrid muestrasGrid = new CSMuestrasGrid();
        CSItems items = new CSItems();
        CSHerramientaBaseDatos herramienta = new CSHerramientaBaseDatos();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = null;

            table = muestrasGrid.GetData("SELECT * FROM USUARIOS WHERE [USER] = '" + txtUser.Text + "' AND " +
                "[PASSWORD]='" + txtPassword.Text + "'");

            if (table.Rows.Count>0)
            {
                items.Codigo_Sucursal = herramienta.GetValue("SELECT CODIGO_SUCURSAL " +
                "FROM SUCURSAL " +
                "WHERE NOMBRE_SUCURSAL = '" + table.Rows[0][12] + "'");

                items.Codigo_Dpto = herramienta.GetValue("SELECT CODIGO_DPTO " +
                    "FROM DPTO " +
                    "WHERE NOMBRE = '" + table.Rows[0][11] + "'");

                items.Codigo_Usuario = Convert.ToInt32(table.Rows[0][0].ToString());

                if (table.Rows[0][4].ToString().Equals("Administrativo"))
                {
                    FrmUsuarioAdmin admin = new FrmUsuarioAdmin();
                    this.Hide();
                    admin.Show();
                }

                else if (table.Rows[0][4].ToString().Equals("Empleado"))
                {
                    FrmUsuarioEmpleado empleado = new FrmUsuarioEmpleado();
                    this.Hide();
                    empleado.Show();
                }
            }

            else
            {
                MessageBox.Show("Usuario no encontrado", "USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CSHerramientaBaseDatos baseDatos = new CSHerramientaBaseDatos();
                baseDatos.limpiezaTXT(this);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacetese al Correo: grupo2@gmail.com",
                "USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
