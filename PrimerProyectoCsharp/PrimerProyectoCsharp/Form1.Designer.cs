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
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(492, 131);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(260, 123);
            this.btnConvertir.TabIndex = 0;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversor.Location = new System.Drawing.Point(44, 317);
            this.lblCantidadConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(180, 33);
            this.lblCantidadConversor.TabIndex = 1;
            this.lblCantidadConversor.Text = "CANTIDAD:";
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Location = new System.Drawing.Point(231, 325);
            this.txtCantidadConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(157, 26);
            this.txtCantidadConversor.TabIndex = 2;
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversor.Location = new System.Drawing.Point(44, 420);
            this.lblRespuestaConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(137, 33);
            this.lblRespuestaConversor.TabIndex = 3;
            this.lblRespuestaConversor.Text = "SUMA: ?";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Monedas",
            "Longitud",
            "Masa",
            "Volumen",
            "Almacenamiento",
            "Tiempo",
            "Area"});
            this.cboTipoConversor.Location = new System.Drawing.Point(147, 57);
            this.cboTipoConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(241, 28);
            this.cboTipoConversor.TabIndex = 4;
            this.cboTipoConversor.SelectedIndexChanged += new System.EventHandler(this.cboTipoConversor_SelectedIndexChanged);
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(44, 49);
            this.lblTipoConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(96, 33);
            this.lblTipoConversor.TabIndex = 5;
            this.lblTipoConversor.Text = "TIPO:";
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(44, 123);
            this.lblDeConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(66, 33);
            this.lblDeConversor.TabIndex = 7;
            this.lblDeConversor.Text = "DE:";
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Location = new System.Drawing.Point(118, 131);
            this.cboDeConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(270, 28);
            this.cboDeConversor.TabIndex = 6;
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(44, 214);
            this.lblAConversor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(44, 33);
            this.lblAConversor.TabIndex = 9;
            this.lblAConversor.Text = "A:";
            // 
            // cboAConversor
            // 
            this.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Location = new System.Drawing.Point(118, 222);
            this.cboAConversor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(270, 28);
            this.cboAConversor.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 489);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.btnConvertir);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "CONVERSORES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
    }
}
