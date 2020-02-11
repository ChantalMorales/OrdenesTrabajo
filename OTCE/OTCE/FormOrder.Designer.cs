namespace OTCE
{
    partial class FormOrder
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIDorder = new System.Windows.Forms.TextBox();
            this.txtObinicial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObFinal = new System.Windows.Forms.TextBox();
            this.txtDtEntry = new System.Windows.Forms.TextBox();
            this.txtDtOut = new System.Windows.Forms.TextBox();
            this.cmbTech = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbEquip = new System.Windows.Forms.ComboBox();
            this.dsOTCE1 = new OTCE.dsOTCE();
            this.dsOTCE2 = new OTCE.dsOTCE();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Orden:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(414, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Técnico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observación inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(510, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIDorder
            // 
            this.txtIDorder.Location = new System.Drawing.Point(144, 24);
            this.txtIDorder.Name = "txtIDorder";
            this.txtIDorder.Size = new System.Drawing.Size(89, 20);
            this.txtIDorder.TabIndex = 10;
            // 
            // txtObinicial
            // 
            this.txtObinicial.Location = new System.Drawing.Point(47, 274);
            this.txtObinicial.Name = "txtObinicial";
            this.txtObinicial.Size = new System.Drawing.Size(673, 20);
            this.txtObinicial.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Diagnóstico:";
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Location = new System.Drawing.Point(47, 213);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(673, 20);
            this.txtDiagnostic.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Observación final:";
            // 
            // txtObFinal
            // 
            this.txtObFinal.Location = new System.Drawing.Point(47, 333);
            this.txtObFinal.Name = "txtObFinal";
            this.txtObFinal.Size = new System.Drawing.Size(673, 20);
            this.txtObFinal.TabIndex = 22;
            // 
            // txtDtEntry
            // 
            this.txtDtEntry.Location = new System.Drawing.Point(213, 54);
            this.txtDtEntry.Name = "txtDtEntry";
            this.txtDtEntry.Size = new System.Drawing.Size(151, 20);
            this.txtDtEntry.TabIndex = 26;
            this.txtDtEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDtOut
            // 
            this.txtDtOut.Location = new System.Drawing.Point(569, 54);
            this.txtDtOut.Name = "txtDtOut";
            this.txtDtOut.Size = new System.Drawing.Size(151, 20);
            this.txtDtOut.TabIndex = 27;
            // 
            // cmbTech
            // 
            this.cmbTech.FormattingEnabled = true;
            this.cmbTech.Location = new System.Drawing.Point(134, 83);
            this.cmbTech.Name = "cmbTech";
            this.cmbTech.Size = new System.Drawing.Size(338, 21);
            this.cmbTech.TabIndex = 31;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(122, 119);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(350, 21);
            this.cmbClient.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(490, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(586, 84);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(134, 21);
            this.cmbPrioridad.TabIndex = 34;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(569, 118);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(151, 21);
            this.cmbEstado.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "Equipo:";
            // 
            // cmbEquip
            // 
            this.cmbEquip.FormattingEnabled = true;
            this.cmbEquip.Location = new System.Drawing.Point(125, 154);
            this.cmbEquip.Name = "cmbEquip";
            this.cmbEquip.Size = new System.Drawing.Size(350, 21);
            this.cmbEquip.TabIndex = 37;
            // 
            // dsOTCE1
            // 
            this.dsOTCE1.DataSetName = "dsOTCE";
            this.dsOTCE1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsOTCE2
            // 
            this.dsOTCE2.DataSetName = "dsOTCE";
            this.dsOTCE2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(616, 375);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(104, 34);
            this.btnReturn.TabIndex = 38;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 421);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cmbEquip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmbTech);
            this.Controls.Add(this.txtDtOut);
            this.Controls.Add(this.txtDtEntry);
            this.Controls.Add(this.txtObFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtObinicial);
            this.Controls.Add(this.txtIDorder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtIDorder;
        private System.Windows.Forms.TextBox txtObinicial;
        private dsOTCE dsOTCE1;
        private dsOTCE dsOTCE2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObFinal;
        private System.Windows.Forms.TextBox txtDtEntry;
        private System.Windows.Forms.TextBox txtDtOut;
        private System.Windows.Forms.ComboBox cmbTech;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEquip;
        private System.Windows.Forms.Button btnReturn;
    }
}