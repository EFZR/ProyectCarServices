using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectCarServices
{
    public class CSHerramientaBaseDatos
    {
        protected SqlConnection connection = new SqlConnection("Data Source =.; Initial Catalog = PROYECT_3;Integrated Security=True");
        protected SqlCommand command = new SqlCommand();
        protected SqlDataAdapter adapter = new SqlDataAdapter();
        protected DataTable aux = new DataTable();

        public DataTable GetData(String SqlQuery)
        {
            DataTable table = new DataTable();
            command = new SqlCommand(SqlQuery, connection);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(table);

            connection.Close();
            adapter.Dispose();
            command.Dispose();

            return table;
        }

        public int GetValue(String SqlQuery)
        {
            try
            {
                DataTable table = new DataTable();
                command = new SqlCommand(SqlQuery, connection);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(table);

                connection.Close();
                adapter.Dispose();
                command.Dispose();

                int value = Convert.ToInt32(table.Rows[0][0].ToString());
                return value;
            }

            catch(Exception e)
            {
                MessageBox.Show("Error " + e.Message);
                return 0;
            }
            
        }

        public double GetValueD(String SqlQuery)
        {
            try
            {
                DataTable table = new DataTable();
                command = new SqlCommand(SqlQuery, connection);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(table);

                connection.Close();
                adapter.Dispose();
                command.Dispose();

                double value = Convert.ToDouble(table.Rows[0][0].ToString());

                return value;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
                return 0;
            }

        }

        //Validaciones
        public bool validacionTXT(Form form, bool valid)
        {
            foreach(Control ctrl in form.Controls)
            {
                if (ctrl is TextBox & ctrl.Text == String.Empty)
                    return valid = false;
            }

            return valid;
        }
        public bool validacionCB(Form form, bool valid)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is ComboBox & ctrl.Text == String.Empty)
                    valid = false;
            }
            return valid;
        }
        public bool validacionRB(RadioButton RB1, RadioButton RB2, bool valid)
        {
            if (!(RB1.Checked) && !(RB2.Checked))
                valid = false;
            
            return valid;
        }

        public void limpiezaTXT(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
            }
        }

        //FILL

        public DataTable comboBox_fill(ComboBox cb, String sqlQuery)
        {
            DataTable table = GetData(sqlQuery);

            if (table != null)
            {
                cb.DataSource = table;
                cb.ValueMember = table.Columns[0].ToString();
                cb.DisplayMember = table.Columns[1].ToString();
            }
            return table;
        }

        //CLIENTES

        public void insertCliente(CSItems item)
        {
            String sqlInsert = "INSERT INTO [dbo].[CLIENTES] ([NOMBRE] ,[APELLIDO], " +
                "[IDENTIDAD] ,[TELEFONO] ,[CORREO] ,[DIRECCION] ,[DPTO] , [SEXO], " +
                "[ESTADO_CIVIL] ,[FECHA_NACIMIENTO])" +
                "VALUES ('@1' ,'@2', '@3' ,'@4' ,'@5' ,'@6' ,'@7' ,'@8' ,'@9' ,'@A')";
            
            connection.Open();
            command = new SqlCommand(sqlInsert, connection);
            sqlInsert = sqlInsert.Replace("@1", item.NombreClientes).Replace("@2", item.ApellidoClientes);
            sqlInsert = sqlInsert.Replace("@3", item.IdentidadClientes).Replace("@4", item.TelefonoClientes);
            sqlInsert = sqlInsert.Replace("@5", item.CorreoClientes).Replace("@6", item.DireccionClientes);
            sqlInsert = sqlInsert.Replace("@7", item.DptoClientes).Replace("@8", item.SexoClientes);
            sqlInsert = sqlInsert.Replace("@9", item.Estado_civilClientes).Replace("@A", Convert.ToString(item.Fecha_nacimientoClientes));

            adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            MessageBox.Show("Dato Guardado Satisfactoriamente", "Estado de los datos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void updateCliente(CSItems item)
        {
            try
            {
                String sqlUpdate = "UPDATE [dbo].[CLIENTES] SET " +
                "[NOMBRE] = '@1', [APELLIDO] = '@2', " +
                "[IDENTIDAD] = '@3', [TELEFONO] = '@4'," +
                "[CORREO] = '@5' ,[DIRECCION] = '@6' ," +
                "[DPTO] = '@7', [SEXO] = '@8', " +
                "[ESTADO_CIVIL] = '@9',[FECHA_NACIMIENTO] = '@A' " +
                "WHERE CODIGO_CLIENTE = @B";

                sqlUpdate = sqlUpdate.Replace("@1", item.NombreClientes).Replace("@2", item.ApellidoClientes);
                sqlUpdate = sqlUpdate.Replace("@3", item.IdentidadClientes).Replace("@4", item.TelefonoClientes);
                sqlUpdate = sqlUpdate.Replace("@5", item.CorreoClientes).Replace("@6", item.DireccionClientes);
                sqlUpdate = sqlUpdate.Replace("@7", item.DptoClientes).Replace("@8", item.SexoClientes);
                sqlUpdate = sqlUpdate.Replace("@9", item.Estado_civilClientes).Replace("@A", Convert.ToString(item.Fecha_nacimientoClientes));
                sqlUpdate = sqlUpdate.Replace("@B", (item.Codigo_Cliente).ToString());

                connection.Open();

                command = new SqlCommand(sqlUpdate, connection);

                this.adapter.UpdateCommand = new SqlCommand(sqlUpdate, connection);
                this.adapter.UpdateCommand.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Actualizacion Realizada con Satisfaccion", "Actualizacion", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            catch(Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }
        public void deleteClientes(int codigo)
        {
            String sqlDelete = "DELETE FROM CLIENTES WHERE CODIGO_CLIENTE = @1";
            sqlDelete = sqlDelete.Replace("@1", codigo.ToString());
            connection.Open();
            command = new SqlCommand(sqlDelete, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //USUARIO

        public void insertUsuario(CSItems item)
        {
            String sqlInsert = "INSERT INTO [dbo].[USUARIOS] ([USER] ,[PASSWORD] ,[TIPO_TRABAJADOR] ,[NOMBRE] ,[APELLIDO] " +
                ",[IDENTIDAD] ,[TELEFONO] ,[CORREO] ,[DIRECCION] ,[DPTO] ,[SUCURSALES] ,[SEXO] ,[ESTADO_CIVIL] ,[FECHA_NACIMIENTO], [DIRECCION_IMAGEN])" +
                "VALUES('@1', '@2','@3','@4','@5','@6','@7','@8','@9','@A','@B','@C','@D','@E','@F')";
            connection.Open();
            sqlInsert = sqlInsert.Replace("@1", item.User).Replace("@2", item.Password).Replace("@3",item.Tipo_trabajador);
            sqlInsert = sqlInsert.Replace("@4", item.NombreUsuarios).Replace("@5", item.ApellidoUsuarios);
            sqlInsert = sqlInsert.Replace("@6", item.IdentidadUsuarios).Replace("@7", item.TelefonoUsuarios);
            sqlInsert = sqlInsert.Replace("@8", item.CorreoUsuarios).Replace("@9", item.DireccionUsuarios);
            sqlInsert = sqlInsert.Replace("@A", item.DptoUsuarios).Replace("@B", item.Sucursales);
            sqlInsert = sqlInsert.Replace("@C", item.SexoUsuarios).Replace("@D", item.Estado_civilUsuarios);
            sqlInsert = sqlInsert.Replace("@E", item.Fecha_nacimientoUsuarios.ToString()).Replace("@F", item.Imagen);

            adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            MessageBox.Show("Dato Guardado Satisfactoriamente", "Estado de los datos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void deleteUsuario(int codigo)
        {
            String sqlDelete = "DELETE FROM USUARIOS WHERE CODIGO_USUARIO = @1";
            sqlDelete = sqlDelete.Replace("@1", codigo.ToString());
            connection.Open();
            command = new SqlCommand(sqlDelete, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void updateUsuarios(CSItems item)
        {
            try
            {
                String sqlUpdate = "UPDATE [dbo].[USUARIOS] SET " +
                "[USER] = '@1', [PASSWORD] = '@2', [TIPO_TRABAJADOR] = '@3', " +
                "[NOMBRE] = '@4', [APELLIDO] = '@5', " +
                "[IDENTIDAD] = '@6', [TELEFONO] = '@7'," +
                "[CORREO] = '@8' ,[DIRECCION] = '@9' ," +
                "[DPTO] = '@A', [SUCURSALES] = '@B',[SEXO] = '@C', " +
                "[ESTADO_CIVIL] = '@D',[FECHA_NACIMIENTO] = '@E', " +
                "[DIRECCION_IMAGEN] = '@G'" +
                "WHERE CODIGO_USUARIO = @F";
                sqlUpdate = sqlUpdate.Replace("@1", item.User).Replace("@2", item.Password).Replace("@3", item.Tipo_trabajador);
                sqlUpdate = sqlUpdate.Replace("@4", item.NombreUsuarios).Replace("@5", item.ApellidoUsuarios);
                sqlUpdate = sqlUpdate.Replace("@6", item.IdentidadUsuarios).Replace("@7", item.TelefonoUsuarios);
                sqlUpdate = sqlUpdate.Replace("@8", item.CorreoUsuarios).Replace("@9", item.DireccionUsuarios);
                sqlUpdate = sqlUpdate.Replace("@A", item.DptoUsuarios).Replace("@B", item.Sucursales).Replace("@C", item.SexoUsuarios);
                sqlUpdate = sqlUpdate.Replace("@D", item.Estado_civilUsuarios).Replace("@E", Convert.ToString(item.Fecha_nacimientoUsuarios));
                sqlUpdate = sqlUpdate.Replace("@F", (item.Codigo_Usuario).ToString()).Replace("@G",item.Imagen);

                connection.Open();

                command = new SqlCommand(sqlUpdate, connection);

                this.adapter.UpdateCommand = new SqlCommand(sqlUpdate, connection);
                this.adapter.UpdateCommand.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Actualizacion Realizada con Satisfaccion", "Actualizacion", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }

        //CARROS
        public void insertCarro(CSItems item)
        {
            try
            {
                String sqlInsert = "INSERT INTO [dbo].[CARROS] ([NUM_PLACA], [MARCA_CARRO], [MODELO_CARRO], [CODIGO_CATEGORIA], [CODIGO_CLIENTE])" +
                "VALUES ('@1','@2','@3', @4, @5)";
                connection.Open();
                command = new SqlCommand(sqlInsert, connection);
                sqlInsert = sqlInsert.Replace("@1", item.Num_Placa).Replace("@2", item.Marca_carro);
                sqlInsert = sqlInsert.Replace("@3", item.Modelo_carro).Replace("@4", item.Categoria_carro);
                sqlInsert = sqlInsert.Replace("@5", item.Codigo_clientes_carros.ToString());

                adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                connection.Close();

                MessageBox.Show("Dato Guardado Satisfactoriamente", "Estado de los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error "+ e.Message, "Estado de los datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public void updateCarro(CSItems item)
        {
            try
            {
                String sqlUpdate = "UPDATE [dbo].[CARROS] SET [NUM_PLACA] = '@1', [MARCA_CARRO] = '@2', " +
                    "[MODELO_CARRO] = '@3', [CODIGO_CATEGORIA] = @4, [CODIGO_CLIENTE] = @5" +
                    "WHERE [CODIGO_CARROS] = @6";


                sqlUpdate = sqlUpdate.Replace("@1", item.Num_Placa).Replace("@2", item.Marca_carro);
                sqlUpdate = sqlUpdate.Replace("@3", item.Modelo_carro).Replace("@4", item.Categoria_carro);
                sqlUpdate = sqlUpdate.Replace("@5", item.Codigo_Carros.ToString())
                    .Replace("@6", item.Codigo_Carros.ToString());

                connection.Open();

                command = new SqlCommand(sqlUpdate, connection);

                this.adapter.InsertCommand = new SqlCommand(sqlUpdate, connection);
                this.adapter.InsertCommand.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Actualizacion Realizada con Satisfaccion", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }
        public void deleteCarro(int codigo)
        {
            String sqlDelete = "DELETE FROM [dbo].[CARROS] WHERE CODIGO_CARROS = @1";
            sqlDelete = sqlDelete.Replace("@1", codigo.ToString());
            connection.Open();
            command = new SqlCommand(sqlDelete, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //CATEGORIA DE CARROS

        public void insertCategoria(CSItems item)
        {
            String sqlInsert = "INSERT INTO [dbo].[CATEGORIA_AUTOS] ([TIPO_CARRO], [PORCENTAJE_PRECIO])" +
                "VALUES ('@1', '@2')";
            connection.Open();
            command = new SqlCommand(sqlInsert, connection);
            sqlInsert = sqlInsert.Replace("@1", (item.Tipo_Carro_Categoria1).ToString()).Replace("@2", (item.Porcentaje_Precio_Categoria1).ToString());
            adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
        public void updateCategoria(CSItems item)
        {
            String sqlUpdate = "UPDATE [dbo].[CATEGORIA_AUTOS] SET [TIPO_CARRO] = '@1', [PORCENTAJE_PRECIO] = '@2' " +
                "WHERE CODIGO_CATEGORIA = '@3'";
            sqlUpdate = sqlUpdate.Replace("@1", item.Tipo_Carro_Categoria1).Replace("@2", item.Porcentaje_Precio_Categoria1.ToString());
            sqlUpdate = sqlUpdate.Replace("@3", item.Codigo_CategoriaCarros.ToString());

            connection.Open();
            command = new SqlCommand(sqlUpdate, connection);
            this.adapter.UpdateCommand = new SqlCommand(sqlUpdate, connection);
            this.adapter.UpdateCommand.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Actualizacion Realizada con Satisfaccion", "Actualizacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        public void deleteCategoria(int codigo)
        {
            String sqlDelete = "DELETE FROM [PROYECT_3].[dbo].[CATEGORIA_AUTOS] WHERE [CODIGO_CATEGORIA] = @1";
            sqlDelete = sqlDelete.Replace("@1", codigo.ToString());
            connection.Open();
            command = new SqlCommand(sqlDelete, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //SERVICIOS

        public void insertServicio(CSItems item)
        {
            String sqlInsert = "INSERT INTO [dbo].[SERVICIOS]([NOMBRE], [TIPO_SERVICIO])" +
                "VALUES ('@1', '@2')";

            connection.Open();
            command = new SqlCommand(sqlInsert, connection);
            sqlInsert = sqlInsert.Replace("@1", (item.Nombre_Servicio).ToString()).Replace("@2", item.Tipo_Servicio1.ToString());
            adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            MessageBox.Show("Dato Guardado Satisfactoriamente", "Estado de los datos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public void updateServicio(CSItems item)
        {
            String sqlUpdate = "UPDATE [dbo].[SERVICIOS] SET [NOMBRE] = '@1', [TIPO_SERVICIO] = '@2' " +
                "WHERE CODIGO_SERVICIO = '@3' ";

            sqlUpdate = sqlUpdate.Replace("@1", item.Nombre_Servicio).Replace("@2", item.Tipo_Servicio1);
            sqlUpdate = sqlUpdate.Replace("@3", item.Codigo_Servicio.ToString());

            connection.Open();
            command = new SqlCommand(sqlUpdate, connection);
            this.adapter.UpdateCommand = new SqlCommand(sqlUpdate, connection);
            this.adapter.UpdateCommand.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Actualizacion Realizada con Satisfaccion", "Actualizacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        public void deleteServicio(int codigo)
        {
            String sqlDelete = "DELETE FROM SERVICIOS WHERE [CODIGO_SERVICIO] = @1";
            sqlDelete = sqlDelete.Replace("@1", codigo.ToString());
            connection.Open();
            command = new SqlCommand(sqlDelete, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        //SERVICIOS DETALLE
        public void insertServicioDetalle(CSItems item)
        {
            String sqlInsert = "INSERT INTO [dbo].[SERVICIOS_DETALLE]([TIPO_SERVICIO] ,[NOMBRE] ,[PRECIO])" +
                "VALUES('@1','@2','@3')";
            connection.Open();
            command = new SqlCommand(sqlInsert, connection);

            sqlInsert = sqlInsert.Replace("@1", (item.Tipo_Servicio_Detalle1).ToString()).Replace("@2", item.Nombre_Servicio_detalle);
            sqlInsert = sqlInsert.Replace("@3", item.Precio_Servicio_detalle.ToString());

            adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();

            MessageBox.Show("Dato Guardado Satisfactoriamente", "Estado de los datos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void UpdateServicioDetalle(CSItems item)
        {
            String sqlUpdate = "UPDATE [dbo].[SERVICIOS_DETALLE] SET [TIPO_SERVICIO] = '@1', [NOMBRE] = '@2', [PRECIO] = '@3' " +
               "WHERE CODIGO_SERVICIO_DETALLE = '@4' ";

            sqlUpdate = sqlUpdate.Replace("@1", item.Tipo_Servicio1).Replace("@2", item.Nombre_Servicio_detalle);
            sqlUpdate = sqlUpdate.Replace("@3", item.Precio_Servicio_detalle.ToString());
            sqlUpdate = sqlUpdate.Replace("@4", (item.Codigo_ServicioD).ToString());
            connection.Open();

            command = new SqlCommand(sqlUpdate, connection);

            this.adapter.UpdateCommand = new SqlCommand(sqlUpdate, connection);
            this.adapter.UpdateCommand.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Actualizacion Realizada con Satisfaccion", "Actualizacion", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        public void deleteServicioDetalle(int codigo)
        {
            try
            {
                String sqlDelete = "DELETE FROM [dbo].[SERVICIOS_DETALLE]" +
                "WHERE [CODIGO_SERVICIO_DETALLE] = @1";
                sqlDelete = sqlDelete.Replace("@1", codigo.ToString());
                connection.Open();
                command = new SqlCommand(sqlDelete, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
            
        }

        //FACTURAS

        public void insertFacturaD(CSItems items)
        {
            String sqlInsert = "INSERT INTO [dbo].[FACTURA_DETALLE]([COD_FACTURA] ,[CODIGO_SERVICIO_DETALLE] ," +
                "[NOMBRE_SERVICIO] ,[PRECIO_SERVICIO] ,[TOTAL_LINEA] ,[IMPUESTO_LINEA])" +
                "VALUES ('@1' ,'@2' ,'@3' ,'@4' ,'@5' ,'@6')";

            connection.Open();
            command = new SqlCommand(sqlInsert, connection);

            sqlInsert = sqlInsert.Replace("@1", (items.Codigo_Factura).ToString()).Replace("@2", items.Codigo_ServicioD.ToString());
            sqlInsert = sqlInsert.Replace("@3", items.Nombre_Servicio_detalle).Replace("@4", items.Precio_Servicio_detalle.ToString());
            sqlInsert = sqlInsert.Replace("@5", items.Total_linea_FactD.ToString()).Replace("@6", items.Impuesto_FactD.ToString());

            adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }

        public void insertFacturaE(CSItems items)
        {
            String sqlInsert = "INSERT INTO [dbo].[FACTURA_ENCABEZADO] ([CODIGO_CLIENTE] ,[CODIGO_USUARIO] ,[CODIGO_SUCURSAL] ," +
                "[CODIGO_DPTO] ,[HORA_FECHA] ,[FORMA_PAGO] ,[SUBTOTAL]," +
                "[DESCUENTO_3RA] ,[IMPUESTO_TOTAL] ,[TOTAL])" +
                "VALUES (@1 ,@2 ,@3 ,@4 ,'@5' ,'@6' ,'@7' ,'@8' ,'@9' ,'@A')";

            connection.Open();
            command = new SqlCommand(sqlInsert, connection);

            sqlInsert = sqlInsert.Replace("@1", (items.Codigo_Cliente).ToString()).Replace("@2", (items.Codigo_Usuario).ToString());
            sqlInsert = sqlInsert.Replace("@3", (items.Codigo_Sucursal).ToString()).Replace("@4", (items.Codigo_Dpto).ToString());
            sqlInsert = sqlInsert.Replace("@5", (DateTime.Now.ToString())).Replace("@6", items.FormaPago).Replace("@7", items.Subtotal.ToString());
            sqlInsert = sqlInsert.Replace("@8", items.Descuento3ra.ToString()).Replace("@9", items.Imp.ToString()).Replace("@A", items.Total.ToString());

            adapter.InsertCommand = new SqlCommand(sqlInsert, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }
    }
}