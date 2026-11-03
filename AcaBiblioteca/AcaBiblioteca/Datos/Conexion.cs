using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient; 

namespace AcaBiblioteca.Datos
{
    public class Conexion {

        private string cadenaConexion = "Server=Localhost;Database=AcaBiblioteca;Integrated Security=true;trustServerCertificate=true;";


        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
