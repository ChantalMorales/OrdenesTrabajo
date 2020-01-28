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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbcontrasena = new System.Windows.Forms.TextBox();
            this.btiniciarsesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña: ";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(266, 51);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(205, 22);
            this.tbnombre.TabIndex = 2;
            // 
            // tbcontrasena
            // 
            this.tbcontrasena.Location = new System.Drawing.Point(266, 106);
            this.tbcontrasena.Name = "tbcontrasena";
            this.tbcontrasena.PasswordChar = '*';
            this.tbcontrasena.Size = new System.Drawing.Size(205, 22);
            this.tbcontrasena.TabIndex = 3;
            // 
            // btiniciarsesion
            // 
            this.btiniciarsesion.Location = new System.Drawing.Point(240, 184);
            this.btiniciarsesion.Name = "btiniciarsesion";
            this.btiniciarsesion.Size = new System.Drawing.Size(131, 27);
            this.btiniciarsesion.TabIndex = 4;
            this.btiniciarsesion.Text = "Iniciar Sesión";
            this.btiniciarsesion.UseVisualStyleBackColor = true;
            this.btiniciarsesion.Click += new System.EventHandler(this.btiniciarsesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 254);
            this.Controls.Add(this.btiniciarsesion);
            this.Controls.Add(this.tbcontrasena);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inicio de Sesión ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbcontrasena;
        private System.Windows.Forms.Button btiniciarsesion;
    }
}

