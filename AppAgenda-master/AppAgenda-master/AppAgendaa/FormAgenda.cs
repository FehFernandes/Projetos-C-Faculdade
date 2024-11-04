using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAgendaa
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDAgendaDataSet1.TbPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPessoaTableAdapter.Fill(this.bDAgendaDataSet1.TbPessoa);
            // TODO: esta linha de código carrega dados na tabela 'bDAgendaDataSet1.TbPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tbPessoaTableAdapter.Fill(this.bDAgendaDataSet1.TbPessoa);

        }

        private void tbPessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbPessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDAgendaDataSet1);

        }

        private void tbPessoaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbPessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDAgendaDataSet1);

        }
    }
}
