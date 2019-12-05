using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenar_vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(this.txttamaño.Text);
            int[] vector = Clases.ordenar_vector.generar(tamanio);

            lstNumeros.Items.Clear();
            for(int i=0; i<tamanio; i++)
            {
                lstNumeros.Items.Add(vector[i].ToString ());

            }
            //ordenar el vector y vuelvo a cargar la lista
            Clases.ordenar_vector.ordenar(vector, tamanio);


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnordenar_Click(object sender, EventArgs e)
        {

        }
    }
}
