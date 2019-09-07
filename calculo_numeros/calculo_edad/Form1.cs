using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_edad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            string num1 = txtnumero1.Text;
            string num2 = txtnumero2.Text;

            int numero1 = int.Parse(num1);
            int numero2 = int.Parse(num2);

            if (numero1 > numero2) {

                lblmay.Text = numero1.ToString();
                lblmen.Text = numero2.ToString();
                lblmay.Visible = true;
                lblmen.Visible = true;


            }else{
                if (numero2 > numero1) {


                    lblmay.Text = numero2.ToString();
                    lblmen.Text = numero1.ToString();
                    lblmay.Visible = true;
                    lblmen.Visible = true;


                }else{

                    lblmay.Text = " Son iguales";
                    lblmen.Text = " Son iguales ";
                    lblmay.Visible = true;
                    lblmen.Visible = true;

                }




            }

        }
    }
}
