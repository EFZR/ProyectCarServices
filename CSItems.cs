using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectCarServices
{
    public class CSItems
    {
        //Atributos//Carros
        private static String num_Placa;
        private static String marca_carro;
        private static String modelo_carro;
        private static String codigo_clientes_carros;
        private static String categoria_carro;
        //Categoria Carros
        private static int codigo_CategoriaCarros;
        private static String Tipo_Carro_Categoria;
        private static Double Porcentaje_Precio_Categoria;
        //Clientes
        private static String nombreClientes;
        private static String apellidoClientes;
        private static String identidadClientes;
        private static String telefonoClientes;
        private static String correoClientes;
        private static String direccionClientes;
        private static String dptoClientes;
        private static String sexoClientes;
        private static String estado_civilClientes;
        private static String edad_Clientes;
        private static DateTime fecha_nacimientoClientes;
        //Usuarios
        private static String user;
        private static String password;
        private static DateTime ingreso_sistema;
        private static String tipo_trabajador;
        private static String nombreUsuarios;
        private static String apellidoUsuarios;
        private static String identidadUsuarios;
        private static String telefonoUsuarios;
        private static String correoUsuarios;
        private static String direccionUsuarios;
        private static String dptoUsuarios;
        private static String sexoUsuarios;
        private static String estado_civilUsuarios;
        private static DateTime fecha_nacimientoUsuarios;
        private static String sucursales;
        private static String edad_Usuarios;
        private static String imagen;
        //Servicios Detalle
        private static String nombre_Servicio_detalle;
        private static double precio_Servicio_detalle;
        private static int Tipo_Servicio_Detalle;
        //Servicios
        private static int codigo_Servicio;
        private static String nombre_Servicio;
        private static String Tipo_Servicio;
        //Factura Encabezado
        private static int codigo_Cliente;
        private static int codigo_Usuario;
        private static int codigo_Sucursal;
        private static int codigo_Dpto;
        private static DateTime horafecha_Factura;
        private static String formaPago;
        private static double subtotal;
        private static double descuento3ra;
        private static double imp;
        private static double total;
        //Factura Detalle
        private static int codigo_Factura;
        private static int codigo_Carros;
        private static int codigo_ServicioD;
        private static String cantidad;
        private static double total_linea_FactD;
        private static double impuesto_FactD;
        //datosfact
        private static int numFact;

        //Constructor Inecesario

        //propiedades
        public int NumFact { get => numFact; set => numFact = value; }
        public string Edad_Clientes { get => edad_Clientes; set => edad_Clientes = value; }
        public string Edad_Usuarios { get => edad_Usuarios; set => edad_Usuarios = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public double Descuento3ra { get => descuento3ra; set => descuento3ra = value; }
        public double Imp { get => imp; set => imp = value; }
        public double Total { get => total; set => total = value; }
        public string Num_Placa { get => num_Placa; set => num_Placa = value; }
        public string Marca_carro { get => marca_carro; set => marca_carro = value; }
        public string Modelo_carro { get => modelo_carro; set => modelo_carro = value; }
        public string Codigo_clientes_carros { get => codigo_clientes_carros; set => codigo_clientes_carros = value; }
        public string Categoria_carro { get => categoria_carro; set => categoria_carro = value; }
        public string NombreClientes { get => nombreClientes; set => nombreClientes = value; }
        public string ApellidoClientes { get => apellidoClientes; set => apellidoClientes = value; }
        public string IdentidadClientes { get => identidadClientes; set => identidadClientes = value; }
        public string TelefonoClientes { get => telefonoClientes; set => telefonoClientes = value; }
        public string CorreoClientes { get => correoClientes; set => correoClientes = value; }
        public string DireccionClientes { get => direccionClientes; set => direccionClientes = value; }
        public string DptoClientes { get => dptoClientes; set => dptoClientes = value; }
        public string SexoClientes { get => sexoClientes; set => sexoClientes = value; }
        public string Estado_civilClientes { get => estado_civilClientes; set => estado_civilClientes = value; }
        public DateTime Fecha_nacimientoClientes { get => fecha_nacimientoClientes; set => fecha_nacimientoClientes = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Ingreso_sistema { get => ingreso_sistema; set => ingreso_sistema = value; }
        public string Tipo_trabajador { get => tipo_trabajador; set => tipo_trabajador = value; }
        public string NombreUsuarios { get => nombreUsuarios; set => nombreUsuarios = value; }
        public string ApellidoUsuarios { get => apellidoUsuarios; set => apellidoUsuarios = value; }
        public string IdentidadUsuarios { get => identidadUsuarios; set => identidadUsuarios = value; }
        public string TelefonoUsuarios { get => telefonoUsuarios; set => telefonoUsuarios = value; }
        public string CorreoUsuarios { get => correoUsuarios; set => correoUsuarios = value; }
        public string DireccionUsuarios { get => direccionUsuarios; set => direccionUsuarios = value; }
        public string DptoUsuarios { get => dptoUsuarios; set => dptoUsuarios = value; }
        public string SexoUsuarios { get => sexoUsuarios; set => sexoUsuarios = value; }
        public string Estado_civilUsuarios { get => estado_civilUsuarios; set => estado_civilUsuarios = value; }
        public DateTime Fecha_nacimientoUsuarios { get => fecha_nacimientoUsuarios; set => fecha_nacimientoUsuarios = value; }
        public string Nombre_Servicio_detalle { get => nombre_Servicio_detalle; set => nombre_Servicio_detalle = value; }
        public double Precio_Servicio_detalle
        {
            get
            {
                return precio_Servicio_detalle;
            }
            set
            {
                if (value < 0)
                {
                    precio_Servicio_detalle = -1;
                }

                else
                {
                    precio_Servicio_detalle = value;
                }
            }
        }
        public int Tipo_Servicio_Detalle1 { get => Tipo_Servicio_Detalle; set => Tipo_Servicio_Detalle = value; }
        public int Codigo_Servicio { get => codigo_Servicio; set => codigo_Servicio = value; }
        public string Nombre_Servicio { get => nombre_Servicio; set => nombre_Servicio = value; }
        public string Tipo_Servicio1 { get => Tipo_Servicio; set => Tipo_Servicio = value; }
        public int Codigo_Cliente { get => codigo_Cliente; set => codigo_Cliente = value; }
        public int Codigo_Usuario { get => codigo_Usuario; set => codigo_Usuario = value; }
        public int Codigo_Sucursal { get => codigo_Sucursal; set => codigo_Sucursal = value; }
        public int Codigo_Dpto { get => codigo_Dpto; set => codigo_Dpto = value; }
        public DateTime Horafecha_Factura { get => horafecha_Factura; set => horafecha_Factura = value; }
        public string FormaPago { get => formaPago; set => formaPago = value; }
        public int Codigo_Factura { get => codigo_Factura; set => codigo_Factura = value; }
        public int Codigo_Carros { get => codigo_Carros; set => codigo_Carros = value; }
        public int Codigo_ServicioD { get => codigo_ServicioD; set => codigo_ServicioD = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public int Codigo_CategoriaCarros { get => codigo_CategoriaCarros; set => codigo_CategoriaCarros = value; }
        public string Tipo_Carro_Categoria1 { get => Tipo_Carro_Categoria; set => Tipo_Carro_Categoria = value; }
        public double Porcentaje_Precio_Categoria1
        {
            get
            {
                return Porcentaje_Precio_Categoria;
            }

            set
            {
                if (value < 0)
                {
                    Porcentaje_Precio_Categoria = -1;
                }
                else
                {
                    Porcentaje_Precio_Categoria = value;
                }
            }
        }

        public string Sucursales { get => sucursales; set => sucursales = value; }
        public double Total_linea_FactD { get => total_linea_FactD; set => total_linea_FactD = value; }
        public double Impuesto_FactD { get => impuesto_FactD; set => impuesto_FactD = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
}
