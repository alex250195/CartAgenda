namespace CartAgenda
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.idPessoaJuridicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwPessoaJuridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCartAgendaDataSet = new CartAgenda.bdCartAgendaDataSet();
            this.idPessoaFisicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgaoEmissorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwPessoaFisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwPessoaFisicaTableAdapter = new CartAgenda.bdCartAgendaDataSetTableAdapters.vwPessoaFisicaTableAdapter();
            this.vwPessoaJuridicaTableAdapter = new CartAgenda.bdCartAgendaDataSetTableAdapters.vwPessoaJuridicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPessoaJuridicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCartAgendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPessoaFisicaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaFisicaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.orgaoEmissorDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.profissaoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwPessoaFisicaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 141);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.label8);
            this.gbFiltro.Controls.Add(this.label7);
            this.gbFiltro.Controls.Add(this.label6);
            this.gbFiltro.Controls.Add(this.textBox1);
            this.gbFiltro.Controls.Add(this.button7);
            this.gbFiltro.Controls.Add(this.label5);
            this.gbFiltro.Controls.Add(this.label4);
            this.gbFiltro.Controls.Add(this.label3);
            this.gbFiltro.Controls.Add(this.comboBox1);
            this.gbFiltro.Location = new System.Drawing.Point(12, 481);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(747, 49);
            this.gbFiltro.TabIndex = 2;
            this.gbFiltro.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(694, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "registros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "N° Registros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(599, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "|";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(517, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Filtrar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pesquisar/Filtrar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ordenar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bem Vindo";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Red;
            this.lbNome.Location = new System.Drawing.Point(108, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(49, 20);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.button2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 127);
            this.panel1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Image = global::CartAgenda.Properties.Resources.Sem_Título_22;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.Location = new System.Drawing.Point(654, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 119);
            this.button6.TabIndex = 19;
            this.button6.Text = "Fechar";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Info;
            this.btnExcluir.Image = global::CartAgenda.Properties.Resources.Symbol___Delete1;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.Location = new System.Drawing.Point(191, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 119);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Image = global::CartAgenda.Properties.Resources.Help;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(561, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 119);
            this.button5.TabIndex = 18;
            this.button5.Text = "Ajuda";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Info;
            this.btnInsert.Image = global::CartAgenda.Properties.Resources.Symbol___Add;
            this.btnInsert.Location = new System.Drawing.Point(5, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 119);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Info;
            this.button4.Image = global::CartAgenda.Properties.Resources.Disk_DVD1;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.Location = new System.Drawing.Point(470, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 119);
            this.button4.TabIndex = 17;
            this.button4.Text = "Exportar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Image = global::CartAgenda.Properties.Resources.Document_Edit;
            this.btnUpdate.Location = new System.Drawing.Point(98, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 119);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Info;
            this.btnPrint.Image = global::CartAgenda.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.Location = new System.Drawing.Point(377, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 119);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Image = global::CartAgenda.Properties.Resources.Refresh;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(284, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 119);
            this.button2.TabIndex = 15;
            this.button2.Text = "Atualizar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaJuridicaDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn1,
            this.cNPJDataGridViewTextBoxColumn,
            this.proprietarioDataGridViewTextBoxColumn,
            this.ramoDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.vwPessoaJuridicaBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(12, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(747, 153);
            this.dataGridView2.TabIndex = 15;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // idPessoaJuridicaDataGridViewTextBoxColumn
            // 
            this.idPessoaJuridicaDataGridViewTextBoxColumn.DataPropertyName = "idPessoaJuridica";
            this.idPessoaJuridicaDataGridViewTextBoxColumn.HeaderText = "idPessoaJuridica";
            this.idPessoaJuridicaDataGridViewTextBoxColumn.Name = "idPessoaJuridicaDataGridViewTextBoxColumn";
            // 
            // razaoSocialDataGridViewTextBoxColumn1
            // 
            this.razaoSocialDataGridViewTextBoxColumn1.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn1.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn1.Name = "razaoSocialDataGridViewTextBoxColumn1";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // proprietarioDataGridViewTextBoxColumn
            // 
            this.proprietarioDataGridViewTextBoxColumn.DataPropertyName = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.HeaderText = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.Name = "proprietarioDataGridViewTextBoxColumn";
            // 
            // ramoDataGridViewTextBoxColumn
            // 
            this.ramoDataGridViewTextBoxColumn.DataPropertyName = "Ramo";
            this.ramoDataGridViewTextBoxColumn.HeaderText = "Ramo";
            this.ramoDataGridViewTextBoxColumn.Name = "ramoDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn1
            // 
            this.telefoneDataGridViewTextBoxColumn1.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn1.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn1.Name = "telefoneDataGridViewTextBoxColumn1";
            // 
            // vwPessoaJuridicaBindingSource
            // 
            this.vwPessoaJuridicaBindingSource.DataMember = "vwPessoaJuridica";
            this.vwPessoaJuridicaBindingSource.DataSource = this.bdCartAgendaDataSet;
            // 
            // bdCartAgendaDataSet
            // 
            this.bdCartAgendaDataSet.DataSetName = "bdCartAgendaDataSet";
            this.bdCartAgendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idPessoaFisicaDataGridViewTextBoxColumn
            // 
            this.idPessoaFisicaDataGridViewTextBoxColumn.DataPropertyName = "idPessoaFisica";
            this.idPessoaFisicaDataGridViewTextBoxColumn.HeaderText = "idPessoaFisica";
            this.idPessoaFisicaDataGridViewTextBoxColumn.Name = "idPessoaFisicaDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // orgaoEmissorDataGridViewTextBoxColumn
            // 
            this.orgaoEmissorDataGridViewTextBoxColumn.DataPropertyName = "OrgaoEmissor";
            this.orgaoEmissorDataGridViewTextBoxColumn.HeaderText = "OrgaoEmissor";
            this.orgaoEmissorDataGridViewTextBoxColumn.Name = "orgaoEmissorDataGridViewTextBoxColumn";
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            // 
            // profissaoDataGridViewTextBoxColumn
            // 
            this.profissaoDataGridViewTextBoxColumn.DataPropertyName = "Profissao";
            this.profissaoDataGridViewTextBoxColumn.HeaderText = "Profissao";
            this.profissaoDataGridViewTextBoxColumn.Name = "profissaoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // vwPessoaFisicaBindingSource
            // 
            this.vwPessoaFisicaBindingSource.DataMember = "vwPessoaFisica";
            this.vwPessoaFisicaBindingSource.DataSource = this.bdCartAgendaDataSet;
            // 
            // vwPessoaFisicaTableAdapter
            // 
            this.vwPessoaFisicaTableAdapter.ClearBeforeFill = true;
            // 
            // vwPessoaJuridicaTableAdapter
            // 
            this.vwPessoaJuridicaTableAdapter.ClearBeforeFill = true;
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 550);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CartAgenda";
            this.Load += new System.EventHandler(this.formHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPessoaJuridicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCartAgendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwPessoaFisicaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private bdCartAgendaDataSet bdCartAgendaDataSet;
        private System.Windows.Forms.BindingSource vwPessoaFisicaBindingSource;
        private bdCartAgendaDataSetTableAdapters.vwPessoaFisicaTableAdapter vwPessoaFisicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaFisicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgaoEmissorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwPessoaJuridicaBindingSource;
        private bdCartAgendaDataSetTableAdapters.vwPessoaJuridicaTableAdapter vwPessoaJuridicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaJuridicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}