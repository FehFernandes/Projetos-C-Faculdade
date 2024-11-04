using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void tbLivroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDBDataSet);

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDBDataSet.TbLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tbLivroTableAdapter.Fill(this.bibliotecaDBDataSet.TbLivro);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Digite o Titulo do livro que deseja consultar
            string titulo = textBox1.Text;



        }
    }
}
