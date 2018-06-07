namespace CartAgenda
{
    partial class formUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUpdate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 38);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(83, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(217, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificação:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(82, 89);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(236, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Campo:";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(82, 121);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(236, 21);
            this.cbCampo.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 44);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(123, 12);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 15;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(12, 12);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 14;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // formUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 203);
            this.Controls.Add(this.rbPessoaJuridica);
            this.Controls.Add(this.rbPessoaFisica);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formUpdate";
            this.Text = "Edição";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
    }
}