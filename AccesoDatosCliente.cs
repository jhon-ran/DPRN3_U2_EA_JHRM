using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DPRN3_U2_EA_JHRM
{
    class AccesoDatosCliente
    {
        public static bool guardar(Cliente c)
        {
            try
            {
                Conexion con = new Conexion();

                //Sentencia SQL insert
                /*string sql = "INSERT INTO Flotilla (tipo_vehiculo, serie, ano_adq, marca, modelo, ano_vehiculo, color, verificacion, foto) " +
                    "VALUES ('" + a.Tipo_vehiculo + "','" + a.Serie + "','" + a.Ano_adq + "','" + a.Marca + "','" + a.Modelo + "','" + a.Ano_vehiculo + "','" + a.Color + "','" + a.Verificacion + "','" + a.Foto + "')";*/
                string sql = "INSERT INTO Cliente (curp, nombre, apellido_paterno, apellido_materno, sexo, persona, calle, num_ext, num_int, cp, ciudad, estado)" +
                    "VALUES ('" + c.Curp + 
                    "','" + c.Nombre + 
                    "','" + c.Apellido_paterno + 
                    "','" + c.Apellido_materno + 
                    "','" + c.Sexo +
                    "','" + c.Persona +
                    "','" + c.Calle +
                    "','" + c.Num_ext +
                    "','" + c.Num_int +
                    "','" + c.Cp +
                    "','" + c.Ciudad +
                    "','" + c.Estado +
                    "')";



                SqlCommand cmd = new SqlCommand(sql, con.conectar());

                //Cantidad de filas modificadas
                int cantidadFilas = cmd.ExecuteNonQuery();
                //se desconecta la bd después de insertar
                con.desconectar();

                //Si se guardó correctamente
                if (cantidadFilas == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }
    }
}
