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
    public partial class FrmDetallesFactura : Form
    {
        public CSHerramientaBaseDatos baseDatos;
        public CSMuestrasGrid grid;
        public CSItems item;
        public DataTable table;
        public DataTable tableD;
        public double sum;
        public double totalL;
        public double taxL;

        public FrmDetallesFactura()
        {
            InitializeComponent();
            baseDatos = new CSHerramientaBaseDatos();
            grid = new CSMuestrasGrid();
            table = new DataTable();
            item = new CSItems();
            sum = 0;
            totalL = 0;
            taxL = 0;
        }

        private void FrmDetallesFactura_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn checkC = new DataGridViewCheckBoxColumn();
            checkC.ReadOnly = true;
            checkC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkC.HeaderText = "Agregar";
            dgv_ServiciosD.Columns.Add(checkC);

            DataGridViewCheckBoxColumn del = new DataGridViewCheckBoxColumn();
            del.ReadOnly = true;
            del.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            del.HeaderText = "Remover";
            dgv_ServiciosSel.Columns.Add(del);

            tableD=grid.Show_Grid(this.dgv_ServiciosD, "SELECT [CODIGO_SERVICIO_DETALLE] as CODIGO, [NOMBRE] ,[PRECIO] " +
                "FROM [PROYECT_3].[dbo].[SERVICIOS_DETALLE]");

            dgv_ServiciosSel.DataSource = table;
            table.Columns.Add("CODIGO");
            table.Columns.Add("NOMBRE");
            table.Columns.Add("PRECIO");
            table.Columns.Add("IMPUESTO");
            table.Columns.Add("COSTO %");
            table.Columns.Add("TOTAL LINEA");

            comboBox1.Items.Add("Efectivo");
            comboBox1.Items.Add("Credito");

            item.Codigo_Factura = baseDatos.GetValue("SELECT MAX(COD_FACTURA) FROM FACTURA_ENCABEZADO") + 1;
        }

        public void DataItem()
        {
            DataTable table = baseDatos.GetData("SELECT * FROM FACTURA_ENCABEZADO");
            item.FormaPago = comboBox1.Text;
            item.Subtotal = Convert.ToDouble(this.lblTotal.Text);
            item.Horafecha_Factura = DateTime.Now;

            if(Convert.ToInt32(item.Edad_Clientes)>60)
                item.Descuento3ra = Convert.ToDouble(this.lblTotal.Text) * 0.25;

            item.Imp = Convert.ToDouble(this.lblTotal.Text) * 0.15;
            item.Total = item.Subtotal - item.Descuento3ra + item.Imp;
        }

        private void dgv_ServiciosD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                String nombre = dgv_ServiciosD.CurrentRow.Cells[1].Value.ToString();
                String precio = dgv_ServiciosD.CurrentRow.Cells[2].Value.ToString();
                String Codigo = dgv_ServiciosD.CurrentRow.Cells[3].Value.ToString();
                table.Rows.Add(new[] { nombre, precio, Codigo });
                dgv_ServiciosD.Rows.Remove(dgv_ServiciosD.CurrentRow);

                sum = 0;

                for(int i = 0; i < dgv_ServiciosSel.Rows.Count; i++)
                {
                    dgv_ServiciosSel.Rows[i].Cells[4].Value = Convert.ToDouble(dgv_ServiciosSel.Rows[i].Cells[3].Value)
                    * 0.15;
                    dgv_ServiciosSel.Rows[i].Cells[5].Value = item.Porcentaje_Precio_Categoria1;
                    dgv_ServiciosSel.Rows[i].Cells[6].Value = Convert.ToDouble(dgv_ServiciosSel.Rows[i].Cells[3].Value) *
                        item.Porcentaje_Precio_Categoria1 + Convert.ToDouble(dgv_ServiciosSel.Rows[i].Cells[4].Value);
                    sum += Convert.ToDouble(dgv_ServiciosSel.Rows[i].Cells[6].Value);
                }

                lblTotal.Text = sum.ToString();
            }
        }

        private void dgv_ServiciosSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(0))
            {
                String nombre = dgv_ServiciosSel.CurrentRow.Cells[1].Value.ToString();
                String precio = dgv_ServiciosSel.CurrentRow.Cells[2].Value.ToString();
                String Codigo = dgv_ServiciosSel.CurrentRow.Cells[3].Value.ToString();
                tableD.Rows.Add(new[] { nombre, precio, Codigo });

                sum -= Convert.ToDouble(dgv_ServiciosSel.CurrentRow.Cells[6].Value);
                lblTotal.Text = sum.ToString();

                dgv_ServiciosSel.Rows.Remove(dgv_ServiciosSel.CurrentRow);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            bool valid = true;
            baseDatos.validacionCB(this, valid);

            if (valid.Equals(true))
            {
                DataItem();
                baseDatos.insertFacturaE(item);

                for (int i = 0; i < dgv_ServiciosSel.Rows.Count; i++)
                {
                    item.Codigo_ServicioD = Convert.ToInt32(dgv_ServiciosSel.Rows[i].Cells[1].Value);
                    item.Nombre_Servicio_detalle = dgv_ServiciosSel.Rows[i].Cells[2].Value.ToString();
                    item.Precio_Servicio_detalle = Convert.ToDouble(dgv_ServiciosSel.Rows[i].Cells[3].Value);
                    item.Impuesto_FactD = Convert.ToDouble(dgv_ServiciosSel.Rows[i].Cells[4].Value);
                    item.Total_linea_FactD = Convert.ToDouble(dgv_ServiciosSel.Rows[i].Cells[6].Value);

                    baseDatos.insertFacturaD(item);
                }

                MessageBox.Show("Facturacion", "Estado de los datos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                FormFacturacion facturacion = new FormFacturacion();
                this.Hide();
                facturacion.ShowDialog();
            }

            else
            {
                MessageBox.Show("Llene todos los campos del Formulario", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void FrmDetallesFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmUsuarioEmpleado empleado = new FrmUsuarioEmpleado();
            empleado.Show();
        }
    }
}