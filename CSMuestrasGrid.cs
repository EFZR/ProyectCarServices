using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectCarServices
{
    public class CSMuestrasGrid
    {
        SqlConnection connection = new SqlConnection("Data Source =.; Initial Catalog = PROYECT_3;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

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

        public DataTable Show_Grid(DataGridView Grid, String Data)
        {
            DataTable table = GetData(Data);
            Grid.DataSource = table;

            return table;
        }

        public DataTable Show_Grid(String Data, DataGridView Grid, int OFFSET, int FETCH)
        {
            Data += " OFFSET " + OFFSET + " ROWS " +
                "FETCH NEXT " + FETCH + " ROWS ONLY";

            DataTable table = GetData(Data);
            Grid.DataSource = table;

            return table;
        }
    }
}
