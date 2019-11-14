using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getCardUid
{
    public static class conexion
    {
        static string _fuente;
        static string _catalogo;
        static string _user;
        static string _pass;
        static string _foto;
        static string _color;
        static string _rutaImg;
        static string _cedula;


        public static string Fuente
        {

            get
            {
                return _fuente;
            }
            set
            {
                _fuente = value;
            }

        }
        public static string Cedula
        {

            get
            {
                return _cedula;
            }
            set
            {
                _cedula = value;
            }

        }

        public static string RutaImg
        {

            get
            {
                return _rutaImg;
            }
            set
            {
                _rutaImg = value;
            }

        }

        public static string Colores
        {

            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }

        }

        public static string Fotografia
        {

            get
            {
                return _foto;
            }
            set
            {
                _foto = value;
            }

        }


        public static string Catalogo
        {

            get
            {
                return _catalogo;
            }
            set
            {
                _catalogo = value;
            }

        }

        public static string User
        {

            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }

        }

        public static string Password
        {

            get
            {
                return _pass;
            }
            set
            {
                _pass = value;
            }

        }


    }
}
