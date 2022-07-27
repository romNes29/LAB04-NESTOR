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
            this.SuspendLayout();
            // 
            // btnRespaldoClientes
            // 
            this.btnRespaldoClientes.Location = new System.Drawing.Point(108, 70);
            this.btnRespaldoClientes.Name = "btnRespaldoClientes";
            this.btnRespaldoClientes.Size = new System.Drawing.Size(118, 42);
            this.btnRespaldoClientes.TabIndex = 0;
            this.btnRespaldoClientes.Text = "RESPALDAR TABLA CLIENTES";
            this.btnRespaldoClientes.UseVisualStyleBackColor = true;
            this.btnRespaldoClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRespaldoCompras
            // 
            this.btnRespaldoCompras.Location = new System.Drawing.Point(108, 275);
            this.btnRespaldoCompras.Name = "btnRespaldoCompras";
            this.btnRespaldoCompras.Size = new System.Drawing.Size(118, 42);
            this.btnRespaldoCompras.TabIndex = 1;
            this.btnRespaldoCompras.Text = "RESPALDAR TABLA COMPRAS";
            this.btnRespaldoCompras.UseVisualStyleBackColor = true;
            this.btnRespaldoCompras.Click += new System.EventHandler(this.btnRespaldoCompras_Click);
            // 
            // btnRespaldoProductos
            // 
            this.btnRespaldoProductos.Location = new System.Drawing.Point(108, 178);
            this.btnRespaldoProductos.Name = "btnRespaldoProductos";
            this.btnRespaldoProductos.Size = new System.Drawing.Size(118, 42);
            this.btnRespaldoProductos.TabIndex = 2;
            this.btnRespaldoProductos.Text = "RESPALDAR TABLA PRODUCTOS";
            this.btnRespaldoProductos.UseVisualStyleBackColor = true;
            this.btnRespaldoProductos.Click += new System.EventHandler(this.btnRespaldoProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 475);
            this.Controls.Add(this.btnRespaldoProductos);
            this.Controls.Add(this.btnRespaldoCompras);
            this.Controls.Add(this.btnRespaldoClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRespaldoClientes;
        private System.Windows.Forms.Button btnRespaldoCompras;
        private System.Windows.Forms.Button btnRespaldoProductos;
    }
}

