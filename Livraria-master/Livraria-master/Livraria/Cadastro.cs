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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void tbLivroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDBDataSet);

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDBDataSet.TbLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tbLivroTableAdapter.Fill(this.bibliotecaDBDataSet.TbLivro);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDBDataSet.TbLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tbLivroTableAdapter.Fill(this.bibliotecaDBDataSet.TbLivro);

        }

        private void tbLivroBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDBDataSet);

        }

        private void tbLivroBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
