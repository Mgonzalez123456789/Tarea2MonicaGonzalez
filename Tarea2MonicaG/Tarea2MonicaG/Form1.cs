using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2MonicaG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero1textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            decimal numero1 = Convert.ToDecimal(Numero1textBox1.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox2.Text);
            decimal numero3 = Convert.ToDecimal(Numero3textBox3.Text);
            decimal numero4 = Convert.ToDecimal(Numero4textBox4.Text);

            decimal resultado = await PromedioAsync(numero1, numero2, numero3, numero4);

            MessageBox.Show($"El promedio final es: {resultado}");
        }

        private async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return n1 + n2 + n3 + n4 / 4;
            });
            return promedio;
        }

    }
}
