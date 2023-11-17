namespace CursoWindowsForms
{
    partial class Frm_ValidaCpf
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
            this.mask_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Validar = new System.Windows.Forms.Button();
            this.lbl_TituloValidadorCPF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mask_Cpf
            // 
            this.mask_Cpf.Location = new System.Drawing.Point(12, 25);
            this.mask_Cpf.Mask = "000,000,000-00";
            this.mask_Cpf.Name = "mask_Cpf";
            this.mask_Cpf.Size = new System.Drawing.Size(218, 20);
            this.mask_Cpf.TabIndex = 0;
            this.mask_Cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mask_Cpf_MaskInputRejected);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(245, 25);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Limpar";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Validar
            // 
            this.btn_Validar.Location = new System.Drawing.Point(245, 54);
            this.btn_Validar.Name = "btn_Validar";
            this.btn_Validar.Size = new System.Drawing.Size(111, 23);
            this.btn_Validar.TabIndex = 2;
            this.btn_Validar.Text = "Validar";
            this.btn_Validar.UseVisualStyleBackColor = true;
            this.btn_Validar.Click += new System.EventHandler(this.btn_Validar_Click);
            // 
            // lbl_TituloValidadorCPF
            // 
            this.lbl_TituloValidadorCPF.AutoSize = true;
            this.lbl_TituloValidadorCPF.Location = new System.Drawing.Point(12, 9);
            this.lbl_TituloValidadorCPF.Name = "lbl_TituloValidadorCPF";
            this.lbl_TituloValidadorCPF.Size = new System.Drawing.Size(128, 13);
            this.lbl_TituloValidadorCPF.TabIndex = 3;
            this.lbl_TituloValidadorCPF.Text = "Sistema validador de CPF";
            this.lbl_TituloValidadorCPF.Click += new System.EventHandler(this.lbl_TituloValidadorCPF_Click);
            // 
            // Frm_ValidaCpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 86);
            this.Controls.Add(this.lbl_TituloValidadorCPF);
            this.Controls.Add(this.btn_Validar);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.mask_Cpf);
            this.MaximumSize = new System.Drawing.Size(380, 125);
            this.MinimumSize = new System.Drawing.Size(380, 125);
            this.Name = "Frm_ValidaCpf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validar CPF";
            this.Load += new System.EventHandler(this.Frm_ValidaCpf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mask_Cpf;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Validar;
        private System.Windows.Forms.Label lbl_TituloValidadorCPF;
    }
}