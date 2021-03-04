
namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextAlt = new System.Windows.Forms.MaskedTextBox();
            this.TextPeso = new System.Windows.Forms.MaskedTextBox();
            this.BCancel = new System.Windows.Forms.Button();
            this.GBSex = new System.Windows.Forms.GroupBox();
            this.RadMasc = new System.Windows.Forms.RadioButton();
            this.RadFem = new System.Windows.Forms.RadioButton();
            this.BLimp = new System.Windows.Forms.Button();
            this.BSair = new System.Windows.Forms.Button();
            this.GBSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // TextAlt
            // 
            this.TextAlt.Location = new System.Drawing.Point(229, 83);
            this.TextAlt.Mask = "0.00 ";
            this.TextAlt.Name = "TextAlt";
            this.TextAlt.Size = new System.Drawing.Size(100, 20);
            this.TextAlt.TabIndex = 3;
            // 
            // TextPeso
            // 
            this.TextPeso.Location = new System.Drawing.Point(229, 139);
            this.TextPeso.Mask = "00.000 ";
            this.TextPeso.Name = "TextPeso";
            this.TextPeso.Size = new System.Drawing.Size(100, 20);
            this.TextPeso.TabIndex = 4;
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(170, 340);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 6;
            this.BCancel.Text = "Calcular";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // GBSex
            // 
            this.GBSex.Controls.Add(this.RadMasc);
            this.GBSex.Controls.Add(this.RadFem);
            this.GBSex.Location = new System.Drawing.Point(490, 68);
            this.GBSex.Name = "GBSex";
            this.GBSex.Size = new System.Drawing.Size(200, 100);
            this.GBSex.TabIndex = 7;
            this.GBSex.TabStop = false;
            this.GBSex.Text = "Sexo";
            // 
            // RadMasc
            // 
            this.RadMasc.AutoSize = true;
            this.RadMasc.Checked = true;
            this.RadMasc.Location = new System.Drawing.Point(21, 59);
            this.RadMasc.Name = "RadMasc";
            this.RadMasc.Size = new System.Drawing.Size(73, 17);
            this.RadMasc.TabIndex = 1;
            this.RadMasc.TabStop = true;
            this.RadMasc.Text = "Masculino";
            this.RadMasc.UseVisualStyleBackColor = true;
            // 
            // RadFem
            // 
            this.RadFem.AutoSize = true;
            this.RadFem.Location = new System.Drawing.Point(21, 20);
            this.RadFem.Name = "RadFem";
            this.RadFem.Size = new System.Drawing.Size(67, 17);
            this.RadFem.TabIndex = 0;
            this.RadFem.Text = "Feminino";
            this.RadFem.UseVisualStyleBackColor = true;
            // 
            // BLimp
            // 
            this.BLimp.Location = new System.Drawing.Point(373, 340);
            this.BLimp.Name = "BLimp";
            this.BLimp.Size = new System.Drawing.Size(75, 23);
            this.BLimp.TabIndex = 8;
            this.BLimp.Text = "Limpar";
            this.BLimp.UseVisualStyleBackColor = true;
            this.BLimp.Click += new System.EventHandler(this.BLimp_Click);
            // 
            // BSair
            // 
            this.BSair.Location = new System.Drawing.Point(475, 340);
            this.BSair.Name = "BSair";
            this.BSair.Size = new System.Drawing.Size(75, 23);
            this.BSair.TabIndex = 9;
            this.BSair.Text = "Sair";
            this.BSair.UseVisualStyleBackColor = true;
            this.BSair.Click += new System.EventHandler(this.BSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSair);
            this.Controls.Add(this.BLimp);
            this.Controls.Add(this.GBSex);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.TextPeso);
            this.Controls.Add(this.TextAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBSex.ResumeLayout(false);
            this.GBSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TextAlt;
        private System.Windows.Forms.MaskedTextBox TextPeso;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.GroupBox GBSex;
        private System.Windows.Forms.RadioButton RadMasc;
        private System.Windows.Forms.RadioButton RadFem;
        private System.Windows.Forms.Button BLimp;
        private System.Windows.Forms.Button BSair;
    }
}

