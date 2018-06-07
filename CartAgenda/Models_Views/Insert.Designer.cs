namespace CartAgenda
{
    partial class formInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInsert));
            this.label1 = new System.Windows.Forms.Label();
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.gbSenha = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.gbCadastroJuridico = new System.Windows.Forms.GroupBox();
            this.txtProprietario = new System.Windows.Forms.TextBox();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.txtRamo = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.btnParente = new System.Windows.Forms.Button();
            this.btnAmizade = new System.Windows.Forms.Button();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtTipoEndereco = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutro = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecado = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComercial = new System.Windows.Forms.MaskedTextBox();
            this.lbResidencial = new System.Windows.Forms.Label();
            this.txtResidencial = new System.Windows.Forms.MaskedTextBox();
            this.gbCadastroFisico = new System.Windows.Forms.GroupBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmissor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.gbSenha.SuspendLayout();
            this.gbCadastroJuridico.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.gbCadastroFisico.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(49, 7);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 1;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(147, 7);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 2;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // gbSenha
            // 
            this.gbSenha.Controls.Add(this.txtSenha);
            this.gbSenha.Controls.Add(this.label54);
            this.gbSenha.Location = new System.Drawing.Point(15, 276);
            this.gbSenha.Name = "gbSenha";
            this.gbSenha.Size = new System.Drawing.Size(260, 57);
            this.gbSenha.TabIndex = 49;
            this.gbSenha.TabStop = false;
            this.gbSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(59, 22);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(186, 20);
            this.txtSenha.TabIndex = 12;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 25);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 13);
            this.label54.TabIndex = 26;
            this.label54.Text = "Senha:";
            // 
            // gbCadastroJuridico
            // 
            this.gbCadastroJuridico.Controls.Add(this.txtProprietario);
            this.gbCadastroJuridico.Controls.Add(this.txtInscEstadual);
            this.gbCadastroJuridico.Controls.Add(this.txtRamo);
            this.gbCadastroJuridico.Controls.Add(this.label49);
            this.gbCadastroJuridico.Controls.Add(this.label50);
            this.gbCadastroJuridico.Controls.Add(this.label51);
            this.gbCadastroJuridico.Controls.Add(this.txtRazaoSocial);
            this.gbCadastroJuridico.Controls.Add(this.label52);
            this.gbCadastroJuridico.Controls.Add(this.txtCnpj);
            this.gbCadastroJuridico.Controls.Add(this.label53);
            this.gbCadastroJuridico.Location = new System.Drawing.Point(281, 41);
            this.gbCadastroJuridico.Name = "gbCadastroJuridico";
            this.gbCadastroJuridico.Size = new System.Drawing.Size(260, 156);
            this.gbCadastroJuridico.TabIndex = 48;
            this.gbCadastroJuridico.TabStop = false;
            this.gbCadastroJuridico.Text = "Pessoa Jurídica";
            // 
            // txtProprietario
            // 
            this.txtProprietario.Location = new System.Drawing.Point(109, 97);
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.Size = new System.Drawing.Size(145, 20);
            this.txtProprietario.TabIndex = 16;
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(109, 71);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(145, 20);
            this.txtInscEstadual.TabIndex = 15;
            // 
            // txtRamo
            // 
            this.txtRamo.Location = new System.Drawing.Point(109, 123);
            this.txtRamo.Name = "txtRamo";
            this.txtRamo.Size = new System.Drawing.Size(145, 20);
            this.txtRamo.TabIndex = 17;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(6, 126);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(38, 13);
            this.label49.TabIndex = 11;
            this.label49.Text = "Ramo:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(6, 104);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(63, 13);
            this.label50.TabIndex = 9;
            this.label50.Text = "Proprietário:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 78);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(97, 13);
            this.label51.TabIndex = 7;
            this.label51.Text = "Inscrição Estadual:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(109, 19);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(145, 20);
            this.txtRazaoSocial.TabIndex = 13;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 22);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(73, 13);
            this.label52.TabIndex = 5;
            this.label52.Text = "Razão Social:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(109, 45);
            this.txtCnpj.Mask = "000.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(145, 20);
            this.txtCnpj.TabIndex = 14;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 52);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(37, 13);
            this.label53.TabIndex = 3;
            this.label53.Text = "CNPJ:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(387, 208);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(36, 17);
            this.lbData.TabIndex = 47;
            this.lbData.Text = "data";
            // 
            // btnParente
            // 
            this.btnParente.Location = new System.Drawing.Point(87, 10);
            this.btnParente.Name = "btnParente";
            this.btnParente.Size = new System.Drawing.Size(113, 23);
            this.btnParente.TabIndex = 34;
            this.btnParente.Text = "Adicionar Parente";
            this.btnParente.UseVisualStyleBackColor = true;
            this.btnParente.Click += new System.EventHandler(this.btnParente_Click);
            // 
            // btnAmizade
            // 
            this.btnAmizade.Location = new System.Drawing.Point(206, 10);
            this.btnAmizade.Name = "btnAmizade";
            this.btnAmizade.Size = new System.Drawing.Size(101, 23);
            this.btnAmizade.TabIndex = 35;
            this.btnAmizade.Text = "Adicionar Amigo";
            this.btnAmizade.UseVisualStyleBackColor = true;
            this.btnAmizade.Click += new System.EventHandler(this.btnAmizade_Click);
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtTipoEndereco);
            this.gbEndereco.Controls.Add(this.txtCep);
            this.gbEndereco.Controls.Add(this.label39);
            this.gbEndereco.Controls.Add(this.txtPais);
            this.gbEndereco.Controls.Add(this.label38);
            this.gbEndereco.Controls.Add(this.txtEndereco);
            this.gbEndereco.Controls.Add(this.label32);
            this.gbEndereco.Controls.Add(this.txtUf);
            this.gbEndereco.Controls.Add(this.label31);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.label30);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.label23);
            this.gbEndereco.Controls.Add(this.txtNum);
            this.gbEndereco.Controls.Add(this.label22);
            this.gbEndereco.Controls.Add(this.txtLogradouro);
            this.gbEndereco.Controls.Add(this.label21);
            this.gbEndereco.Controls.Add(this.label20);
            this.gbEndereco.Location = new System.Drawing.Point(284, 234);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(522, 99);
            this.gbEndereco.TabIndex = 44;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // txtTipoEndereco
            // 
            this.txtTipoEndereco.Location = new System.Drawing.Point(43, 18);
            this.txtTipoEndereco.Name = "txtTipoEndereco";
            this.txtTipoEndereco.Size = new System.Drawing.Size(119, 20);
            this.txtTipoEndereco.TabIndex = 24;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(446, 18);
            this.txtCep.Mask = "00.000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(64, 20);
            this.txtCep.TabIndex = 27;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(409, 22);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 40;
            this.label39.Text = "CEP:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(402, 72);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(108, 20);
            this.txtPais.TabIndex = 32;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(364, 75);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(32, 13);
            this.label38.TabIndex = 38;
            this.label38.Text = "País:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(68, 46);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(305, 20);
            this.txtEndereco.TabIndex = 28;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(56, 13);
            this.label32.TabIndex = 36;
            this.label32.Text = "Endereço:";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(225, 72);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(116, 20);
            this.txtUf.TabIndex = 31;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(195, 76);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(24, 13);
            this.label31.TabIndex = 34;
            this.label31.Text = "UF:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(55, 73);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(119, 20);
            this.txtCidade.TabIndex = 30;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 76);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(421, 46);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(89, 20);
            this.txtBairro.TabIndex = 29;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(382, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 13);
            this.label23.TabIndex = 30;
            this.label23.Text = "Bairro:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(352, 18);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(44, 20);
            this.txtNum.TabIndex = 26;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(324, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "N°:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(246, 18);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(61, 20);
            this.txtLogradouro.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(176, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Logradouro:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Tipo:";
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.label6);
            this.gbContato.Controls.Add(this.txtOutro);
            this.gbContato.Controls.Add(this.label5);
            this.gbContato.Controls.Add(this.txtCelular);
            this.gbContato.Controls.Add(this.label4);
            this.gbContato.Controls.Add(this.txtFax);
            this.gbContato.Controls.Add(this.label3);
            this.gbContato.Controls.Add(this.txtRecado);
            this.gbContato.Controls.Add(this.label2);
            this.gbContato.Controls.Add(this.txtComercial);
            this.gbContato.Controls.Add(this.lbResidencial);
            this.gbContato.Controls.Add(this.txtResidencial);
            this.gbContato.Location = new System.Drawing.Point(547, 41);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(259, 178);
            this.gbContato.TabIndex = 43;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Outro:";
            // 
            // txtOutro
            // 
            this.txtOutro.Location = new System.Drawing.Point(122, 149);
            this.txtOutro.Mask = "(999) 000-0000";
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(131, 20);
            this.txtOutro.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(122, 123);
            this.txtCelular.Mask = "(999) 000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(131, 20);
            this.txtCelular.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone Fax:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(122, 97);
            this.txtFax.Mask = "(999) 000-0000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(131, 20);
            this.txtFax.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone Recado:";
            // 
            // txtRecado
            // 
            this.txtRecado.Location = new System.Drawing.Point(122, 71);
            this.txtRecado.Mask = "(999) 000-0000";
            this.txtRecado.Name = "txtRecado";
            this.txtRecado.Size = new System.Drawing.Size(131, 20);
            this.txtRecado.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone Comercial:";
            // 
            // txtComercial
            // 
            this.txtComercial.Location = new System.Drawing.Point(122, 45);
            this.txtComercial.Mask = "(999) 000-0000";
            this.txtComercial.Name = "txtComercial";
            this.txtComercial.Size = new System.Drawing.Size(131, 20);
            this.txtComercial.TabIndex = 19;
            // 
            // lbResidencial
            // 
            this.lbResidencial.AutoSize = true;
            this.lbResidencial.Location = new System.Drawing.Point(6, 22);
            this.lbResidencial.Name = "lbResidencial";
            this.lbResidencial.Size = new System.Drawing.Size(110, 13);
            this.lbResidencial.TabIndex = 1;
            this.lbResidencial.Text = "Telefone Residencial:";
            // 
            // txtResidencial
            // 
            this.txtResidencial.Location = new System.Drawing.Point(122, 19);
            this.txtResidencial.Mask = "(999) 000-0000";
            this.txtResidencial.Name = "txtResidencial";
            this.txtResidencial.Size = new System.Drawing.Size(131, 20);
            this.txtResidencial.TabIndex = 18;
            // 
            // gbCadastroFisico
            // 
            this.gbCadastroFisico.Controls.Add(this.rbFem);
            this.gbCadastroFisico.Controls.Add(this.rbMasc);
            this.gbCadastroFisico.Controls.Add(this.label13);
            this.gbCadastroFisico.Controls.Add(this.txtProfissao);
            this.gbCadastroFisico.Controls.Add(this.label12);
            this.gbCadastroFisico.Controls.Add(this.txtEmpresa);
            this.gbCadastroFisico.Controls.Add(this.label11);
            this.gbCadastroFisico.Controls.Add(this.txtEmissor);
            this.gbCadastroFisico.Controls.Add(this.label10);
            this.gbCadastroFisico.Controls.Add(this.txtRg);
            this.gbCadastroFisico.Controls.Add(this.label9);
            this.gbCadastroFisico.Controls.Add(this.txtNascimento);
            this.gbCadastroFisico.Controls.Add(this.label8);
            this.gbCadastroFisico.Controls.Add(this.txtNome);
            this.gbCadastroFisico.Controls.Add(this.label7);
            this.gbCadastroFisico.Controls.Add(this.txtCpf);
            this.gbCadastroFisico.Controls.Add(this.lbCPF);
            this.gbCadastroFisico.Location = new System.Drawing.Point(15, 41);
            this.gbCadastroFisico.Name = "gbCadastroFisico";
            this.gbCadastroFisico.Size = new System.Drawing.Size(260, 229);
            this.gbCadastroFisico.TabIndex = 42;
            this.gbCadastroFisico.TabStop = false;
            this.gbCadastroFisico.Text = "Pessoa Física";
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(181, 150);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(67, 17);
            this.rbFem.TabIndex = 9;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(90, 150);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 8;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Sexo:";
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(90, 201);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(164, 20);
            this.txtProfissao.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Profissão:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(90, 175);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(164, 20);
            this.txtEmpresa.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Empresa:";
            // 
            // txtEmissor
            // 
            this.txtEmissor.Location = new System.Drawing.Point(90, 123);
            this.txtEmissor.Name = "txtEmissor";
            this.txtEmissor.Size = new System.Drawing.Size(164, 20);
            this.txtEmissor.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Órgão Emissor:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(90, 97);
            this.txtRg.Mask = "00 000.000-00";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(164, 20);
            this.txtRg.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "RG:";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(90, 71);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(164, 20);
            this.txtNascimento.TabIndex = 5;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(90, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nome:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(90, 45);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(164, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(6, 52);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 13);
            this.lbCPF.TabIndex = 3;
            this.lbCPF.Text = "CPF:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAmizade);
            this.groupBox1.Controls.Add(this.btnParente);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Location = new System.Drawing.Point(12, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 37);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(313, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(6, 10);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 33;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // formInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSenha);
            this.Controls.Add(this.gbCadastroJuridico);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbContato);
            this.Controls.Add(this.gbCadastroFisico);
            this.Controls.Add(this.rbPessoaJuridica);
            this.Controls.Add(this.rbPessoaFisica);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formInsert";
            this.Text = "Inclusão";
            this.gbSenha.ResumeLayout(false);
            this.gbSenha.PerformLayout();
            this.gbCadastroJuridico.ResumeLayout(false);
            this.gbCadastroJuridico.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.gbCadastroFisico.ResumeLayout(false);
            this.gbCadastroFisico.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.GroupBox gbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.GroupBox gbCadastroJuridico;
        private System.Windows.Forms.TextBox txtProprietario;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.TextBox txtRamo;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnParente;
        private System.Windows.Forms.Button btnAmizade;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtOutro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtRecado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtComercial;
        private System.Windows.Forms.Label lbResidencial;
        private System.Windows.Forms.MaskedTextBox txtResidencial;
        private System.Windows.Forms.GroupBox gbCadastroFisico;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmissor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTipoEndereco;
    }
}