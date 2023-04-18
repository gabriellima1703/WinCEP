namespace WinCEP
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Font = new System.Drawing.Font("Swis721 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(557, 68);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(214, 70);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "BUSCAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(182, 93);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(246, 23);
            this.txtCEP.TabIndex = 1;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCEP.Location = new System.Drawing.Point(105, 93);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(52, 22);
            this.lblCEP.TabIndex = 2;
            this.lblCEP.Text = "CEP";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(182, 223);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(589, 23);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(182, 283);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.ReadOnly = true;
            this.txtCidade.Size = new System.Drawing.Size(589, 23);
            this.txtCidade.TabIndex = 4;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEndereco.Location = new System.Drawing.Point(48, 224);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(109, 22);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Font = new System.Drawing.Font("Swis721 Blk BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocalidade.Location = new System.Drawing.Point(24, 284);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(133, 22);
            this.lblLocalidade.TabIndex = 6;
            this.lblLocalidade.Text = "Localização";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(815, 399);
            this.Controls.Add(this.lblLocalidade);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnConsultar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConsultar;
        private MaskedTextBox txtCEP;
        private Label lblCEP;
        private TextBox txtEndereco;
        private TextBox txtCidade;
        private Label lblEndereco;
        private Label lblLocalidade;
    }
}