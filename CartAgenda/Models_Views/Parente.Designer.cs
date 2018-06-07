namespace CartAgenda.Models_Views
{
    partial class formParente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formParente));
            this.gbParente = new System.Windows.Forms.GroupBox();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtParente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnParente = new System.Windows.Forms.Button();
            this.gbParente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbParente
            // 
            this.gbParente.Controls.Add(this.txtParentesco);
            this.gbParente.Controls.Add(this.label17);
            this.gbParente.Controls.Add(this.txtParente);
            this.gbParente.Controls.Add(this.label16);
            this.gbParente.Location = new System.Drawing.Point(15, 12);
            this.gbParente.Name = "gbParente";
            this.gbParente.Size = new System.Drawing.Size(257, 83);
            this.gbParente.TabIndex = 46;
            this.gbParente.TabStop = false;
            this.gbParente.Text = "Parente";
            // 
            // txtParentesco
            // 
            this.txtParentesco.Location = new System.Drawing.Point(87, 45);
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.Size = new System.Drawing.Size(164, 20);
            this.txtParentesco.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Parentesco:";
            // 
            // txtParente
            // 
            this.txtParente.Location = new System.Drawing.Point(87, 19);
            this.txtParente.Name = "txtParente";
            this.txtParente.Size = new System.Drawing.Size(164, 20);
            this.txtParente.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Parente:";
            // 
            // btnParente
            // 
            this.btnParente.Location = new System.Drawing.Point(102, 101);
            this.btnParente.Name = "btnParente";
            this.btnParente.Size = new System.Drawing.Size(75, 23);
            this.btnParente.TabIndex = 47;
            this.btnParente.Text = "Adicionar";
            this.btnParente.UseVisualStyleBackColor = true;
            this.btnParente.Click += new System.EventHandler(this.btnParente_Click);
            // 
            // formParente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.btnParente);
            this.Controls.Add(this.gbParente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formParente";
            this.Text = "Parente";
            this.gbParente.ResumeLayout(false);
            this.gbParente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParente;
        private System.Windows.Forms.TextBox txtParentesco;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtParente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnParente;
    }
}