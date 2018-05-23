namespace Productos_Ventas
{
    partial class Form1
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
            this.DTG1 = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxIdProd = new System.Windows.Forms.TextBox();
            this.TxNomProd = new System.Windows.Forms.TextBox();
            this.TxModPro = new System.Windows.Forms.TextBox();
            this.TxCantProd = new System.Windows.Forms.TextBox();
            this.TxPrecProd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.Pnl = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTG1)).BeginInit();
            this.Pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTG1
            // 
            this.DTG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG1.Location = new System.Drawing.Point(275, 19);
            this.DTG1.Name = "DTG1";
            this.DTG1.Size = new System.Drawing.Size(568, 311);
            this.DTG1.TabIndex = 0;
            this.DTG1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClicDGV);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(4, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "ID_Prod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio";
            // 
            // TxIdProd
            // 
            this.TxIdProd.Location = new System.Drawing.Point(109, 5);
            this.TxIdProd.Name = "TxIdProd";
            this.TxIdProd.Size = new System.Drawing.Size(100, 20);
            this.TxIdProd.TabIndex = 6;
            // 
            // TxNomProd
            // 
            this.TxNomProd.Location = new System.Drawing.Point(109, 40);
            this.TxNomProd.Name = "TxNomProd";
            this.TxNomProd.Size = new System.Drawing.Size(100, 20);
            this.TxNomProd.TabIndex = 7;
            // 
            // TxModPro
            // 
            this.TxModPro.Location = new System.Drawing.Point(109, 76);
            this.TxModPro.Name = "TxModPro";
            this.TxModPro.Size = new System.Drawing.Size(100, 20);
            this.TxModPro.TabIndex = 8;
            // 
            // TxCantProd
            // 
            this.TxCantProd.Location = new System.Drawing.Point(109, 110);
            this.TxCantProd.Name = "TxCantProd";
            this.TxCantProd.Size = new System.Drawing.Size(100, 20);
            this.TxCantProd.TabIndex = 9;
            // 
            // TxPrecProd
            // 
            this.TxPrecProd.Location = new System.Drawing.Point(109, 143);
            this.TxPrecProd.Name = "TxPrecProd";
            this.TxPrecProd.Size = new System.Drawing.Size(100, 20);
            this.TxPrecProd.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mostrar Opciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCerrar.Location = new System.Drawing.Point(150, 224);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(96, 22);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.Text = "Cerrar Opciones";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Pnl
            // 
            this.Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl.Controls.Add(this.button5);
            this.Pnl.Controls.Add(this.button6);
            this.Pnl.Controls.Add(this.button4);
            this.Pnl.Controls.Add(this.button3);
            this.Pnl.Controls.Add(this.button2);
            this.Pnl.Location = new System.Drawing.Point(12, 256);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(248, 120);
            this.Pnl.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(137, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Mostrar todo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(137, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 27);
            this.button6.TabIndex = 16;
            this.button6.Text = "Filtrar por : ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(11, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 22);
            this.button4.TabIndex = 14;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(11, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 22);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(11, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 22);
            this.button2.TabIndex = 12;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(849, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "X";
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label6_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.panel1.Controls.Add(this.TxPrecProd);
            this.panel1.Controls.Add(this.TxCantProd);
            this.panel1.Controls.Add(this.TxModPro);
            this.panel1.Controls.Add(this.TxNomProd);
            this.panel1.Controls.Add(this.TxIdProd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 166);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(83)))), ((int)(((byte)(118)))));
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Location = new System.Drawing.Point(275, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 58);
            this.panel2.TabIndex = 17;
            this.panel2.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox2.Location = new System.Drawing.Point(114, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Modelo";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(19, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Nombre";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(125)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(881, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pnl);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTG1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG1)).EndInit();
            this.Pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTG1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxIdProd;
        private System.Windows.Forms.TextBox TxNomProd;
        private System.Windows.Forms.TextBox TxModPro;
        private System.Windows.Forms.TextBox TxCantProd;
        private System.Windows.Forms.TextBox TxPrecProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

