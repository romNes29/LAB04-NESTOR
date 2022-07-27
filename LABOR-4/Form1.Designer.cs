namespace LABOR_4
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
            this.btnRespaldoClientes = new System.Windows.Forms.Button();
            this.btnRespaldoCompras = new System.Windows.Forms.Button();
            this.btnRespaldoProductos = new System.Windows.Forms.Button();
            this.dgvInformacion = new System.Windows.Forms.DataGridView();
            this.cbxArchivos = new System.Windows.Forms.ComboBox();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRespaldoClientes
            // 
            this.btnRespaldoClientes.Location = new System.Drawing.Point(259, 350);
            this.btnRespaldoClientes.Name = "btnRespaldoClientes";
            this.btnRespaldoClientes.Size = new System.Drawing.Size(118, 42);
            this.btnRespaldoClientes.TabIndex = 0;
            this.btnRespaldoClientes.Text = "RESPALDAR TABLA CLIENTES";
            this.btnRespaldoClientes.UseVisualStyleBackColor = true;
            this.btnRespaldoClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRespaldoCompras
            // 
            this.btnRespaldoCompras.Location = new System.Drawing.Point(55, 350);
            this.btnRespaldoCompras.Name = "btnRespaldoCompras";
            this.btnRespaldoCompras.Size = new System.Drawing.Size(118, 42);
            this.btnRespaldoCompras.TabIndex = 1;
            this.btnRespaldoCompras.Text = "RESPALDAR TABLA COMPRAS";
            this.btnRespaldoCompras.UseVisualStyleBackColor = true;
            this.btnRespaldoCompras.Click += new System.EventHandler(this.btnRespaldoCompras_Click);
            // 
            // btnRespaldoProductos
            // 
            this.btnRespaldoProductos.Location = new System.Drawing.Point(477, 350);
            this.btnRespaldoProductos.Name = "btnRespaldoProductos";
            this.btnRespaldoProductos.Size = new System.Drawing.Size(118, 42);
            this.btnRespaldoProductos.TabIndex = 2;
            this.btnRespaldoProductos.Text = "RESPALDAR TABLA PRODUCTOS";
            this.btnRespaldoProductos.UseVisualStyleBackColor = true;
            this.btnRespaldoProductos.Click += new System.EventHandler(this.btnRespaldoProductos_Click);
            // 
            // dgvInformacion
            // 
            this.dgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformacion.Location = new System.Drawing.Point(55, 45);
            this.dgvInformacion.Name = "dgvInformacion";
            this.dgvInformacion.Size = new System.Drawing.Size(322, 236);
            this.dgvInformacion.TabIndex = 3;
            // 
            // cbxArchivos
            // 
            this.cbxArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxArchivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbxArchivos.FormattingEnabled = true;
            this.cbxArchivos.Items.AddRange(new object[] {
            "ClientesCODEXA",
            "Compras",
            "Productos"});
            this.cbxArchivos.Location = new System.Drawing.Point(477, 45);
            this.cbxArchivos.Name = "cbxArchivos";
            this.cbxArchivos.Size = new System.Drawing.Size(145, 26);
            this.cbxArchivos.TabIndex = 4;
            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMostrarInformacion.FlatAppearance.BorderSize = 0;
            this.btnMostrarInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMostrarInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInformacion.ForeColor = System.Drawing.Color.White;
            this.btnMostrarInformacion.Location = new System.Drawing.Point(479, 110);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(143, 52);
            this.btnMostrarInformacion.TabIndex = 5;
            this.btnMostrarInformacion.Text = "Mostrar Informacion";
            this.btnMostrarInformacion.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 475);
            this.Controls.Add(this.btnMostrarInformacion);
            this.Controls.Add(this.cbxArchivos);
            this.Controls.Add(this.dgvInformacion);
            this.Controls.Add(this.btnRespaldoProductos);
            this.Controls.Add(this.btnRespaldoCompras);
            this.Controls.Add(this.btnRespaldoClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRespaldoClientes;
        private System.Windows.Forms.Button btnRespaldoCompras;
        private System.Windows.Forms.Button btnRespaldoProductos;
        private System.Windows.Forms.DataGridView dgvInformacion;
        private System.Windows.Forms.ComboBox cbxArchivos;
        private System.Windows.Forms.Button btnMostrarInformacion;
    }
}

