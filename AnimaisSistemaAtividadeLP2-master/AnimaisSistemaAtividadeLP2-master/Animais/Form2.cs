using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animais
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //usa o metodo EmitirSom da classe Galinha

            Galinha galinha = new Galinha("Galinha", 2);

            galinha.EmitirSom();

            //Abre uma caixa de mensagem com o som emitido pela galinha

            MessageBox.Show("Có có có!");















        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Galinha galinha = new Galinha("Galinha", 2);


            MessageBox.Show("Nome: " + galinha.Nome + "\nIdade: " + galinha.Idade);

        }
    }
}
