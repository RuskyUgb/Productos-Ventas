namespace Productos_Ventas
{
    partial class GenerarUsu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxEMP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txpasswd = new System.Windows.Forms.TextBox();
            this.TxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNaceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.TxEMP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txpasswd);
            this.panel1.Controls.Add(this.TxUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BTNaceptar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(55, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 204);
            this.panel1.TabIndex = 7;
            // 
            // TxEMP
            // 
            this.TxEMP.Location = new System.Drawing.Point(184, 19);
            this.TxEMP.Name = "TxEMP";
            this.TxEMP.Size = new System.Drawing.Size(84, 20);
            this.TxEMP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(68, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID EMPLEADO";
            // 
            // Txpasswd
            // 
            this.Txpasswd.Location = new System.Drawing.Point(184, 98);
            this.Txpasswd.Name = "Txpasswd";
            this.Txpasswd.Size = new System.Drawing.Size(177, 20);
            this.Txpasswd.TabIndex = 6;
            this.Txpasswd.UseSystemPasswordChar = true;
            // 
            // TxUsuario
            // 
            this.TxUsuario.Location = new System.Drawing.Point(184, 57);
            this.TxUsuario.Name = "TxUsuario";
            this.TxUsuario.Size = new System.Drawing.Size(177, 20);
            this.TxUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "INGRESE CONTRASEÑA";
            // 
            // BTNaceptar
            // 
            this.BTNaceptar.FlatAppearance.BorderSize = 0;
            this.BTNaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(125)))), ((int)(((byte)(178)))));
            this.BTNaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNaceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNaceptar.Location = new System.Drawing.Point(156, 147);
            this.BTNaceptar.Name = "BTNaceptar";
            this.BTNaceptar.Size = new System.Drawing.Size(75, 23);
            this.BTNaceptar.TabIndex = 0;
            this.BTNaceptar.Text = "Guardar";
            this.BTNaceptar.UseVisualStyleBackColor = true;
            this.BTNaceptar.Click += new System.EventHandler(this.BTNaceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "INGRESE USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registro de Usuarios";
            // 
            // GenerarUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(125)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(535, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "GenerarUsu";
            this.Text = "GenerarUsu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txpasswd;
        private System.Windows.Forms.TextBox TxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNaceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxEMP;
        private System.Windows.Forms.Label label4;
    }
}