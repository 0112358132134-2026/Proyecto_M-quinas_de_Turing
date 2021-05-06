namespace Proyecto_Máquinas_de_Turing
{
    partial class CargarTXT
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
            this.Cargar_txt = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BtnExit1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargar_txt
            // 
            this.Cargar_txt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cargar_txt.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargar_txt.Location = new System.Drawing.Point(222, 183);
            this.Cargar_txt.Name = "Cargar_txt";
            this.Cargar_txt.Size = new System.Drawing.Size(111, 36);
            this.Cargar_txt.TabIndex = 0;
            this.Cargar_txt.Text = "Cargar txt";
            this.Cargar_txt.UseVisualStyleBackColor = true;
            this.Cargar_txt.Click += new System.EventHandler(this.Cargar_txt_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(206, 145);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(148, 20);
            this.txtArchivo.TabIndex = 1;
            this.txtArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(127, 77);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 45);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Máquinas de Turing";
            // 
            // BtnExit1
            // 
            this.BtnExit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnExit1.Location = new System.Drawing.Point(520, 279);
            this.BtnExit1.Name = "BtnExit1";
            this.BtnExit1.Size = new System.Drawing.Size(40, 36);
            this.BtnExit1.TabIndex = 3;
            this.BtnExit1.Text = "X";
            this.BtnExit1.UseVisualStyleBackColor = false;
            this.BtnExit1.Click += new System.EventHandler(this.BtnExit1_Click_1);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CargarTXT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Proyecto_Máquinas_de_Turing.Properties.Resources.Portada;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 320);
            this.ControlBox = false;
            this.Controls.Add(this.BtnExit1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.Cargar_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CargarTXT";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador_MT";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cargar_txt;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnExit1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

