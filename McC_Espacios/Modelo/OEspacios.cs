using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
// Expresiones Regulares
using System.Text.RegularExpressions;
namespace McC_Espacios.Modelo
{

    public class OEspacios : IDataErrorInfo
    {
        // Variables privadas de la clase
        private string id = "";
        private string denominacion = "";
        private string latitud = "";
        private string longitud = "";
        private string poblacion = "";
        private string provincia = "";
        private string direccion = "";
        private string cPostal = "";
        private string imagenPrincipal = "";// Luego ahy una tabla de imagenes relacionada por el id del Espacio
        private string plantaEdificio = "";
        private string utilidad = ""; // AGricultura, Industria, Vivienda, Almacen
        private string utilidadEspacio = "";//Viñedo, Fabrica, carretera, Piso, Bloque, alacen,,,,,,
        private string propiedad = "";// Publica, Privada, nombre persoana o Entridad propietaria
        private string dimiension = "";// M2 Matros cuadrados
        private string alto = "";
        private string ancho = "";
        private string fondo = "";
        private string valoracionEuros = "";
        private string precioAlquiler = "";

        //private string[] listaCiclos = new string[] { "DAM", "DAW", "SMR" };
        // Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");


        // Campos miembro de la clase
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Denominacion
        {
            get { return denominacion; }
            set { this.denominacion = value; }
        }
        public string Latitud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public string Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set {provincia = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string CPostal
        {
            get { return cPostal; }
            set { cPostal = value; }
        }
        public string ImagenPrincipal
        {
            get { return imagenPrincipal; }
            set { imagenPrincipal = value; }
        }
        public string PlantaEdificio
        {
            get { return plantaEdificio; }
            set { plantaEdificio = value; }
        }
        public string Utilidd
        {
            get { return utilidad; }
            set { utilidad = value; }
        }
        public string UtilidadEspacio
        {
            get { return utilidadEspacio; }
            set { utilidadEspacio = value; }
        }
        public string Propiedad
        {
            get { return propiedad; }
            set { propiedad = value; }
        }

        public string Dimiension
        {
            get { return dimiension; }
            set { dimiension = value; }
        }
        public string Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        public string Alto
        {
            get { return alto; }
            set { alto = value; }
        }
        public string Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        public string ValoracionEuros
        {
            get { return valoracionEuros; }
            set { valoracionEuros = value; }
        }
        public string PrecioAlquiler
        {
            get { return precioAlquiler; }
            set { precioAlquiler = value; }
        }

        //Email Validar utilizando expresiones regulares
        //   Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        //  return regex.IsMatch(s);

        public string Error
        {
            get
            {
                return null;
            }
        }




        // Metodo que es oblligatorio de implementar al extender la clase claseIDataErrorInfo
        public string this[string name]
        {

            get
            {
                string result = null;

                // Validar Ciclo
                /*     if (name == "Ciclo")
                     {
                         Boolean correcto = false;
                         foreach (string cicloRegistro in listaCiclos)
                         {
                             if (this.ciclo == cicloRegistro)
                             {
                                 correcto = true;
                                 break;
                             }

                         }
                         if (correcto == false)
                         {
                             result = "Ciclos Incorrecto(DAM, DAW, SMR.";
                         }
                     }


                     // Validar Curso formato correcto año-año

                     if (name == "Curso")
                     {
                         Regex regex = new Regex(@"\d{4}(-\d{4})$");
                         //  Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                         if (!regex.IsMatch(this.curso))
                         {
                             result = "Curso Incorrecto(yyyy-yyyy)";
                         }
                     }




                     // Validar Fecha 
                     if (name == "Fecha")
                     {
                         Regex regex = new Regex(@"(((0|1|2)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
                         // Regex regex = new Regex(@"(((0|1|2)[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

                         if (!regex.IsMatch(this.fecha))
                         {
                             result = "Fecha Incorrecta (dd/mm/yyyy)";
                         }
                     }

                     // Validar Email
                     if (name == "Email")
                     {
                         Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");


                         if (!regex.IsMatch(this.email))
                         {
                             result = "Email incorrectol";
                         }
                     }

                     // Validar enlace   
                     if (name == "Enlace")
                     {
                         Regex regex = new Regex(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$");


                         if (!regex.IsMatch(this.enlace))
                         {
                             result = "Enlace incorrectol";
                         }
                     }
                     */

                return result;
            }
        }
    }

}

    

