using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace G5_Ejercicio2F
{
    class Alumno
    {

        //Atributos
        private string nombre;
        private DateTime nacimiento;
        private string correo;
        private string responsable;
        private string carnet;
        
        //Propiedades con validación
        public string Nombre
        {
            get { return nombre; }

            set
            {
                nombre = value;
                if (nombre == "")
                {
                    throw new Exception("No tiene que haber espacios en blanco");
                }

                foreach (char letra in nombre)
                {
                    //Permitimos lo siguiente
                    switch (letra)
                    {

                        case 'Á': continue;
                        case 'É': continue;
                        case 'Í': continue;
                        case 'Ó': continue;
                        case 'Ú': continue;

                    }


                }
            }
        }

        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set
            {
                nacimiento = value;

                if (nacimiento > System.DateTime.Now.Date)
                {
                    throw new Exception("Ese nacimiento aun no ha ocurrido");
                }
            }
        }

        public string Correo
        {
            get { return correo; }
            set
            {
                correo = value;

                string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9- ]+)*(.[a - z]{ 2,4})$";
                if (Regex.IsMatch(correo, expresion))
                {
                    if (Regex.Replace(correo, expresion, string.Empty).Length == 0)
                    {

                    }
                    else
                    {
                        throw new Exception("Direccion de correo no valida");
                    }
                }
                else
                {
                    throw new Exception("Direccion de correo no valida");
                }
            }
        }

        public string Responsable
        {
            get { return responsable; }
            set
            {
                responsable = value;
                if (responsable == "")
                {
                    throw new Exception("No tiene que haber espacios en blanco");
                }

                foreach (char letra in responsable)
                {
                    //Permitimos lo siguiente
                    switch (letra)
                    {

                        case 'Á': continue;
                        case 'É': continue;
                        case 'Í': continue;
                        case 'Ó': continue;
                        case 'Ú': continue;

                    }

                }
            }
        }
    }
}
