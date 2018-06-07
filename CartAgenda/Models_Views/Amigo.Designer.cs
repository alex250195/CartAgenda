namespace CartAgenda.Models_Views
{
    partial class formAmigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAmigo));
            this.gbAmizade = new System.Windows.Forms.GroupBox();
            this.dtDataAmizade = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAmigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAmigo = new System.Windows.Forms.Button();
            this.gbAmizade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAmizade
            // 
            this.gbAmizade.Controls.Add(this.dtDataAmizade);
            this.gbAmizade.Controls.Add(this.label15);
            this.gbAmizade.Controls.Add(this.txtAmigo);
            this.gbAmizade.Controls.Add(this.label14);
            this.gbAmizade.Location = new System.Drawing.Point(12, 12);
            this.gbAmizade.Name = "gbAmizade";
            this.gbAmizade.Size = new System.Drawing.Size(259, 82);
            this.gbAmizade.TabIndex = 47;
            this.gbAmizade.TabStop = false;
            this.gbAmizade.Text = "Amizade";
            // 
            // dtDataAmizade
            // 
            this.dtDataAmizade.Location = new System.Drawing.Point(89, 43);
            this.dtDataAmizade.Mask = "00/00/0000";
            this.dtDataAmizade.Name = "dtDataAmizade";
            this.dtDataAmizade.Size = new System.Drawing.Size(164, 20);
            this.dtDataAmizade.TabIndex = 20;
            this.dtDataAmizade.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Data Início:";
            // 
            // txtAmigo
            // 
            this.txtAmigo.Location = new System.Drawing.Point(89, 17);
            this.txtAmigo.Name = "txtAmigo";
            this.txtAmigo.Size = new System.Drawing.Size(164, 20);
            this.txtAmigo.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Amigo:";
            // 
            // btnAmigo
            // 
            this.btnAmigo.Location = new System.Drawing.Point(101, 100);
            this.btnAmigo.Name = "btnAmigo";
            this.btnAmigo.Size = new System.Drawing.Size(75, 23);
            this.btnAmigo.TabIndex = 48;
            this.btnAmigo.Text = "Adicionar";
            this.btnAmigo.UseVisualStyleBackColor = true;
            this.btnAmigo.Click += new System.EventHandler(this.btnAmigo_Click);
            // 
            // formAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.btnAmigo);
            this.Controls.Add(this.gbAmizade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAmigo";
            this.Text = "Amigo";
            this.gbAmizade.ResumeLayout(false);
            this.gbAmizade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAmizade;
        private System.Windows.Forms.MaskedTextBox dtDataAmizade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAmigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAmigo;
    }
}