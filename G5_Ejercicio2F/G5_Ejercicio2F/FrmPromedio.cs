using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G5_Ejercicio2F
{
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }

        private bool validarnotas()
        {
            bool validado = true;

            if (txtperiod1.Text == "")
            {
                validado = false;
                errorpro.SetError(txtperiod1, "Debe de llenar este campo");
            }

            if (txtperiod2.Text == "")
            {
                validado = false;
                errorpro.SetError(txtperiod2, "Debe de llenar este campo");
            }

            if (txtperiod3.Text == "")
            {
                validado = false;
                errorpro.SetError(txtperiod3, "Debe de llenar este campo");
            }
            return validado;
        }

        private void Bmensaje()
        {
            errorpro.SetError(txtperiod1, "");
            errorpro.SetError(txtperiod2, "");
            errorpro.SetError(txtperiod3, "");
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Alumno alum = new Alumno();
            Bmensaje();
            if (validarnotas())
            {
                try
                {
                    alum.Periodo1 = double.Parse(txtperiod1.Text);
                    alum.Periodo2 = double.Parse(txtperiod2.Text);
                    alum.Periodo3 = double.Parse(txtperiod3.Text);


                    alum.Prom = (alum.Periodo1 + alum.Periodo2 + alum.Periodo3) / 3;

                    MessageBox.Show("Tu promedio de notas es de: " + alum.Prom);
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void txtperiod1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtperiod1.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtperiod2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtperiod2.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtperiod3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtperiod3.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
