namespace Proyecto_Máquinas_de_Turing
{
    partial class Proceso
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnExit2 = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.txtCintaActual = new System.Windows.Forms.TextBox();
            this.txtPosCabezal = new System.Windows.Forms.TextBox();
            this.txtEstadoActual = new System.Windows.Forms.TextBox();
            this.txtUltimaTrans = new System.Windows.Forms.TextBox();
            this.lblCintaActual = new System.Windows.Forms.Label();
            this.lblPosCabezal = new System.Windows.Forms.Label();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.lblUltimaTrans = new System.Windows.Forms.Label();
            this.panPasoAPaso = new System.Windows.Forms.Panel();
            this.BtnHabilitar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cBoxOpcion1 = new System.Windows.Forms.CheckBox();
            this.cBoxOpcion2 = new System.Windows.Forms.CheckBox();
            this.labelOpcion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.labelPasoAPaso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPasoAPaso = new System.Windows.Forms.Button();
            this.BtnAutomatico = new System.Windows.Forms.Button();
            this.labelAutomatico = new System.Windows.Forms.Label();
            this.BtnCambioAuto = new System.Windows.Forms.Button();
            this.BtnCambioPaso = new System.Windows.Forms.Button();
            this.BtnDeNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panPasoAPaso.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnRegresar.Location = new System.Drawing.Point(3, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(30, 28);
            this.BtnRegresar.TabIndex = 5;
            this.BtnRegresar.Text = "<-";
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnExit2
            // 
            this.BtnExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnExit2.Location = new System.Drawing.Point(36, 2);
            this.BtnExit2.Name = "BtnExit2";
            this.BtnExit2.Size = new System.Drawing.Size(30, 28);
            this.BtnExit2.TabIndex = 6;
            this.BtnExit2.Text = "X";
            this.BtnExit2.UseVisualStyleBackColor = false;
            this.BtnExit2.Click += new System.EventHandler(this.BtnExit2_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(120, 153);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(146, 20);
            this.txtPalabra.TabIndex = 7;
            this.txtPalabra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.BackColor = System.Drawing.Color.Black;
            this.lblIngrese.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.ForeColor = System.Drawing.Color.White;
            this.lblIngrese.Location = new System.Drawing.Point(65, 117);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(274, 16);
            this.lblIngrese.TabIndex = 8;
            this.lblIngrese.Text = "Ingrese una palabra para evaluar en la MT";
            // 
            // txtCintaActual
            // 
            this.txtCintaActual.Location = new System.Drawing.Point(134, 12);
            this.txtCintaActual.Name = "txtCintaActual";
            this.txtCintaActual.ReadOnly = true;
            this.txtCintaActual.Size = new System.Drawing.Size(169, 20);
            this.txtCintaActual.TabIndex = 10;
            this.txtCintaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPosCabezal
            // 
            this.txtPosCabezal.Location = new System.Drawing.Point(256, 38);
            this.txtPosCabezal.Name = "txtPosCabezal";
            this.txtPosCabezal.ReadOnly = true;
            this.txtPosCabezal.Size = new System.Drawing.Size(47, 20);
            this.txtPosCabezal.TabIndex = 11;
            this.txtPosCabezal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstadoActual
            // 
            this.txtEstadoActual.Location = new System.Drawing.Point(256, 64);
            this.txtEstadoActual.Name = "txtEstadoActual";
            this.txtEstadoActual.ReadOnly = true;
            this.txtEstadoActual.Size = new System.Drawing.Size(47, 20);
            this.txtEstadoActual.TabIndex = 12;
            this.txtEstadoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUltimaTrans
            // 
            this.txtUltimaTrans.Location = new System.Drawing.Point(203, 90);
            this.txtUltimaTrans.Name = "txtUltimaTrans";
            this.txtUltimaTrans.ReadOnly = true;
            this.txtUltimaTrans.Size = new System.Drawing.Size(100, 20);
            this.txtUltimaTrans.TabIndex = 13;
            this.txtUltimaTrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCintaActual
            // 
            this.lblCintaActual.AutoSize = true;
            this.lblCintaActual.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.lblCintaActual.Location = new System.Drawing.Point(12, 15);
            this.lblCintaActual.Name = "lblCintaActual";
            this.lblCintaActual.Size = new System.Drawing.Size(73, 14);
            this.lblCintaActual.TabIndex = 14;
            this.lblCintaActual.Text = "Cinta actual";
            // 
            // lblPosCabezal
            // 
            this.lblPosCabezal.AutoSize = true;
            this.lblPosCabezal.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.lblPosCabezal.Location = new System.Drawing.Point(12, 41);
            this.lblPosCabezal.Name = "lblPosCabezal";
            this.lblPosCabezal.Size = new System.Drawing.Size(157, 14);
            this.lblPosCabezal.TabIndex = 15;
            this.lblPosCabezal.Text = "Posición del cabezal de L/E";
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.AutoSize = true;
            this.lblEstadoActual.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.lblEstadoActual.Location = new System.Drawing.Point(12, 67);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(80, 14);
            this.lblEstadoActual.TabIndex = 16;
            this.lblEstadoActual.Text = "Estado actual";
            // 
            // lblUltimaTrans
            // 
            this.lblUltimaTrans.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            this.lblUltimaTrans.AutoSize = true;
            this.lblUltimaTrans.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F);
            this.lblUltimaTrans.Location = new System.Drawing.Point(12, 93);
            this.lblUltimaTrans.Name = "lblUltimaTrans";
            this.lblUltimaTrans.Size = new System.Drawing.Size(101, 14);
            this.lblUltimaTrans.TabIndex = 17;
            this.lblUltimaTrans.Text = "Última transición";
            // 
            // panPasoAPaso
            // 
            this.panPasoAPaso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panPasoAPaso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPasoAPaso.Controls.Add(this.lblCintaActual);
            this.panPasoAPaso.Controls.Add(this.txtUltimaTrans);
            this.panPasoAPaso.Controls.Add(this.lblUltimaTrans);
            this.panPasoAPaso.Controls.Add(this.txtEstadoActual);
            this.panPasoAPaso.Controls.Add(this.lblPosCabezal);
            this.panPasoAPaso.Controls.Add(this.txtPosCabezal);
            this.panPasoAPaso.Controls.Add(this.lblEstadoActual);
            this.panPasoAPaso.Controls.Add(this.txtCintaActual);
            this.panPasoAPaso.Location = new System.Drawing.Point(462, 310);
            this.panPasoAPaso.Name = "panPasoAPaso";
            this.panPasoAPaso.Size = new System.Drawing.Size(316, 126);
            this.panPasoAPaso.TabIndex = 18;
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.Enabled = false;
            this.BtnHabilitar.Font = new System.Drawing.Font("NSimSun", 12F);
            this.BtnHabilitar.Location = new System.Drawing.Point(542, 171);
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(142, 30);
            this.BtnHabilitar.TabIndex = 19;
            this.BtnHabilitar.Text = "Habilitar";
            this.BtnHabilitar.UseVisualStyleBackColor = true;
            this.BtnHabilitar.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(119, 346);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(146, 20);
            this.txtResultado.TabIndex = 20;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cBoxOpcion1
            // 
            this.cBoxOpcion1.AutoSize = true;
            this.cBoxOpcion1.BackColor = System.Drawing.Color.Transparent;
            this.cBoxOpcion1.Enabled = false;
            this.cBoxOpcion1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxOpcion1.Location = new System.Drawing.Point(559, 99);
            this.cBoxOpcion1.Name = "cBoxOpcion1";
            this.cBoxOpcion1.Size = new System.Drawing.Size(100, 20);
            this.cBoxOpcion1.TabIndex = 21;
            this.cBoxOpcion1.Text = "Automática";
            this.cBoxOpcion1.UseVisualStyleBackColor = false;
            // 
            // cBoxOpcion2
            // 
            this.cBoxOpcion2.AutoSize = true;
            this.cBoxOpcion2.BackColor = System.Drawing.Color.Transparent;
            this.cBoxOpcion2.Enabled = false;
            this.cBoxOpcion2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxOpcion2.Location = new System.Drawing.Point(559, 131);
            this.cBoxOpcion2.Name = "cBoxOpcion2";
            this.cBoxOpcion2.Size = new System.Drawing.Size(101, 20);
            this.cBoxOpcion2.TabIndex = 22;
            this.cBoxOpcion2.Text = "Paso a paso";
            this.cBoxOpcion2.UseVisualStyleBackColor = false;
            // 
            // labelOpcion
            // 
            this.labelOpcion.AutoSize = true;
            this.labelOpcion.BackColor = System.Drawing.Color.Transparent;
            this.labelOpcion.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpcion.Location = new System.Drawing.Point(459, 54);
            this.labelOpcion.Name = "labelOpcion";
            this.labelOpcion.Size = new System.Drawing.Size(307, 23);
            this.labelOpcion.TabIndex = 23;
            this.labelOpcion.Text = "¿Qué ejecución desea habilitar?";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(401, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 246);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 1);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(401, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 1);
            this.panel4.TabIndex = 27;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.Font = new System.Drawing.Font("NSimSun", 12F);
            this.BtnIngresar.Location = new System.Drawing.Point(120, 190);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(146, 29);
            this.BtnIngresar.TabIndex = 28;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // labelPasoAPaso
            // 
            this.labelPasoAPaso.AutoSize = true;
            this.labelPasoAPaso.BackColor = System.Drawing.Color.Transparent;
            this.labelPasoAPaso.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasoAPaso.Location = new System.Drawing.Point(516, 273);
            this.labelPasoAPaso.Name = "labelPasoAPaso";
            this.labelPasoAPaso.Size = new System.Drawing.Size(218, 23);
            this.labelPasoAPaso.TabIndex = 29;
            this.labelPasoAPaso.Text = "Ejecución paso a paso";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(401, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 264);
            this.panel1.TabIndex = 26;
            // 
            // BtnPasoAPaso
            // 
            this.BtnPasoAPaso.Enabled = false;
            this.BtnPasoAPaso.Font = new System.Drawing.Font("NSimSun", 12F);
            this.BtnPasoAPaso.Location = new System.Drawing.Point(463, 451);
            this.BtnPasoAPaso.Name = "BtnPasoAPaso";
            this.BtnPasoAPaso.Size = new System.Drawing.Size(146, 26);
            this.BtnPasoAPaso.TabIndex = 30;
            this.BtnPasoAPaso.Text = "Ejecutar";
            this.BtnPasoAPaso.UseVisualStyleBackColor = true;
            this.BtnPasoAPaso.Click += new System.EventHandler(this.BtnPasoAPaso_Click);
            // 
            // BtnAutomatico
            // 
            this.BtnAutomatico.Enabled = false;
            this.BtnAutomatico.Font = new System.Drawing.Font("NSimSun", 12F);
            this.BtnAutomatico.Location = new System.Drawing.Point(119, 378);
            this.BtnAutomatico.Name = "BtnAutomatico";
            this.BtnAutomatico.Size = new System.Drawing.Size(146, 26);
            this.BtnAutomatico.TabIndex = 31;
            this.BtnAutomatico.Text = "Ejecutar";
            this.BtnAutomatico.UseVisualStyleBackColor = true;
            this.BtnAutomatico.Click += new System.EventHandler(this.BtnAutomatico_Click);
            // 
            // labelAutomatico
            // 
            this.labelAutomatico.AutoSize = true;
            this.labelAutomatico.BackColor = System.Drawing.Color.Transparent;
            this.labelAutomatico.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelAutomatico.Location = new System.Drawing.Point(85, 299);
            this.labelAutomatico.Name = "labelAutomatico";
            this.labelAutomatico.Size = new System.Drawing.Size(212, 23);
            this.labelAutomatico.TabIndex = 32;
            this.labelAutomatico.Text = "Ejecución automática";
            // 
            // BtnCambioAuto
            // 
            this.BtnCambioAuto.Enabled = false;
            this.BtnCambioAuto.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambioAuto.Location = new System.Drawing.Point(615, 451);
            this.BtnCambioAuto.Name = "BtnCambioAuto";
            this.BtnCambioAuto.Size = new System.Drawing.Size(163, 39);
            this.BtnCambioAuto.TabIndex = 33;
            this.BtnCambioAuto.Text = "Cambiar a ejecucion automatica";
            this.BtnCambioAuto.UseVisualStyleBackColor = true;
            this.BtnCambioAuto.Click += new System.EventHandler(this.BtnCambioAuto_Click);
            // 
            // BtnCambioPaso
            // 
            this.BtnCambioPaso.Enabled = false;
            this.BtnCambioPaso.Font = new System.Drawing.Font("NSimSun", 8.25F);
            this.BtnCambioPaso.Location = new System.Drawing.Point(119, 419);
            this.BtnCambioPaso.Name = "BtnCambioPaso";
            this.BtnCambioPaso.Size = new System.Drawing.Size(146, 43);
            this.BtnCambioPaso.TabIndex = 34;
            this.BtnCambioPaso.Text = "Cambiar a ejecución paso a paso";
            this.BtnCambioPaso.UseVisualStyleBackColor = true;
            this.BtnCambioPaso.Click += new System.EventHandler(this.BtnCambioPaso_Click);
            // 
            // BtnDeNuevo
            // 
            this.BtnDeNuevo.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeNuevo.Location = new System.Drawing.Point(200, 5);
            this.BtnDeNuevo.Name = "BtnDeNuevo";
            this.BtnDeNuevo.Size = new System.Drawing.Size(197, 23);
            this.BtnDeNuevo.TabIndex = 35;
            this.BtnDeNuevo.Text = "Comenzar de nuevo...";
            this.BtnDeNuevo.UseVisualStyleBackColor = true;
            this.BtnDeNuevo.Click += new System.EventHandler(this.BtnDeNuevo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(47, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 45);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Máquinas de Turing";
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Proyecto_Máquinas_de_Turing.Properties.Resources.FondoZelda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 510);
            this.ControlBox = false;
            this.Controls.Add(this.BtnDeNuevo);
            this.Controls.Add(this.BtnCambioPaso);
            this.Controls.Add(this.BtnCambioAuto);
            this.Controls.Add(this.labelAutomatico);
            this.Controls.Add(this.BtnAutomatico);
            this.Controls.Add(this.BtnPasoAPaso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPasoAPaso);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelOpcion);
            this.Controls.Add(this.cBoxOpcion2);
            this.Controls.Add(this.cBoxOpcion1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.BtnHabilitar);
            this.Controls.Add(this.panPasoAPaso);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblIngrese);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.BtnExit2);
            this.Controls.Add(this.BtnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proceso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador_MT";
            this.panPasoAPaso.ResumeLayout(false);
            this.panPasoAPaso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnExit2;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCintaActual;
        private System.Windows.Forms.TextBox txtPosCabezal;
        private System.Windows.Forms.TextBox txtEstadoActual;
        private System.Windows.Forms.TextBox txtUltimaTrans;
        private System.Windows.Forms.Label lblCintaActual;
        private System.Windows.Forms.Label lblPosCabezal;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.Label lblUltimaTrans;
        private System.Windows.Forms.Panel panPasoAPaso;
        private System.Windows.Forms.Button BtnHabilitar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.CheckBox cBoxOpcion1;
        private System.Windows.Forms.CheckBox cBoxOpcion2;
        private System.Windows.Forms.Label labelOpcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label labelPasoAPaso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPasoAPaso;
        private System.Windows.Forms.Button BtnAutomatico;
        private System.Windows.Forms.Label labelAutomatico;
        private System.Windows.Forms.Button BtnCambioAuto;
        private System.Windows.Forms.Button BtnCambioPaso;
        private System.Windows.Forms.Button BtnDeNuevo;
    }
}