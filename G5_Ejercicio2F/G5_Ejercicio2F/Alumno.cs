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
        private double periodo1;
        private double periodo2;
        private double periodo3;
        private double prom;
        //Propiedades con validación


        public string Carnet
        {
            get { return carnet; }
            set
            {
                carnet = value;
                if (carnet == "")
                {
                    throw new Exception("Debe de llenar esta espacio");
                }
            }
        }

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
                    throw new Exception("Ese nacimiento no valida");
                }
            }
        }

        public string Correo
        {
            get { return correo; }
            set
            {
                correo = value;
                if (correo == "")
                {
                    throw new Exception("No puede dejar en blanco este espacio");
                }

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

        public double Periodo1
        {
            get { return periodo1; }
            set
            {
                periodo1 = value;
                if (periodo1 > 10)
                {
                    throw new Exception("La notas solamente existen en el rango de 0 a 10");
                }
            }
        }

        public double Periodo2
        {
            get { return periodo2; }
            set
            {
                periodo2 = value;
                if (periodo2 > 10)
                {
                    throw new Exception("La notas solamente existen en el rango de 0 a 10");
                }
            }
        }

        public double Periodo3
        {
            get { return periodo3; }
            set
            {
                periodo3 = value;
                if (periodo3 > 10)
                {
                    throw new Exception("La notas solamente existen en el rango de 0 a 10");
                }
            }
        }

        public double Prom
        {
            get { return prom; }
            set { prom = value; }
        }
    }
}
