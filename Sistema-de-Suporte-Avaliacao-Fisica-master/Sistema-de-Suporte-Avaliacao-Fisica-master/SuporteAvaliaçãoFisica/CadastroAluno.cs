using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuporteAvaliaçãoFisica
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.academiaBDDataSet);

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaBDDataSet.Aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.academiaBDDataSet.Aluno);

        }
    }
}
