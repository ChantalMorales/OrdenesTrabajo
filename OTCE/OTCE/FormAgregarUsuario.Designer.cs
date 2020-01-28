namespace OTCE
{
    partial class FormAgregarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(221, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(221, 120);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(253, 22);
            this.txtPasswd.TabIndex = 4;
            this.txtPasswd.TextChanged += new System.EventHandler(this.txtPasswd_TextChanged);
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(221, 179);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(253, 22);
            this.txtRol.TabIndex = 5;
            this.txtRol.TextChanged += new System.EventHandler(this.txtRol_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(580, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 61);
            this.button1.TabIndex = 6;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(751, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarUsuario";
            this.Text = "FormAgregarUsuario";
            this.Load += new System.EventHandler(this.FormAgregarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Button button1;
    }
}