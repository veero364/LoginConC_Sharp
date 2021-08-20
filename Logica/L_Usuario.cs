using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Logica
{
    public class L_Usuario
    {


        #region Logueo
        public static Entidades.E_Usuario Logueo(string pMail, string pPw)
        {
            return (Persistencia.P_Usuario.Logueo(pMail, pPw));
        }
        #endregion
    }
}



