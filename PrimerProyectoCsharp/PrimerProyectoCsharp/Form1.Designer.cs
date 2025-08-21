namespace PrimerProyectoCsharp
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
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.lblAlmacenamiento2 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cboConversor6 = new System.Windows.Forms.ComboBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.cboConversor5 = new System.Windows.Forms.ComboBox();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.cboConversor4 = new System.Windows.Forms.ComboBox();
            this.lblLongitud2 = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.cboConversor3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.cboConversor2 = new System.Windows.Forms.ComboBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.lblMasa2 = new System.Windows.Forms.Label();
            this.lblMasa = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMoneda2 = new System.Windows.Forms.Label();
            this.cboConversor = new System.Windows.Forms.ComboBox();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo2.Location = new System.Drawing.Point(524, 331);
            this.lblTiempo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(118, 25);
            this.lblTiempo2.TabIndex = 56;
            this.lblTiempo2.Text = "a Segundos";
            // 
            // lblAlmacenamiento2
            // 
            this.lblAlmacenamiento2.AutoSize = true;
            this.lblAlmacenamiento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento2.Location = new System.Drawing.Point(605, 277);
            this.lblAlmacenamiento2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlmacenamiento2.Name = "lblAlmacenamiento2";
            this.lblAlmacenamiento2.Size = new System.Drawing.Size(67, 25);
            this.lblAlmacenamiento2.TabIndex = 55;
            this.lblAlmacenamiento2.Text = "a Byte";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(367, 416);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(262, 80);
            this.btnReiniciar.TabIndex = 54;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cboConversor6
            // 
            this.cboConversor6.FormattingEnabled = true;
            this.cboConversor6.Items.AddRange(new object[] {
            "Año",
            "Mes",
            "Semana",
            "Día",
            "Hora",
            "Minuto",
            "Milisegundo",
            "Microsegundo",
            "Nanosegundo",
            "Picosegundo"});
            this.cboConversor6.Location = new System.Drawing.Point(333, 331);
            this.cboConversor6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConversor6.Name = "cboConversor6";
            this.cboConversor6.Size = new System.Drawing.Size(180, 28);
            this.cboConversor6.TabIndex = 53;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(175, 330);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(148, 26);
            this.txtTiempo.TabIndex = 52;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(83, 331);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(84, 25);
            this.lblTiempo.TabIndex = 51;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // cboConversor5
            // 
            this.cboConversor5.FormattingEnabled = true;
            this.cboConversor5.Items.AddRange(new object[] {
            "Yottabyte (YB)",
            "Zettabyte (ZB)",
            "Exabyte (EB)",
            "Petabyte (PB)",
            "Terabyte (TB)",
            "Gigabyte (GB)",
            "Megabyte (MB)",
            "Kilobyte (kB)",
            "Hectobyte (hB)",
            "Decabyte (daB)"});
            this.cboConversor5.Location = new System.Drawing.Point(415, 276);
            this.cboConversor5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConversor5.Name = "cboConversor5";
            this.cboConversor5.Size = new System.Drawing.Size(180, 28);
            this.cboConversor5.TabIndex = 50;
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Location = new System.Drawing.Point(255, 276);
            this.txtAlmacenamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(148, 26);
            this.txtAlmacenamiento.TabIndex = 49;
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(79, 277);
            this.lblAlmacenamiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(164, 25);
            this.lblAlmacenamiento.TabIndex = 48;
            this.lblAlmacenamiento.Text = "Almacenamiento:";
            // 
            // cboConversor4
            // 
            this.cboConversor4.FormattingEnabled = true;
            this.cboConversor4.Items.AddRange(new object[] {
            "Kilómetro (km)",
            "Hectómetro (hm)",
            "Decámetro (dam)",
            "Decímetro (dm)",
            "Centímetro (cm)",
            "Milímetro (mm)",
            "Micrómetro (μm)",
            "Nanómetro (nm)",
            "Pulgada (in)",
            "Pie (ft)"});
            this.cboConversor4.Location = new System.Drawing.Point(385, 222);
            this.cboConversor4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConversor4.Name = "cboConversor4";
            this.cboConversor4.Size = new System.Drawing.Size(180, 28);
            this.cboConversor4.TabIndex = 47;
            // 
            // lblLongitud2
            // 
            this.lblLongitud2.AutoSize = true;
            this.lblLongitud2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud2.Location = new System.Drawing.Point(347, 230);
            this.lblLongitud2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLongitud2.Name = "lblLongitud2";
            this.lblLongitud2.Size = new System.Drawing.Size(23, 25);
            this.lblLongitud2.TabIndex = 46;
            this.lblLongitud2.Text = "a";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(175, 224);
            this.txtLongitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(148, 26);
            this.txtLongitud.TabIndex = 45;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.Location = new System.Drawing.Point(83, 225);
            this.lblLongitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(93, 25);
            this.lblLongitud.TabIndex = 44;
            this.lblLongitud.Text = "Longitud:";
            // 
            // cboConversor3
            // 
            this.cboConversor3.FormattingEnabled = true;
            this.cboConversor3.Items.AddRange(new object[] {
            "Metro Cúbico (m3)",
            "Hectolitro (hL)",
            "Barril de Petróleo (bbl)",
            "Galón (gal)",
            "Decalitro (daL)",
            "Pinta (pt)",
            "Onza Liquida (ft Oz)",
            "Decalitro (dL)",
            "Centilitro (cL)",
            "Mililitro (mL)"});
            this.cboConversor3.Location = new System.Drawing.Point(385, 171);
            this.cboConversor3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConversor3.Name = "cboConversor3";
            this.cboConversor3.Size = new System.Drawing.Size(180, 28);
            this.cboConversor3.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "a";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(175, 173);
            this.txtVolumen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(148, 26);
            this.txtVolumen.TabIndex = 41;
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.Location = new System.Drawing.Point(83, 174);
            this.lblVolumen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(96, 25);
            this.lblVolumen.TabIndex = 40;
            this.lblVolumen.Text = "Volumen:";
            // 
            // cboConversor2
            // 
            this.cboConversor2.FormattingEnabled = true;
            this.cboConversor2.Items.AddRange(new object[] {
            "Tonelada (t)",
            "Quintal (cwt)",
            "Stone (st)",
            "Libra (lb)",
            "Onza (oz)",
            "Hectogramo (hg)",
            "Decagramo (dg)",
            "Gramo (g)",
            "Miligramo (mg)",
            "Microgramo (µg)"});
            this.cboConversor2.Location = new System.Drawing.Point(385, 120);
            this.cboConversor2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConversor2.Name = "cboConversor2";
            this.cboConversor2.Size = new System.Drawing.Size(180, 28);
            this.cboConversor2.TabIndex = 39;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(175, 124);
            this.txtMasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(148, 26);
            this.txtMasa.TabIndex = 38;
            // 
            // lblMasa2
            // 
            this.lblMasa2.AutoSize = true;
            this.lblMasa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasa2.Location = new System.Drawing.Point(347, 125);
            this.lblMasa2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasa2.Name = "lblMasa2";
            this.lblMasa2.Size = new System.Drawing.Size(23, 25);
            this.lblMasa2.TabIndex = 37;
            this.lblMasa2.Text = "a";
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasa.Location = new System.Drawing.Point(85, 125);
            this.lblMasa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(67, 25);
            this.lblMasa.TabIndex = 36;
            this.lblMasa.Text = "Masa:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(597, 124);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(121, 25);
            this.lblResultado.TabIndex = 35;
            this.lblResultado.Text = "Resultado: ?";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(83, 416);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(261, 80);
            this.btnCalcular.TabIndex = 34;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMoneda2
            // 
            this.lblMoneda2.AutoSize = true;
            this.lblMoneda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda2.Location = new System.Drawing.Point(347, 67);
            this.lblMoneda2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoneda2.Name = "lblMoneda2";
            this.lblMoneda2.Size = new System.Drawing.Size(28, 25);
            this.lblMoneda2.TabIndex = 33;
            this.lblMoneda2.Text = "a ";
            // 
            // cboConversor
            // 
            this.cboConversor.FormattingEnabled = true;
            this.cboConversor.Items.AddRange(new object[] {
            "Cordoba (Nicaragua)",
            "Lempira (Honduras)",
            "Balboa (Panamá)",
            "Colón (Costa Rica)",
            "Quetzal (Guatemala)",
            "Peso (México)",
            "Sol (Perú)",
            "Euro (Europa)",
            "Yen (Japón)",
            "Yuan (China)"});
            this.cboConversor.Location = new System.Drawing.Point(385, 65);
            this.cboConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConversor.Name = "cboConversor";
            this.cboConversor.Size = new System.Drawing.Size(180, 28);
            this.cboConversor.TabIndex = 32;
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(175, 64);
            this.txtMoneda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(148, 26);
            this.txtMoneda.TabIndex = 31;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(83, 67);
            this.lblMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(95, 25);
            this.lblMoneda.TabIndex = 30;
            this.lblMoneda.Text = "Moneda: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 568);
            this.Controls.Add(this.lblTiempo2);
            this.Controls.Add(this.lblAlmacenamiento2);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.cboConversor6);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.cboConversor5);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.cboConversor4);
            this.Controls.Add(this.lblLongitud2);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.cboConversor3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolumen);
            this.Controls.Add(this.lblVolumen);
            this.Controls.Add(this.cboConversor2);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.lblMasa2);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMoneda2);
            this.Controls.Add(this.cboConversor);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.Label lblAlmacenamiento2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.ComboBox cboConversor6;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.ComboBox cboConversor5;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.ComboBox cboConversor4;
        private System.Windows.Forms.Label lblLongitud2;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.ComboBox cboConversor3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.ComboBox cboConversor2;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label lblMasa2;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMoneda2;
        private System.Windows.Forms.ComboBox cboConversor;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblMoneda;
    }
}

