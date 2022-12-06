
namespace MercadoTech2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txSalarioCadastrar = new System.Windows.Forms.TextBox();
            this.txNomeCadastrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btCadastrar);
            this.panel1.Controls.Add(this.txSalarioCadastrar);
            this.panel1.Controls.Add(this.txNomeCadastrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 95);
            this.panel1.TabIndex = 0;
            // 
            // btCadastrar
            // 
            this.btCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.Location = new System.Drawing.Point(66, 46);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(66, 23);
            this.btCadastrar.TabIndex = 3;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txSalarioCadastrar
            // 
            this.txSalarioCadastrar.Location = new System.Drawing.Point(3, 47);
            this.txSalarioCadastrar.Name = "txSalarioCadastrar";
            this.txSalarioCadastrar.Size = new System.Drawing.Size(57, 23);
            this.txSalarioCadastrar.TabIndex = 2;
            this.txSalarioCadastrar.Text = "Salário";
            // 
            // txNomeCadastrar
            // 
            this.txNomeCadastrar.Location = new System.Drawing.Point(3, 18);
            this.txNomeCadastrar.Name = "txNomeCadastrar";
            this.txNomeCadastrar.Size = new System.Drawing.Size(100, 23);
            this.txNomeCadastrar.TabIndex = 1;
            this.txNomeCadastrar.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastrar Funcionário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txSalarioCadastrar;
        private System.Windows.Forms.TextBox txNomeCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
    }
}

