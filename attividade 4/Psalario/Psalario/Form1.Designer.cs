
namespace Psalario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.maskedTextsalbrut = new System.Windows.Forms.MaskedTextBox();
            this.lblmensagem = new System.Windows.Forms.Label();
            this.lblinss = new System.Windows.Forms.Label();
            this.lblir = new System.Windows.Forms.Label();
            this.lblfamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lbldescontoinss = new System.Windows.Forms.Label();
            this.lblDescontoIr = new System.Windows.Forms.Label();
            this.txtinss = new System.Windows.Forms.TextBox();
            this.txtir = new System.Windows.Forms.TextBox();
            this.txtsfamilia = new System.Windows.Forms.TextBox();
            this.txtsliquido = new System.Windows.Forms.TextBox();
            this.txtDInss = new System.Windows.Forms.TextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.comboBoxfilhos = new System.Windows.Forms.ComboBox();
            this.comboBoxsexo = new System.Windows.Forms.ComboBox();
            this.comboBoxEC = new System.Windows.Forms.ComboBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblestadocivil = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(50, 253);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(129, 23);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar Descontos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(29, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(29, 73);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(70, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário Bruto ";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(29, 136);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(64, 13);
            this.lblFilhos.TabIndex = 3;
            this.lblFilhos.Text = "N° de Filhos";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(164, 16);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(305, 20);
            this.txtnome.TabIndex = 4;
            // 
            // maskedTextsalbrut
            // 
            this.maskedTextsalbrut.Location = new System.Drawing.Point(164, 73);
            this.maskedTextsalbrut.Mask = "0000.00";
            this.maskedTextsalbrut.Name = "maskedTextsalbrut";
            this.maskedTextsalbrut.Size = new System.Drawing.Size(100, 20);
            this.maskedTextsalbrut.TabIndex = 5;
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Location = new System.Drawing.Point(57, 198);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(35, 13);
            this.lblmensagem.TabIndex = 7;
            this.lblmensagem.Text = "label1";
            this.lblmensagem.Visible = false;
            // 
            // lblinss
            // 
            this.lblinss.AutoSize = true;
            this.lblinss.Location = new System.Drawing.Point(11, 323);
            this.lblinss.Name = "lblinss";
            this.lblinss.Size = new System.Drawing.Size(73, 13);
            this.lblinss.TabIndex = 8;
            this.lblinss.Text = "Aliquota INSS";
            // 
            // lblir
            // 
            this.lblir.AutoSize = true;
            this.lblir.Location = new System.Drawing.Point(29, 362);
            this.lblir.Name = "lblir";
            this.lblir.Size = new System.Drawing.Size(59, 13);
            this.lblir.TabIndex = 9;
            this.lblir.Text = "Aliquota IR";
            // 
            // lblfamilia
            // 
            this.lblfamilia.AutoSize = true;
            this.lblfamilia.Location = new System.Drawing.Point(11, 404);
            this.lblfamilia.Name = "lblfamilia";
            this.lblfamilia.Size = new System.Drawing.Size(74, 13);
            this.lblfamilia.TabIndex = 10;
            this.lblfamilia.Text = "Salário Familia";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(11, 445);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioLiquido.TabIndex = 11;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // lbldescontoinss
            // 
            this.lbldescontoinss.AutoSize = true;
            this.lbldescontoinss.Location = new System.Drawing.Point(337, 319);
            this.lbldescontoinss.Name = "lbldescontoinss";
            this.lbldescontoinss.Size = new System.Drawing.Size(81, 13);
            this.lbldescontoinss.TabIndex = 12;
            this.lbldescontoinss.Text = "Desconto INSS";
            // 
            // lblDescontoIr
            // 
            this.lblDescontoIr.AutoSize = true;
            this.lblDescontoIr.Location = new System.Drawing.Point(351, 365);
            this.lblDescontoIr.Name = "lblDescontoIr";
            this.lblDescontoIr.Size = new System.Drawing.Size(67, 13);
            this.lblDescontoIr.TabIndex = 13;
            this.lblDescontoIr.Text = "Desconto IR";
            // 
            // txtinss
            // 
            this.txtinss.Enabled = false;
            this.txtinss.Location = new System.Drawing.Point(100, 319);
            this.txtinss.Name = "txtinss";
            this.txtinss.Size = new System.Drawing.Size(100, 20);
            this.txtinss.TabIndex = 14;
            // 
            // txtir
            // 
            this.txtir.Enabled = false;
            this.txtir.Location = new System.Drawing.Point(100, 359);
            this.txtir.Name = "txtir";
            this.txtir.Size = new System.Drawing.Size(100, 20);
            this.txtir.TabIndex = 15;
            // 
            // txtsfamilia
            // 
            this.txtsfamilia.Enabled = false;
            this.txtsfamilia.Location = new System.Drawing.Point(100, 401);
            this.txtsfamilia.Name = "txtsfamilia";
            this.txtsfamilia.Size = new System.Drawing.Size(100, 20);
            this.txtsfamilia.TabIndex = 16;
            // 
            // txtsliquido
            // 
            this.txtsliquido.Enabled = false;
            this.txtsliquido.Location = new System.Drawing.Point(100, 442);
            this.txtsliquido.Name = "txtsliquido";
            this.txtsliquido.Size = new System.Drawing.Size(100, 20);
            this.txtsliquido.TabIndex = 17;
            // 
            // txtDInss
            // 
            this.txtDInss.Enabled = false;
            this.txtDInss.Location = new System.Drawing.Point(424, 316);
            this.txtDInss.Name = "txtDInss";
            this.txtDInss.Size = new System.Drawing.Size(100, 20);
            this.txtDInss.TabIndex = 18;
            // 
            // txtdir
            // 
            this.txtdir.Enabled = false;
            this.txtdir.Location = new System.Drawing.Point(424, 362);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(100, 20);
            this.txtdir.TabIndex = 19;
            // 
            // comboBoxfilhos
            // 
            this.comboBoxfilhos.FormattingEnabled = true;
            this.comboBoxfilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxfilhos.Location = new System.Drawing.Point(164, 128);
            this.comboBoxfilhos.Name = "comboBoxfilhos";
            this.comboBoxfilhos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxfilhos.TabIndex = 20;
            // 
            // comboBoxsexo
            // 
            this.comboBoxsexo.FormattingEnabled = true;
            this.comboBoxsexo.Items.AddRange(new object[] {
            "",
            "Feminino",
            "Masculino"});
            this.comboBoxsexo.Location = new System.Drawing.Point(580, 65);
            this.comboBoxsexo.Name = "comboBoxsexo";
            this.comboBoxsexo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxsexo.TabIndex = 21;
            // 
            // comboBoxEC
            // 
            this.comboBoxEC.FormattingEnabled = true;
            this.comboBoxEC.Items.AddRange(new object[] {
            "",
            "Solteiro",
            "Casado"});
            this.comboBoxEC.Location = new System.Drawing.Point(580, 128);
            this.comboBoxEC.Name = "comboBoxEC";
            this.comboBoxEC.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEC.TabIndex = 22;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(524, 72);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 23;
            this.lblsexo.Text = "Sexo";
            // 
            // lblestadocivil
            // 
            this.lblestadocivil.AutoSize = true;
            this.lblestadocivil.Location = new System.Drawing.Point(493, 131);
            this.lblestadocivil.Name = "lblestadocivil";
            this.lblestadocivil.Size = new System.Drawing.Size(62, 13);
            this.lblestadocivil.TabIndex = 24;
            this.lblestadocivil.Text = "Estado Civil";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(556, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 23);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblestadocivil);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.comboBoxEC);
            this.Controls.Add(this.comboBoxsexo);
            this.Controls.Add(this.comboBoxfilhos);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.txtDInss);
            this.Controls.Add(this.txtsliquido);
            this.Controls.Add(this.txtsfamilia);
            this.Controls.Add(this.txtir);
            this.Controls.Add(this.txtinss);
            this.Controls.Add(this.lblDescontoIr);
            this.Controls.Add(this.lbldescontoinss);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblfamilia);
            this.Controls.Add(this.lblir);
            this.Controls.Add(this.lblinss);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.maskedTextsalbrut);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVerificar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.MaskedTextBox maskedTextsalbrut;
        private System.Windows.Forms.Label lblmensagem;
        private System.Windows.Forms.Label lblinss;
        private System.Windows.Forms.Label lblir;
        private System.Windows.Forms.Label lblfamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lbldescontoinss;
        private System.Windows.Forms.Label lblDescontoIr;
        private System.Windows.Forms.TextBox txtinss;
        private System.Windows.Forms.TextBox txtir;
        private System.Windows.Forms.TextBox txtsfamilia;
        private System.Windows.Forms.TextBox txtsliquido;
        private System.Windows.Forms.TextBox txtDInss;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.ComboBox comboBoxfilhos;
        private System.Windows.Forms.ComboBox comboBoxsexo;
        private System.Windows.Forms.ComboBox comboBoxEC;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblestadocivil;
        private System.Windows.Forms.Button btnLimpar;
    }
}

