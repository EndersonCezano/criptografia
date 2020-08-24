namespace Criptografias
{
    partial class frmCripto
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
            this.txtNormal = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblCripto = new System.Windows.Forms.Label();
            this.txtCriptografado = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnDecriptar = new System.Windows.Forms.Button();
            this.rbRijndael = new System.Windows.Forms.RadioButton();
            this.rbRC2 = new System.Windows.Forms.RadioButton();
            this.rbDES = new System.Windows.Forms.RadioButton();
            this.rbTripleDES = new System.Windows.Forms.RadioButton();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNormal
            // 
            this.txtNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNormal.Location = new System.Drawing.Point(12, 40);
            this.txtNormal.Multiline = true;
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(281, 308);
            this.txtNormal.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(9, 24);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(68, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto normal";
            // 
            // lblCripto
            // 
            this.lblCripto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCripto.AutoSize = true;
            this.lblCripto.Location = new System.Drawing.Point(309, 84);
            this.lblCripto.Name = "lblCripto";
            this.lblCripto.Size = new System.Drawing.Size(99, 13);
            this.lblCripto.TabIndex = 3;
            this.lblCripto.Text = "Texto criptografado";
            // 
            // txtCriptografado
            // 
            this.txtCriptografado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCriptografado.Location = new System.Drawing.Point(312, 100);
            this.txtCriptografado.Multiline = true;
            this.txtCriptografado.Name = "txtCriptografado";
            this.txtCriptografado.Size = new System.Drawing.Size(281, 249);
            this.txtCriptografado.TabIndex = 2;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriptografar.Location = new System.Drawing.Point(389, 355);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(99, 23);
            this.btnCriptografar.TabIndex = 4;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnDecriptar
            // 
            this.btnDecriptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecriptar.Location = new System.Drawing.Point(494, 355);
            this.btnDecriptar.Name = "btnDecriptar";
            this.btnDecriptar.Size = new System.Drawing.Size(99, 23);
            this.btnDecriptar.TabIndex = 5;
            this.btnDecriptar.Text = "Descriptografar";
            this.btnDecriptar.UseVisualStyleBackColor = true;
            this.btnDecriptar.Click += new System.EventHandler(this.btnDecriptar_Click);
            // 
            // rbRijndael
            // 
            this.rbRijndael.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbRijndael.AutoSize = true;
            this.rbRijndael.Checked = true;
            this.rbRijndael.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbRijndael.Location = new System.Drawing.Point(12, 358);
            this.rbRijndael.Name = "rbRijndael";
            this.rbRijndael.Size = new System.Drawing.Size(62, 17);
            this.rbRijndael.TabIndex = 6;
            this.rbRijndael.TabStop = true;
            this.rbRijndael.Tag = "0";
            this.rbRijndael.Text = "Rijndael";
            this.rbRijndael.UseVisualStyleBackColor = true;
            this.rbRijndael.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // rbRC2
            // 
            this.rbRC2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbRC2.AutoSize = true;
            this.rbRC2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbRC2.Location = new System.Drawing.Point(80, 358);
            this.rbRC2.Name = "rbRC2";
            this.rbRC2.Size = new System.Drawing.Size(45, 17);
            this.rbRC2.TabIndex = 7;
            this.rbRC2.Tag = "1";
            this.rbRC2.Text = "RC2";
            this.rbRC2.UseVisualStyleBackColor = true;
            this.rbRC2.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // rbDES
            // 
            this.rbDES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbDES.AutoSize = true;
            this.rbDES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbDES.Location = new System.Drawing.Point(144, 358);
            this.rbDES.Name = "rbDES";
            this.rbDES.Size = new System.Drawing.Size(46, 17);
            this.rbDES.TabIndex = 8;
            this.rbDES.Tag = "2";
            this.rbDES.Text = "DES";
            this.rbDES.UseVisualStyleBackColor = true;
            this.rbDES.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // rbTripleDES
            // 
            this.rbTripleDES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbTripleDES.AutoSize = true;
            this.rbTripleDES.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTripleDES.Location = new System.Drawing.Point(207, 358);
            this.rbTripleDES.Name = "rbTripleDES";
            this.rbTripleDES.Size = new System.Drawing.Size(72, 17);
            this.rbTripleDES.TabIndex = 9;
            this.rbTripleDES.Tag = "3";
            this.rbTripleDES.Text = "TripleDES";
            this.rbTripleDES.UseVisualStyleBackColor = true;
            this.rbTripleDES.CheckedChanged += new System.EventHandler(this.checkedChanged);
            // 
            // lblKey
            // 
            this.lblKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(309, 24);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(238, 13);
            this.lblKey.TabIndex = 11;
            this.lblKey.Text = "Chave simétrica (mesma usada na ida e na volta)";
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Location = new System.Drawing.Point(312, 43);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(281, 20);
            this.txtKey.TabIndex = 10;
            this.txtKey.Text = "uma frase qualquer";
            // 
            // frmCripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 389);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.rbTripleDES);
            this.Controls.Add(this.rbDES);
            this.Controls.Add(this.rbRC2);
            this.Controls.Add(this.rbRijndael);
            this.Controls.Add(this.btnDecriptar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.lblCripto);
            this.Controls.Add(this.txtCriptografado);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtNormal);
            this.MinimumSize = new System.Drawing.Size(515, 222);
            this.Name = "frmCripto";
            this.Text = "Criptografias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNormal;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblCripto;
        private System.Windows.Forms.TextBox txtCriptografado;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDecriptar;
        private System.Windows.Forms.RadioButton rbRijndael;
        private System.Windows.Forms.RadioButton rbRC2;
        private System.Windows.Forms.RadioButton rbDES;
        private System.Windows.Forms.RadioButton rbTripleDES;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
    }
}

