using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public class P_Usuario
    {

        #region Logueo
        public static Entidades.E_Usuario Logueo(string pMail, string pPw)
        {
            //variables
            Debug.WriteLine("User a login" + pMail);
            Debug.WriteLine("Pass a login" + pPw);

            SqlConnection _cnn = new SqlConnection(Conexion._Cnn);
            SqlCommand _comando = new SqlCommand("Logueo", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;
           // DataTable dt = new DataTable();
            E_Usuario unUsu = null;

            //parametros
            _comando.Parameters.AddWithValue("@Mail", pMail);
            _comando.Parameters.AddWithValue("@Pw", pPw);

            try
            {
                _cnn.Open();

                SqlDataReader _lector = _comando.ExecuteReader();
                
                    _lector.Read();

                    string Mail = (string)_lector["Mail"];
                    /* string Nombre = (string)_lector["Nombre"];
                     string Apellido = (string)_lector["Apellido"];
                     string Direccion = (string)_lector["Direccion"];
                     string Localidad = (string)_lector["Localidad"];
                     DateTime FechaNac = (DateTime)_lector["FechaNac"];
                     string Cel = (string)_lector["Cel"];*/
                    string Pw = (string)_lector["Pw"];

                    /* Debug.WriteLine("CI Usuario-" + CIUsu);
                     Debug.WriteLine("Nombre Empleado-" + nomEmp);
                     Debug.WriteLine("Pass Usuario-" + pasUsu);*/

                    unUsu = new Entidades.E_Usuario(Mail, Pw);
                    //unUsu = new N_EntidadesCompartidas.Usuarios(_lector["NombreEmpleado"].ToString(), _lector["Password"].ToString(), Convert.ToInt32(_lector["CIEmpleado"]));
                
             
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }

            return unUsu;
        }
    }
    #endregion
}

