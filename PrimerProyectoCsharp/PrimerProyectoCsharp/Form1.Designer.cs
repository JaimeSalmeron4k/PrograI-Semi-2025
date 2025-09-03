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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoMoneda = new System.Windows.Forms.Label();
            this.lblConvertirMoneda = new System.Windows.Forms.Label();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.cboTipoarea = new System.Windows.Forms.ComboBox();
            this.cboConvertirarea = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(173, 32);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(654, 82);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor de Area";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMoneda.Location = new System.Drawing.Point(72, 245);
            this.lblTipoMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMoneda.Name = "lblTipoMoneda";
            this.lblTipoMoneda.Size = new System.Drawing.Size(418, 37);
            this.lblTipoMoneda.TabIndex = 2;
            this.lblTipoMoneda.Text = "Seleccione el tipo de area:";
            // 
            // lblConvertirMoneda
            // 
            this.lblConvertirMoneda.AutoSize = true;
            this.lblConvertirMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertirMoneda.Location = new System.Drawing.Point(72, 302);
            this.lblConvertirMoneda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConvertirMoneda.Name = "lblConvertirMoneda";
            this.lblConvertirMoneda.Size = new System.Drawing.Size(194, 37);
            this.lblConvertirMoneda.TabIndex = 3;
            this.lblConvertirMoneda.Text = "Convertir a:";
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.AutoSize = true;
            this.lblTotalArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalArea.Location = new System.Drawing.Point(74, 379);
            this.lblTotalArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(104, 37);
            this.lblTotalArea.TabIndex = 4;
            this.lblTotalArea.Text = "Total:";
            // 
            // cboTipoarea
            // 
            this.cboTipoarea.FormattingEnabled = true;
            this.cboTipoarea.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana ",
            "Hectárea"});
            this.cboTipoarea.Location = new System.Drawing.Point(535, 254);
            this.cboTipoarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoarea.Name = "cboTipoarea";
            this.cboTipoarea.Size = new System.Drawing.Size(222, 28);
            this.cboTipoarea.TabIndex = 5;
            // 
            // cboConvertirarea
            // 
            this.cboConvertirarea.FormattingEnabled = true;
            this.cboConvertirarea.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana ",
            "Hectárea"});
            this.cboConvertirarea.Location = new System.Drawing.Point(303, 311);
            this.cboConvertirarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboConvertirarea.Name = "cboConvertirarea";
            this.cboConvertirarea.Size = new System.Drawing.Size(239, 28);
            this.cboConvertirarea.TabIndex = 6;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(367, 451);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(358, 74);
            this.btnConvertir.TabIndex = 32;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(72, 155);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(261, 37);
            this.lblValor.TabIndex = 33;
            this.lblValor.Text = "Escriba el valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(353, 165);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(189, 26);
            this.txtValor.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 643);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cboConvertirarea);
            this.Controls.Add(this.cboTipoarea);
            this.Controls.Add(this.lblTotalArea);
            this.Controls.Add(this.lblConvertirMoneda);
            this.Controls.Add(this.lblTipoMoneda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoMoneda;
        private System.Windows.Forms.Label lblConvertirMoneda;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.ComboBox cboTipoarea;
        private System.Windows.Forms.ComboBox cboConvertirarea;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
    }
}

