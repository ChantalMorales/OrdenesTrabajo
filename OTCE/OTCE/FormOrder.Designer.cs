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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIDorder = new System.Windows.Forms.TextBox();
            this.txtObinicial = new System.Windows.Forms.TextBox();
            this.dtEntry = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.dtExit = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtObFinal = new System.Windows.Forms.TextBox();
            this.dsOTCE1 = new OTCE.dsOTCE();
            this.dsOTCE2 = new OTCE.dsOTCE();
            this.txtIDclient = new System.Windows.Forms.NumericUpDown();
            this.txtTech = new System.Windows.Forms.NumericUpDown();
            this.txtStatus = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus)).BeginInit();
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
            this.label3.Location = new System.Drawing.Point(442, 50);
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
            this.label6.Location = new System.Drawing.Point(43, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Observación inicial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(499, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(609, 378);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(726, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
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
            this.txtObinicial.Location = new System.Drawing.Point(47, 243);
            this.txtObinicial.Name = "txtObinicial";
            this.txtObinicial.Size = new System.Drawing.Size(673, 20);
            this.txtObinicial.TabIndex = 16;
            // 
            // dtEntry
            // 
            this.dtEntry.Location = new System.Drawing.Point(213, 55);
            this.dtEntry.Name = "dtEntry";
            this.dtEntry.Size = new System.Drawing.Size(223, 20);
            this.dtEntry.TabIndex = 17;
            this.dtEntry.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Diagnóstico:";
            // 
            // txtDiagnostic
            // 
            this.txtDiagnostic.Location = new System.Drawing.Point(47, 182);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(673, 20);
            this.txtDiagnostic.TabIndex = 19;
            // 
            // dtExit
            // 
            this.dtExit.Location = new System.Drawing.Point(597, 52);
            this.dtExit.Name = "dtExit";
            this.dtExit.Size = new System.Drawing.Size(217, 20);
            this.dtExit.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Observación final:";
            // 
            // txtObFinal
            // 
            this.txtObFinal.Location = new System.Drawing.Point(47, 302);
            this.txtObFinal.Name = "txtObFinal";
            this.txtObFinal.Size = new System.Drawing.Size(673, 20);
            this.txtObFinal.TabIndex = 22;
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
            // txtIDclient
            // 
            this.txtIDclient.Location = new System.Drawing.Point(144, 121);
            this.txtIDclient.Name = "txtIDclient";
            this.txtIDclient.Size = new System.Drawing.Size(73, 20);
            this.txtIDclient.TabIndex = 23;
            // 
            // txtTech
            // 
            this.txtTech.Location = new System.Drawing.Point(144, 85);
            this.txtTech.Name = "txtTech";
            this.txtTech.Size = new System.Drawing.Size(73, 20);
            this.txtTech.TabIndex = 24;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(521, 120);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(73, 20);
            this.txtStatus.TabIndex = 25;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 424);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtTech);
            this.Controls.Add(this.txtIDclient);
            this.Controls.Add(this.txtObFinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtExit);
            this.Controls.Add(this.txtDiagnostic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtEntry);
            this.Controls.Add(this.txtObinicial);
            this.Controls.Add(this.txtIDorder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOTCE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus)).EndInit();
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIDorder;
        private System.Windows.Forms.TextBox txtObinicial;
        private dsOTCE dsOTCE1;
        private System.Windows.Forms.DateTimePicker dtEntry;
        private dsOTCE dsOTCE2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.DateTimePicker dtExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtObFinal;
        private System.Windows.Forms.NumericUpDown txtIDclient;
        private System.Windows.Forms.NumericUpDown txtTech;
        private System.Windows.Forms.NumericUpDown txtStatus;
    }
}