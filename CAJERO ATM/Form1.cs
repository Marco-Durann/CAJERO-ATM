using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAJERO_ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
           TextBox txtInput;
            if (CONTRASEÑA.CanSelect)
            {
                CONTRASEÑA.Text = "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            CONTRASEÑA.clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form1 formLogin = new Form1();
            formLogin.ShowDialog();
            
          //  CANCELAR.Clear(); // Esto borrará el texto ingresado

            // Cerrar el formulario actual, lo que detendrá la ejecución del programa
            this.Close();
        }
}
}
