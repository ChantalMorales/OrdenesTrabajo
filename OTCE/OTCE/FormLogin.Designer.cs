namespace OTCE
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtpasswd = new System.Windows.Forms.TextBox();
            this.btiniciarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtpasswd
            // 
            this.txtpasswd.Location = new System.Drawing.Point(241, 106);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.PasswordChar = '*';
            this.txtpasswd.Size = new System.Drawing.Size(205, 22);
            this.txtpasswd.TabIndex = 3;
            // 
            // btiniciarsesion
            // 
            this.btiniciarsesion.BackColor = System.Drawing.Color.PaleGreen;
            this.btiniciarsesion.Location = new System.Drawing.Point(215, 184);
            this.btiniciarsesion.Name = "btiniciarsesion";
            this.btiniciarsesion.Size = new System.Drawing.Size(131, 27);
            this.btiniciarsesion.TabIndex = 4;
            this.btiniciarsesion.Text = "Iniciar Sesión";
            this.btiniciarsesion.UseVisualStyleBackColor = false;
            this.btiniciarsesion.Click += new System.EventHandler(this.btiniciarsesion_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 251);
            this.Controls.Add(this.btiniciarsesion);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Inicio de Sesión ";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtpasswd;
        private System.Windows.Forms.Button btiniciarsesion;
    }
}

