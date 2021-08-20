using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Usuario
    {
        //Atributos
        private string _Mail;
        private string _Nombre;
        private string _Apellido;
        private DateTime _FechaNac;
        private string _Direccion;
        private string _Localidad;
        private string _Cel;
        private string _Pw;
        private string _TipoDeUsu;




        //Propiedades

        public string Mail
        {
            set
            {
                if (value.Length <= 25)
                    _Mail = value;
                else
                    throw new Exception("El campo no puede exceder los 25 caracteres");
            }
            get { return _Mail; }
        }
        public string Nombre
        {
            set
            {
                if (value.Length <= 25)
                    _Nombre = value;
                else
                    throw new Exception("El campo no puede exceder los 25 caracteres");
            }
            get { return _Nombre; }
        }

        public string Apellido
        {
            set
            {
                if (value.Length <= 25)
                    _Apellido = value;
                else
                    throw new Exception("El campo no puede exceder los 25 caracteres");
            }
            get { return _Apellido; }
        }

        public DateTime FechaNac
        { get; set; }


        public string Direccion
        {
            set
            {
                if (value.Length <= 25)
                    _Direccion = value;
                else
                    throw new Exception("El campo no puede exceder los 25 caracteres");
            }
            get { return _Direccion; }
        }

        public string Localidad
        {
            set
            {
                if (value.Length <= 25)
                    _Localidad = value;
                else
                    throw new Exception("El campo no puede exceder los 25 caracteres");
            }
            get { return _Localidad; }
        }

        public string Cel
        {
            set
            {
                if (value.Length <= 25)
                    _Cel = value;
                else
                    throw new Exception("El campo no puede exceder los 25 caracteres");
            }
            get { return _Cel; }
        }

        public string Pw
        {
            set
            {
                if (value.Length <= 25)

                    _Pw = value;
                else
                    throw new Exception("El pasword ingresado no puede ser superior a 25 digitos.");
            }
            get { return _Pw; }
        }

          public string TipoDeUsu
          {
            set
            {
                if (value.Length <= 25)

                    _TipoDeUsu = value;
                else
                    throw new Exception("El pasword ingresado no puede ser superior a 25 digitos.");
            }
            get { return _TipoDeUsu; }
          }

        //Constructores
        public E_Usuario(string pMail, string pNombre, string pApellido, DateTime pFechaNac, string pDireccion, string pLocalidad, string pCel, string pPw, string pTipoDeUsu)

        {//propiedad=parametro
            Mail = pMail;
            Nombre = pNombre;
            Apellido = pApellido;
            FechaNac = pFechaNac;
            Direccion = pDireccion;
            Localidad = pLocalidad;
            Cel = pCel;
            Pw = pPw;
            TipoDeUsu = pTipoDeUsu;
        }

        public E_Usuario(string mail, string pw)
        {
            Mail = mail;
            Pw = pw;
        }

        //Operaciones
        public override string ToString()
        {
            string _completo = ToString() + " Datos del usuario: " + _Nombre;



            return (_completo);
        }
    }
}
