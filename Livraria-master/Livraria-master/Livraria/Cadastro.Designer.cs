namespace Livraria
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label local_de_edicaoLabel;
            System.Windows.Forms.Label editoraLabel;
            System.Windows.Forms.Label ano_de_edicaoLabel;
            System.Windows.Forms.Label num_PaginasLabel;
            System.Windows.Forms.Label temaLabel;
            this.bibliotecaDBDataSet = new Livraria.BibliotecaDBDataSet();
            this.tbLivroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbLivroTableAdapter = new Livraria.BibliotecaDBDataSetTableAdapters.TbLivroTableAdapter();
            this.tableAdapterManager = new Livraria.BibliotecaDBDataSetTableAdapters.TableAdapterManager();
            this.tbLivroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tbLivroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.local_de_edicaoTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.ano_de_edicaoTextBox = new System.Windows.Forms.TextBox();
            this.num_PaginasTextBox = new System.Windows.Forms.TextBox();
            this.temaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            local_de_edicaoLabel = new System.Windows.Forms.Label();
            editoraLabel = new System.Windows.Forms.Label();
            ano_de_edicaoLabel = new System.Windows.Forms.Label();
            num_PaginasLabel = new System.Windows.Forms.Label();
            temaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingNavigator)).BeginInit();
            this.tbLivroBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bibliotecaDBDataSet
            // 
            this.bibliotecaDBDataSet.DataSetName = "BibliotecaDBDataSet";
            this.bibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbLivroBindingSource
            // 
            this.tbLivroBindingSource.DataMember = "TbLivro";
            this.tbLivroBindingSource.DataSource = this.bibliotecaDBDataSet;
            // 
            // tbLivroTableAdapter
            // 
            this.tbLivroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TbLivroTableAdapter = this.tbLivroTableAdapter;
            this.tableAdapterManager.UpdateOrder = Livraria.BibliotecaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbLivroBindingNavigator
            // 
            this.tbLivroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbLivroBindingNavigator.BindingSource = this.tbLivroBindingSource;
            this.tbLivroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbLivroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbLivroBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLivroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbLivroBindingNavigatorSaveItem});
            this.tbLivroBindingNavigator.Location = new System.Drawing.Point(0, 375);
            this.tbLivroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbLivroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbLivroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbLivroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbLivroBindingNavigator.Name = "tbLivroBindingNavigator";
            this.tbLivroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbLivroBindingNavigator.Size = new System.Drawing.Size(508, 25);
            this.tbLivroBindingNavigator.TabIndex = 0;
            this.tbLivroBindingNavigator.Text = "bindingNavigator1";
            this.tbLivroBindingNavigator.RefreshItems += new System.EventHandler(this.tbLivroBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
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
            // tbLivroBindingNavigatorSaveItem
            // 
            this.tbLivroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbLivroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbLivroBindingNavigatorSaveItem.Image")));
            this.tbLivroBindingNavigatorSaveItem.Name = "tbLivroBindingNavigatorSaveItem";
            this.tbLivroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbLivroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbLivroBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbLivroBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(185, 105);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(264, 102);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(172, 131);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(49, 16);
            autorLabel.TabIndex = 3;
            autorLabel.Text = "Autor:";
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Autor", true));
            this.autorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTextBox.Location = new System.Drawing.Point(264, 128);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(100, 22);
            this.autorTextBox.TabIndex = 4;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(172, 157);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(51, 16);
            tituloLabel.TabIndex = 5;
            tituloLabel.Text = "Titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Titulo", true));
            this.tituloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.Location = new System.Drawing.Point(264, 154);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(100, 22);
            this.tituloTextBox.TabIndex = 6;
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iSBNLabel.Location = new System.Drawing.Point(172, 183);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(51, 16);
            iSBNLabel.TabIndex = 7;
            iSBNLabel.Text = "ISBN:";
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "ISBN", true));
            this.iSBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iSBNTextBox.Location = new System.Drawing.Point(264, 180);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 22);
            this.iSBNTextBox.TabIndex = 8;
            // 
            // local_de_edicaoLabel
            // 
            local_de_edicaoLabel.AutoSize = true;
            local_de_edicaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            local_de_edicaoLabel.Location = new System.Drawing.Point(131, 209);
            local_de_edicaoLabel.Name = "local_de_edicaoLabel";
            local_de_edicaoLabel.Size = new System.Drawing.Size(127, 16);
            local_de_edicaoLabel.TabIndex = 9;
            local_de_edicaoLabel.Text = "Local de edicao:";
            // 
            // local_de_edicaoTextBox
            // 
            this.local_de_edicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Local_de_edicao", true));
            this.local_de_edicaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local_de_edicaoTextBox.Location = new System.Drawing.Point(264, 206);
            this.local_de_edicaoTextBox.Name = "local_de_edicaoTextBox";
            this.local_de_edicaoTextBox.Size = new System.Drawing.Size(100, 22);
            this.local_de_edicaoTextBox.TabIndex = 10;
            // 
            // editoraLabel
            // 
            editoraLabel.AutoSize = true;
            editoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editoraLabel.Location = new System.Drawing.Point(172, 235);
            editoraLabel.Name = "editoraLabel";
            editoraLabel.Size = new System.Drawing.Size(63, 16);
            editoraLabel.TabIndex = 11;
            editoraLabel.Text = "Editora:";
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Editora", true));
            this.editoraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editoraTextBox.Location = new System.Drawing.Point(264, 232);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(100, 22);
            this.editoraTextBox.TabIndex = 12;
            // 
            // ano_de_edicaoLabel
            // 
            ano_de_edicaoLabel.AutoSize = true;
            ano_de_edicaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ano_de_edicaoLabel.Location = new System.Drawing.Point(142, 261);
            ano_de_edicaoLabel.Name = "ano_de_edicaoLabel";
            ano_de_edicaoLabel.Size = new System.Drawing.Size(116, 16);
            ano_de_edicaoLabel.TabIndex = 13;
            ano_de_edicaoLabel.Text = "Ano de edicao:";
            // 
            // ano_de_edicaoTextBox
            // 
            this.ano_de_edicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Ano_de_edicao", true));
            this.ano_de_edicaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ano_de_edicaoTextBox.Location = new System.Drawing.Point(264, 258);
            this.ano_de_edicaoTextBox.Name = "ano_de_edicaoTextBox";
            this.ano_de_edicaoTextBox.Size = new System.Drawing.Size(100, 22);
            this.ano_de_edicaoTextBox.TabIndex = 14;
            // 
            // num_PaginasLabel
            // 
            num_PaginasLabel.AutoSize = true;
            num_PaginasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_PaginasLabel.Location = new System.Drawing.Point(151, 287);
            num_PaginasLabel.Name = "num_PaginasLabel";
            num_PaginasLabel.Size = new System.Drawing.Size(107, 16);
            num_PaginasLabel.TabIndex = 15;
            num_PaginasLabel.Text = "Num Paginas:";
            // 
            // num_PaginasTextBox
            // 
            this.num_PaginasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Num_Paginas", true));
            this.num_PaginasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_PaginasTextBox.Location = new System.Drawing.Point(264, 284);
            this.num_PaginasTextBox.Name = "num_PaginasTextBox";
            this.num_PaginasTextBox.Size = new System.Drawing.Size(100, 22);
            this.num_PaginasTextBox.TabIndex = 16;
            // 
            // temaLabel
            // 
            temaLabel.AutoSize = true;
            temaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temaLabel.Location = new System.Drawing.Point(172, 313);
            temaLabel.Name = "temaLabel";
            temaLabel.Size = new System.Drawing.Size(52, 16);
            temaLabel.TabIndex = 17;
            temaLabel.Text = "Tema:";
            // 
            // temaTextBox
            // 
            this.temaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbLivroBindingSource, "Tema", true));
            this.temaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temaTextBox.Location = new System.Drawing.Point(264, 310);
            this.temaTextBox.Name = "temaTextBox";
            this.temaTextBox.Size = new System.Drawing.Size(100, 22);
            this.temaTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastro de livros";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.tituloTextBox);
            this.Controls.Add(iSBNLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(local_de_edicaoLabel);
            this.Controls.Add(this.local_de_edicaoTextBox);
            this.Controls.Add(editoraLabel);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(ano_de_edicaoLabel);
            this.Controls.Add(this.ano_de_edicaoTextBox);
            this.Controls.Add(num_PaginasLabel);
            this.Controls.Add(this.num_PaginasTextBox);
            this.Controls.Add(temaLabel);
            this.Controls.Add(this.temaTextBox);
            this.Controls.Add(this.tbLivroBindingNavigator);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLivroBindingNavigator)).EndInit();
            this.tbLivroBindingNavigator.ResumeLayout(false);
            this.tbLivroBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotecaDBDataSet bibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource tbLivroBindingSource;
        private BibliotecaDBDataSetTableAdapters.TbLivroTableAdapter tbLivroTableAdapter;
        private BibliotecaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbLivroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbLivroBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox local_de_edicaoTextBox;
        private System.Windows.Forms.TextBox editoraTextBox;
        private System.Windows.Forms.TextBox ano_de_edicaoTextBox;
        private System.Windows.Forms.TextBox num_PaginasTextBox;
        private System.Windows.Forms.TextBox temaTextBox;
        private System.Windows.Forms.Label label1;
    }
}