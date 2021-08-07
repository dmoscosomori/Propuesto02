using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propuesto02
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            
        }
        string getempleado()
        {
            return txtempleado.Text;
        }
        string getpuntualidad()
        {
            return cbopuntu.Text;
        }
        string getrendimiento()
        {
            return cobdefectuosas.Text;
        }
         int calculopuntutalidad()  
        {
            int puntajepun=0;
            switch (cbopuntu.Text)
            {
                case "0":
                     puntajepun = 10;
                    break;
                    
                case " 1 a 2":
                    puntajepun = 8;
                    break;
                case "3 a 5":
                     puntajepun = 6;
                    break;
                case "6 a 9":
                    puntajepun = 4;
                    break;
                case "Mas de 3":
                    puntajepun = 0;
                    break;
                       
            }
            return puntajepun;
            
        }
        int calculorendimiento()
        {
            int puntajerend = 0;
            switch (cobdefectuosas.Text)
            {
                case "0":
                     puntajerend = 10;
                    break;
                case "1":
                     puntajerend = 8;
                    break;
                case "2":
                     puntajerend = 5;
                    break;
                case "3":
                     puntajerend = 1;
                    break;
                case "Mas de 3":
                     puntajerend = 0;
                    break;
            }
            return puntajerend;
        }
        int puntajetotal()
        {
            return calculopuntutalidad()+calculorendimiento();
        }
        double calculobonificacion()
        {

            double bonificacion = 0;
            if (puntajetotal() < 11)
            {
                 bonificacion = puntajetotal() * 2.5;
            }
             if (puntajetotal() >= 11 && puntajetotal() <= 13)
            {
                bonificacion = puntajetotal() * 5;
            }
             if (puntajetotal() >= 14 && puntajetotal() <= 16)
            {
                bonificacion  = puntajetotal() * 7.5;
            }
             if (puntajetotal() >= 17 && puntajetotal() <= 19)
            {
                 bonificacion  = puntajetotal() * 10;
            }
             if (puntajetotal() == 20)
            {
               bonificacion  = puntajetotal() * 12.5;
            }
             return bonificacion;

        }
        

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            ListViewItem fila = new ListViewItem(getempleado());
            fila.SubItems.Add(getpuntualidad());
            fila.SubItems.Add(getrendimiento());
            fila.SubItems.Add(calculopuntutalidad().ToString("0.00"));
            fila.SubItems.Add(calculorendimiento().ToString("0.00"));
            fila.SubItems.Add(puntajetotal().ToString("0.00"));
            fila.SubItems.Add(calculobonificacion().ToString("0.00"));
            lvrespuestas.Items.Add(fila);

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            cbopuntu.Text = "Seleccionar";
            cobdefectuosas.Text = "Seleccionar";
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }
    }
}
