namespace CursoWindowsForms
{
    partial class Frm_Mascara
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
            this.mask_Conteudo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Conteudo = new System.Windows.Forms.Label();
            this.lbl_MascaraAtiva = new System.Windows.Forms.Label();
            this.btn_Hora = new System.Windows.Forms.Button();
            this.btn_CEP = new System.Windows.Forms.Button();
            this.botao_Moeda = new System.Windows.Forms.Button();
            this.btn_Telefone = new System.Windows.Forms.Button();
            this.btn_Senha = new System.Windows.Forms.Button();
            this.btn_Data = new System.Windows.Forms.Button();
            this.btn_VerConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mask_Conteudo
            // 
            this.mask_Conteudo.Location = new System.Drawing.Point(23, 31);
            this.mask_Conteudo.Name = "mask_Conteudo";
            this.mask_Conteudo.Size = new System.Drawing.Size(258, 20);
            this.mask_Conteudo.TabIndex = 0;
            this.mask_Conteudo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lbl_Conteudo
            // 
            this.lbl_Conteudo.AutoSize = true;
            this.lbl_Conteudo.Location = new System.Drawing.Point(23, 246);
            this.lbl_Conteudo.Name = "lbl_Conteudo";
            this.lbl_Conteudo.Size = new System.Drawing.Size(46, 13);
            this.lbl_Conteudo.TabIndex = 1;
            this.lbl_Conteudo.Text = "<Blank>";
            // 
            // lbl_MascaraAtiva
            // 
            this.lbl_MascaraAtiva.AutoSize = true;
            this.lbl_MascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.lbl_MascaraAtiva.Name = "lbl_MascaraAtiva";
            this.lbl_MascaraAtiva.Size = new System.Drawing.Size(46, 13);
            this.lbl_MascaraAtiva.TabIndex = 2;
            this.lbl_MascaraAtiva.Text = "<Blank>";
            // 
            // btn_Hora
            // 
            this.btn_Hora.Location = new System.Drawing.Point(23, 110);
            this.btn_Hora.Name = "btn_Hora";
            this.btn_Hora.Size = new System.Drawing.Size(82, 37);
            this.btn_Hora.TabIndex = 3;
            this.btn_Hora.Text = "Hora";
            this.btn_Hora.UseVisualStyleBackColor = true;
            this.btn_Hora.Click += new System.EventHandler(this.btn_Hora_Click);
            // 
            // btn_CEP
            // 
            this.btn_CEP.Location = new System.Drawing.Point(111, 110);
            this.btn_CEP.Name = "btn_CEP";
            this.btn_CEP.Size = new System.Drawing.Size(82, 37);
            this.btn_CEP.TabIndex = 4;
            this.btn_CEP.Text = "CEP";
            this.btn_CEP.UseVisualStyleBackColor = true;
            this.btn_CEP.Click += new System.EventHandler(this.btn_CEP_Click);
            // 
            // botao_Moeda
            // 
            this.botao_Moeda.Location = new System.Drawing.Point(199, 110);
            this.botao_Moeda.Name = "botao_Moeda";
            this.botao_Moeda.Size = new System.Drawing.Size(82, 37);
            this.botao_Moeda.TabIndex = 5;
            this.botao_Moeda.Text = "Moeda";
            this.botao_Moeda.UseVisualStyleBackColor = true;
            this.botao_Moeda.Click += new System.EventHandler(this.btn_Moeda_Click);
            // 
            // btn_Telefone
            // 
            this.btn_Telefone.Location = new System.Drawing.Point(199, 153);
            this.btn_Telefone.Name = "btn_Telefone";
            this.btn_Telefone.Size = new System.Drawing.Size(82, 37);
            this.btn_Telefone.TabIndex = 8;
            this.btn_Telefone.Text = "Telefone";
            this.btn_Telefone.UseVisualStyleBackColor = true;
            this.btn_Telefone.Click += new System.EventHandler(this.btn_Telefone_Click);
            // 
            // btn_Senha
            // 
            this.btn_Senha.Location = new System.Drawing.Point(111, 153);
            this.btn_Senha.Name = "btn_Senha";
            this.btn_Senha.Size = new System.Drawing.Size(82, 37);
            this.btn_Senha.TabIndex = 7;
            this.btn_Senha.Text = "Senha";
            this.btn_Senha.UseVisualStyleBackColor = true;
            this.btn_Senha.Click += new System.EventHandler(this.btn_Senha_Click);
            // 
            // btn_Data
            // 
            this.btn_Data.Location = new System.Drawing.Point(23, 153);
            this.btn_Data.Name = "btn_Data";
            this.btn_Data.Size = new System.Drawing.Size(82, 37);
            this.btn_Data.TabIndex = 6;
            this.btn_Data.Text = "Data";
            this.btn_Data.UseVisualStyleBackColor = true;
            this.btn_Data.Click += new System.EventHandler(this.btn_Data_Click);
            // 
            // btn_VerConteudo
            // 
            this.btn_VerConteudo.Location = new System.Drawing.Point(23, 196);
            this.btn_VerConteudo.Name = "btn_VerConteudo";
            this.btn_VerConteudo.Size = new System.Drawing.Size(258, 37);
            this.btn_VerConteudo.TabIndex = 9;
            this.btn_VerConteudo.Text = "Ver Conteudo";
            this.btn_VerConteudo.UseVisualStyleBackColor = true;
            this.btn_VerConteudo.Click += new System.EventHandler(this.btn_VerConteudo_Click);
            // 
            // Frm_Mascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
            this.Controls.Add(this.btn_VerConteudo);
            this.Controls.Add(this.btn_Telefone);
            this.Controls.Add(this.btn_Senha);
            this.Controls.Add(this.btn_Data);
            this.Controls.Add(this.botao_Moeda);
            this.Controls.Add(this.btn_CEP);
            this.Controls.Add(this.btn_Hora);
            this.Controls.Add(this.lbl_MascaraAtiva);
            this.Controls.Add(this.lbl_Conteudo);
            this.Controls.Add(this.mask_Conteudo);
            this.Name = "Frm_Mascara";
            this.Text = "Exemplos de Máscara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mask_Conteudo;
        private System.Windows.Forms.Label lbl_Conteudo;
        private System.Windows.Forms.Label lbl_MascaraAtiva;
        private System.Windows.Forms.Button btn_Hora;
        private System.Windows.Forms.Button btn_CEP;
        private System.Windows.Forms.Button botao_Moeda;
        private System.Windows.Forms.Button btn_Telefone;
        private System.Windows.Forms.Button btn_Senha;
        private System.Windows.Forms.Button btn_Data;
        private System.Windows.Forms.Button btn_VerConteudo;
    }
}