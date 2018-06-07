namespace CartAgenda.Models_Views
{
    partial class formAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAgendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdCartAgendaDataSet = new CartAgenda.bdCartAgendaDataSet();
            this.agendaTableAdapter = new CartAgenda.bdCartAgendaDataSetTableAdapters.AgendaTableAdapter();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCartAgendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(59, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(59, 44);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha: ";
            // 
            // btnAgenda
            // 
            this.btnAgenda.Location = new System.Drawing.Point(40, 78);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(75, 23);
            this.btnAgenda.TabIndex = 4;
            this.btnAgenda.Text = "Inserir";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAgendaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(165, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 95);
            this.dataGridView1.TabIndex = 5;
            // 
            // idAgendaDataGridViewTextBoxColumn
            // 
            this.idAgendaDataGridViewTextBoxColumn.DataPropertyName = "idAgenda";
            this.idAgendaDataGridViewTextBoxColumn.HeaderText = "idAgenda";
            this.idAgendaDataGridViewTextBoxColumn.Name = "idAgendaDataGridViewTextBoxColumn";
            this.idAgendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.bdCartAgendaDataSet;
            // 
            // bdCartAgendaDataSet
            // 
            this.bdCartAgendaDataSet.DataSetName = "bdCartAgendaDataSet";
            this.bdCartAgendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::CartAgenda.Properties.Resources.Home;
            this.btnHome.Location = new System.Drawing.Point(534, 6);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 95);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // formAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 113);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgenda);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.formAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCartAgendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgenda;
        //private bdCartAgendaDataSet1 bdCartAgendaDataSet11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdCartAgendaDataSet bdCartAgendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private bdCartAgendaDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHome;
    }
}