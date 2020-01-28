namespace OTCE
{
    partial class AgregarCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.txtNameCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(580, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 57);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(215, 161);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(253, 22);
            this.txtDir.TabIndex = 12;
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(215, 102);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(253, 22);
            this.txtTelf.TabIndex = 11;
            // 
            // txtNameCli
            // 
            this.txtNameCli.Location = new System.Drawing.Point(215, 45);
            this.txtNameCli.Name = "txtNameCli";
            this.txtNameCli.Size = new System.Drawing.Size(253, 22);
            this.txtNameCli.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(215, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Correo";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(215, 296);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(253, 22);
            this.txtCI.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cédula";
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 412);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtTelf);
            this.Controls.Add(this.txtNameCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.TextBox txtNameCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label label5;
    }
}