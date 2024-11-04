namespace SuporteAvaliaçãoFisica
{
    partial class CadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAluno));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label alturaLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label sexoLabel;
            this.academiaBDDataSet = new SuporteAvaliaçãoFisica.AcademiaBDDataSet();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new SuporteAvaliaçãoFisica.AcademiaBDDataSetTableAdapters.AlunoTableAdapter();
            this.tableAdapterManager = new SuporteAvaliaçãoFisica.AcademiaBDDataSetTableAdapters.TableAdapterManager();
            this.alunoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alunoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.alturaTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            alturaLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.academiaBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingNavigator)).BeginInit();
            this.alunoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // academiaBDDataSet
            // 
            this.academiaBDDataSet.DataSetName = "AcademiaBDDataSet";
            this.academiaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.academiaBDDataSet;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunoTableAdapter = this.alunoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfissionalLoginTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SuporteAvaliaçãoFisica.AcademiaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunoBindingNavigator
            // 
            this.alunoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunoBindingNavigator.BindingSource = this.alunoBindingSource;
            this.alunoBindingNavigator.CountItem = null;
            this.alunoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alunoBindingNavigatorSaveItem});
            this.alunoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alunoBindingNavigator.MoveFirstItem = null;
            this.alunoBindingNavigator.MoveLastItem = null;
            this.alunoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunoBindingNavigator.Name = "alunoBindingNavigator";
            this.alunoBindingNavigator.PositionItem = null;
            this.alunoBindingNavigator.Size = new System.Drawing.Size(301, 25);
            this.alunoBindingNavigator.TabIndex = 0;
            this.alunoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // alunoBindingNavigatorSaveItem
            // 
            this.alunoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunoBindingNavigatorSaveItem.Image")));
            this.alunoBindingNavigatorSaveItem.Name = "alunoBindingNavigatorSaveItem";
            this.alunoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.alunoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.alunoBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunoBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(80, 68);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(117, 65);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(70, 94);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Nome", true));
            this.nomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeTextBox.Location = new System.Drawing.Point(117, 91);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomeTextBox.TabIndex = 4;
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idadeLabel.Location = new System.Drawing.Point(70, 120);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(45, 16);
            idadeLabel.TabIndex = 5;
            idadeLabel.Text = "Idade:";
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Idade", true));
            this.idadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idadeTextBox.Location = new System.Drawing.Point(117, 117);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(100, 22);
            this.idadeTextBox.TabIndex = 6;
            // 
            // alturaLabel
            // 
            alturaLabel.AutoSize = true;
            alturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            alturaLabel.Location = new System.Drawing.Point(70, 146);
            alturaLabel.Name = "alturaLabel";
            alturaLabel.Size = new System.Drawing.Size(44, 16);
            alturaLabel.TabIndex = 7;
            alturaLabel.Text = "Altura:";
            // 
            // alturaTextBox
            // 
            this.alturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Altura", true));
            this.alturaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alturaTextBox.Location = new System.Drawing.Point(117, 143);
            this.alturaTextBox.Name = "alturaTextBox";
            this.alturaTextBox.Size = new System.Drawing.Size(100, 22);
            this.alturaTextBox.TabIndex = 8;
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(70, 172);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(42, 16);
            pesoLabel.TabIndex = 9;
            pesoLabel.Text = "Peso:";
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Peso", true));
            this.pesoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTextBox.Location = new System.Drawing.Point(117, 169);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(100, 22);
            this.pesoTextBox.TabIndex = 10;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(70, 198);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(41, 16);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunoBindingSource, "Sexo", true));
            this.sexoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexoTextBox.Location = new System.Drawing.Point(117, 195);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(100, 22);
            this.sexoTextBox.TabIndex = 12;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 271);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(idadeLabel);
            this.Controls.Add(this.idadeTextBox);
            this.Controls.Add(alturaLabel);
            this.Controls.Add(this.alturaTextBox);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(this.alunoBindingNavigator);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.academiaBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingNavigator)).EndInit();
            this.alunoBindingNavigator.ResumeLayout(false);
            this.alunoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AcademiaBDDataSet academiaBDDataSet;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private AcademiaBDDataSetTableAdapters.AlunoTableAdapter alunoTableAdapter;
        private AcademiaBDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alunoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.TextBox alturaTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
    }
}