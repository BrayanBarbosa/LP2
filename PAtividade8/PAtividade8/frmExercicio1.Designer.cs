
namespace PAtividade8
{
    partial class frmExercicio1
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
            this.btnInverter1 = new System.Windows.Forms.Button();
            this.btnInverter2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInverter1
            // 
            this.btnInverter1.Location = new System.Drawing.Point(189, 149);
            this.btnInverter1.Name = "btnInverter1";
            this.btnInverter1.Size = new System.Drawing.Size(128, 66);
            this.btnInverter1.TabIndex = 0;
            this.btnInverter1.Text = "Inverter números";
            this.btnInverter1.UseVisualStyleBackColor = true;
            this.btnInverter1.Click += new System.EventHandler(this.btnInverter1_Click);
            // 
            // btnInverter2
            // 
            this.btnInverter2.Location = new System.Drawing.Point(448, 149);
            this.btnInverter2.Name = "btnInverter2";
            this.btnInverter2.Size = new System.Drawing.Size(128, 66);
            this.btnInverter2.TabIndex = 1;
            this.btnInverter2.Text = "Exibir saída";
            this.btnInverter2.UseVisualStyleBackColor = true;
            this.btnInverter2.Click += new System.EventHandler(this.btnInverter2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inverter lista de números";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInverter2);
            this.Controls.Add(this.btnInverter1);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInverter1;
        private System.Windows.Forms.Button btnInverter2;
        private System.Windows.Forms.Label label1;
    }
}