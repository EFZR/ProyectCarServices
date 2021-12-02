using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectCarServices
{
    public partial class FrmInfoUsuariosUPD : ProyectCarServices.FrmInfoUsuario
    {
        public int id;
        private SqlConnection connection=new SqlConnection("Data Source =.; Initial Catalog = PROYECT_3;Integrated Security=True");
        public FrmInfoUsuariosUPD()
        {
            InitializeComponent();
            this.comboBox_fill("SELECT * FROM [dbo].[DPTO]");
            this.comboBox_filldep(comboBox_Dpto.SelectedValue.ToString());
            id = 0;
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
                this.DataItem(id);
                baseDatos.updateUsuarios(items);
                this.Close();
            }
        }

        private void comboBox_Dpto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox_filldep(comboBox_Dpto.SelectedValue.ToString());
        }
    }
}
