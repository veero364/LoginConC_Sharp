using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using Entidades;

namespace DEMO
{
    public partial class Loguin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblError.Text = "";

        }

        protected void BtnLogueo_Click(object sender, EventArgs e)
        {
            try
            {
                //verifico usuario

                string ciusu = TxtNomUsu.Text.Trim();
                string paswd = (TxtPassUsu.Text.Trim()).ToString();



                Entidades.E_Usuario unUsu = Logica.L_Usuario.Logueo(ciusu, paswd);

                if (unUsu != null)
                {
                    //si llego aca es pq es valido

                    Debug.WriteLine("valor de prueba-->" + Session["UsuarioCI"]);
                    // LblError.Text = (unUsu.CIEmpleado.);
                    Response.Redirect("Home.aspx");
                }
                else
                    Session["UsuarioCI"] = null;
                LblError.Visible = true;
                LblError.Text = "Datos Incorrectos";
            }
            catch (Exception ex)
            {
                LblError.Visible = true;
                LblError.Text = ex.Message;
            }
        }
    } 
}