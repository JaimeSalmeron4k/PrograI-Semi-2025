namespace PrimerProyectoCsharp
{
    partial class FrmDocentes
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
            this.grbBusquedaDocente = new System.Windows.Forms.GroupBox();
            this.cboBuscarDocentes = new System.Windows.Forms.ComboBox();
            this.grdDocentes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grbEdicionDocente = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.grbNavegacionDocente = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosDocente = new System.Windows.Forms.Label();
            this.btnUltimoDocente = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.btnAnteriorDocente = new System.Windows.Forms.Button();
            this.btnPrimeroDocente = new System.Windows.Forms.Button();
            this.grbDatosDocente = new System.Windows.Forms.GroupBox();
            this.txtCorreoDocente = new System.Windows.Forms.TextBox();
            this.txtEspecialidadDocente = new System.Windows.Forms.TextBox();
            this.txtDuiDocente = new System.Windows.Forms.TextBox();
            this.lblCorreoDocente = new System.Windows.Forms.Label();
            this.lblEspecialidadDocente = new System.Windows.Forms.Label();
            this.lblDuiDocente = new System.Windows.Forms.Label();
            this.idDocente = new System.Windows.Forms.Label();
            this.lblTelefonoDocente = new System.Windows.Forms.Label();
            this.txtTelefonoDocente = new System.Windows.Forms.TextBox();
            this.lblDireccionDocente = new System.Windows.Forms.Label();
            this.txtDireccionDocente = new System.Windows.Forms.TextBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblCodigoDocente = new System.Windows.Forms.Label();
            this.txtCodigoDocente = new System.Windows.Forms.TextBox();
            this.lblIdDocente = new System.Windows.Forms.Label();
            this.grbBusquedaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).BeginInit();
            this.grbEdicionDocente.SuspendLayout();
            this.grbNavegacionDocente.SuspendLayout();
            this.grbDatosDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaDocente
            // 
            this.grbBusquedaDocente.Controls.Add(this.cboBuscarDocentes);
            this.grbBusquedaDocente.Controls.Add(this.grdDocentes);
            this.grbBusquedaDocente.Controls.Add(this.txtBuscarDocentes);
            this.grbBusquedaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBusquedaDocente.Location = new System.Drawing.Point(483, 51);
            this.grbBusquedaDocente.Name = "grbBusquedaDocente";
            this.grbBusquedaDocente.Size = new System.Drawing.Size(476, 275);
            this.grbBusquedaDocente.TabIndex = 7;
            this.grbBusquedaDocente.TabStop = false;
            this.grbBusquedaDocente.Text = "Busqueda Docentes";
            // 
            // cboBuscarDocentes
            // 
            this.cboBuscarDocentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarDocentes.FormattingEnabled = true;
            this.cboBuscarDocentes.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Especialidad"});
            this.cboBuscarDocentes.Location = new System.Drawing.Point(9, 28);
            this.cboBuscarDocentes.Name = "cboBuscarDocentes";
            this.cboBuscarDocentes.Size = new System.Drawing.Size(108, 24);
            this.cboBuscarDocentes.TabIndex = 12;
            // 
            // grdDocentes
            // 
            this.grdDocentes.AllowUserToAddRows = false;
            this.grdDocentes.AllowUserToDeleteRows = false;
            this.grdDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.dui,
            this.especialidad,
            this.correo,
            this.telefono,
            this.direccion});
            this.grdDocentes.Location = new System.Drawing.Point(6, 54);
            this.grdDocentes.Name = "grdDocentes";
            this.grdDocentes.ReadOnly = true;
            this.grdDocentes.Size = new System.Drawing.Size(464, 215);
            this.grdDocentes.TabIndex = 11;
            this.grdDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDocentes_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idDocente";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // dui
            // 
            this.dui.DataPropertyName = "dui";
            this.dui.HeaderText = "DUI";
            this.dui.Name = "dui";
            this.dui.ReadOnly = true;
            // 
            // especialidad
            // 
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "ESPECIALIDAD";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCIÓN";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(123, 28);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(347, 22);
            this.txtBuscarDocentes.TabIndex = 10;
            this.txtBuscarDocentes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarDocentes_KeyUp);
            // 
            // grbEdicionDocente
            // 
            this.grbEdicionDocente.Controls.Add(this.btnEliminarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnModificarDocente);
            this.grbEdicionDocente.Controls.Add(this.btnAgregarDocente);
            this.grbEdicionDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionDocente.Location = new System.Drawing.Point(293, 383);
            this.grbEdicionDocente.Name = "grbEdicionDocente";
            this.grbEdicionDocente.Size = new System.Drawing.Size(340, 74);
            this.grbEdicionDocente.TabIndex = 6;
            this.grbEdicionDocente.TabStop = false;
            this.grbEdicionDocente.Text = "Edicion";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocente.Location = new System.Drawing.Point(225, 19);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(100, 37);
            this.btnEliminarDocente.TabIndex = 3;
            this.btnEliminarDocente.Text = "Eliminar";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocente.Location = new System.Drawing.Point(114, 19);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(105, 37);
            this.btnModificarDocente.TabIndex = 1;
            this.btnModificarDocente.Text = "Modificar";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            this.btnModificarDocente.Click += new System.EventHandler(this.btnModificarDocente_Click);
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocente.Location = new System.Drawing.Point(14, 19);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(94, 37);
            this.btnAgregarDocente.TabIndex = 0;
            this.btnAgregarDocente.Text = "Nuevo";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // grbNavegacionDocente
            // 
            this.grbNavegacionDocente.Controls.Add(this.lblnRegistrosDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnUltimoDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnSiguienteDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnAnteriorDocente);
            this.grbNavegacionDocente.Controls.Add(this.btnPrimeroDocente);
            this.grbNavegacionDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionDocente.Location = new System.Drawing.Point(48, 383);
            this.grbNavegacionDocente.Name = "grbNavegacionDocente";
            this.grbNavegacionDocente.Size = new System.Drawing.Size(237, 74);
            this.grbNavegacionDocente.TabIndex = 5;
            this.grbNavegacionDocente.TabStop = false;
            this.grbNavegacionDocente.Text = "Navegacion";
            // 
            // lblnRegistrosDocente
            // 
            this.lblnRegistrosDocente.AutoSize = true;
            this.lblnRegistrosDocente.Location = new System.Drawing.Point(94, 32);
            this.lblnRegistrosDocente.Name = "lblnRegistrosDocente";
            this.lblnRegistrosDocente.Size = new System.Drawing.Size(42, 13);
            this.lblnRegistrosDocente.TabIndex = 10;
            this.lblnRegistrosDocente.Text = "x de n";
            // 
            // btnUltimoDocente
            // 
            this.btnUltimoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocente.Location = new System.Drawing.Point(186, 19);
            this.btnUltimoDocente.Name = "btnUltimoDocente";
            this.btnUltimoDocente.Size = new System.Drawing.Size(33, 37);
            this.btnUltimoDocente.TabIndex = 3;
            this.btnUltimoDocente.Text = ">|";
            this.btnUltimoDocente.UseVisualStyleBackColor = true;
            this.btnUltimoDocente.Click += new System.EventHandler(this.btnUltimoDocente_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocente.Location = new System.Drawing.Point(150, 19);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(33, 37);
            this.btnSiguienteDocente.TabIndex = 2;
            this.btnSiguienteDocente.Text = ">";
            this.btnSiguienteDocente.UseVisualStyleBackColor = true;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // btnAnteriorDocente
            // 
            this.btnAnteriorDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocente.Location = new System.Drawing.Point(47, 19);
            this.btnAnteriorDocente.Name = "btnAnteriorDocente";
            this.btnAnteriorDocente.Size = new System.Drawing.Size(33, 37);
            this.btnAnteriorDocente.TabIndex = 1;
            this.btnAnteriorDocente.Text = "<";
            this.btnAnteriorDocente.UseVisualStyleBackColor = true;
            this.btnAnteriorDocente.Click += new System.EventHandler(this.btnAnteriorDocente_Click);
            // 
            // btnPrimeroDocente
            // 
            this.btnPrimeroDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocente.Location = new System.Drawing.Point(11, 19);
            this.btnPrimeroDocente.Name = "btnPrimeroDocente";
            this.btnPrimeroDocente.Size = new System.Drawing.Size(33, 37);
            this.btnPrimeroDocente.TabIndex = 0;
            this.btnPrimeroDocente.Text = "|<";
            this.btnPrimeroDocente.UseVisualStyleBackColor = true;
            this.btnPrimeroDocente.Click += new System.EventHandler(this.btnPrimeroDocente_Click);
            // 
            // grbDatosDocente
            // 
            this.grbDatosDocente.Controls.Add(this.txtCorreoDocente);
            this.grbDatosDocente.Controls.Add(this.txtEspecialidadDocente);
            this.grbDatosDocente.Controls.Add(this.txtDuiDocente);
            this.grbDatosDocente.Controls.Add(this.lblCorreoDocente);
            this.grbDatosDocente.Controls.Add(this.lblEspecialidadDocente);
            this.grbDatosDocente.Controls.Add(this.lblDuiDocente);
            this.grbDatosDocente.Controls.Add(this.idDocente);
            this.grbDatosDocente.Controls.Add(this.lblTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.txtTelefonoDocente);
            this.grbDatosDocente.Controls.Add(this.lblDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.txtDireccionDocente);
            this.grbDatosDocente.Controls.Add(this.lblNombreDocente);
            this.grbDatosDocente.Controls.Add(this.txtNombreDocente);
            this.grbDatosDocente.Controls.Add(this.lblCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.txtCodigoDocente);
            this.grbDatosDocente.Controls.Add(this.lblIdDocente);
            this.grbDatosDocente.Enabled = false;
            this.grbDatosDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosDocente.Location = new System.Drawing.Point(22, 39);
            this.grbDatosDocente.Name = "grbDatosDocente";
            this.grbDatosDocente.Size = new System.Drawing.Size(438, 315);
            this.grbDatosDocente.TabIndex = 4;
            this.grbDatosDocente.TabStop = false;
            this.grbDatosDocente.Text = "DATOS";
            // 
            // txtCorreoDocente
            // 
            this.txtCorreoDocente.Location = new System.Drawing.Point(188, 209);
            this.txtCorreoDocente.Name = "txtCorreoDocente";
            this.txtCorreoDocente.Size = new System.Drawing.Size(240, 22);
            this.txtCorreoDocente.TabIndex = 15;
            // 
            // txtEspecialidadDocente
            // 
            this.txtEspecialidadDocente.Location = new System.Drawing.Point(148, 176);
            this.txtEspecialidadDocente.Name = "txtEspecialidadDocente";
            this.txtEspecialidadDocente.Size = new System.Drawing.Size(157, 22);
            this.txtEspecialidadDocente.TabIndex = 14;
            // 
            // txtDuiDocente
            // 
            this.txtDuiDocente.Location = new System.Drawing.Point(85, 139);
            this.txtDuiDocente.Name = "txtDuiDocente";
            this.txtDuiDocente.Size = new System.Drawing.Size(138, 22);
            this.txtDuiDocente.TabIndex = 13;
            // 
            // lblCorreoDocente
            // 
            this.lblCorreoDocente.AutoSize = true;
            this.lblCorreoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoDocente.Location = new System.Drawing.Point(42, 212);
            this.lblCorreoDocente.Name = "lblCorreoDocente";
            this.lblCorreoDocente.Size = new System.Drawing.Size(140, 16);
            this.lblCorreoDocente.TabIndex = 12;
            this.lblCorreoDocente.Text = "Correo Electrónico:";
            // 
            // lblEspecialidadDocente
            // 
            this.lblEspecialidadDocente.AutoSize = true;
            this.lblEspecialidadDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidadDocente.Location = new System.Drawing.Point(42, 176);
            this.lblEspecialidadDocente.Name = "lblEspecialidadDocente";
            this.lblEspecialidadDocente.Size = new System.Drawing.Size(103, 16);
            this.lblEspecialidadDocente.TabIndex = 11;
            this.lblEspecialidadDocente.Text = "Especialidad:";
            // 
            // lblDuiDocente
            // 
            this.lblDuiDocente.AutoSize = true;
            this.lblDuiDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiDocente.Location = new System.Drawing.Point(42, 142);
            this.lblDuiDocente.Name = "lblDuiDocente";
            this.lblDuiDocente.Size = new System.Drawing.Size(37, 16);
            this.lblDuiDocente.TabIndex = 10;
            this.lblDuiDocente.Text = "DUI:";
            // 
            // idDocente
            // 
            this.idDocente.AutoSize = true;
            this.idDocente.Location = new System.Drawing.Point(134, 37);
            this.idDocente.Name = "idDocente";
            this.idDocente.Size = new System.Drawing.Size(54, 16);
            this.idDocente.TabIndex = 9;
            this.idDocente.Text = "Label1";
            // 
            // lblTelefonoDocente
            // 
            this.lblTelefonoDocente.AutoSize = true;
            this.lblTelefonoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoDocente.Location = new System.Drawing.Point(42, 240);
            this.lblTelefonoDocente.Name = "lblTelefonoDocente";
            this.lblTelefonoDocente.Size = new System.Drawing.Size(73, 16);
            this.lblTelefonoDocente.TabIndex = 8;
            this.lblTelefonoDocente.Text = "Telefóno:";
            // 
            // txtTelefonoDocente
            // 
            this.txtTelefonoDocente.Location = new System.Drawing.Point(121, 237);
            this.txtTelefonoDocente.Name = "txtTelefonoDocente";
            this.txtTelefonoDocente.Size = new System.Drawing.Size(136, 22);
            this.txtTelefonoDocente.TabIndex = 7;
            // 
            // lblDireccionDocente
            // 
            this.lblDireccionDocente.AutoSize = true;
            this.lblDireccionDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionDocente.Location = new System.Drawing.Point(42, 271);
            this.lblDireccionDocente.Name = "lblDireccionDocente";
            this.lblDireccionDocente.Size = new System.Drawing.Size(77, 16);
            this.lblDireccionDocente.TabIndex = 6;
            this.lblDireccionDocente.Text = "Dirección:";
            // 
            // txtDireccionDocente
            // 
            this.txtDireccionDocente.Location = new System.Drawing.Point(121, 268);
            this.txtDireccionDocente.Name = "txtDireccionDocente";
            this.txtDireccionDocente.Size = new System.Drawing.Size(305, 22);
            this.txtDireccionDocente.TabIndex = 5;
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDocente.Location = new System.Drawing.Point(42, 111);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(136, 16);
            this.lblNombreDocente.TabIndex = 4;
            this.lblNombreDocente.Text = "Nombre Completo:";
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(184, 105);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(244, 22);
            this.txtNombreDocente.TabIndex = 3;
            // 
            // lblCodigoDocente
            // 
            this.lblCodigoDocente.AutoSize = true;
            this.lblCodigoDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDocente.Location = new System.Drawing.Point(42, 72);
            this.lblCodigoDocente.Name = "lblCodigoDocente";
            this.lblCodigoDocente.Size = new System.Drawing.Size(61, 16);
            this.lblCodigoDocente.TabIndex = 2;
            this.lblCodigoDocente.Text = "Código:";
            // 
            // txtCodigoDocente
            // 
            this.txtCodigoDocente.Location = new System.Drawing.Point(123, 72);
            this.txtCodigoDocente.Name = "txtCodigoDocente";
            this.txtCodigoDocente.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoDocente.TabIndex = 1;
            // 
            // lblIdDocente
            // 
            this.lblIdDocente.AutoSize = true;
            this.lblIdDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDocente.Location = new System.Drawing.Point(42, 35);
            this.lblIdDocente.Name = "lblIdDocente";
            this.lblIdDocente.Size = new System.Drawing.Size(26, 16);
            this.lblIdDocente.TabIndex = 0;
            this.lblIdDocente.Text = "ID:";
            // 
            // FrmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 568);
            this.Controls.Add(this.grbBusquedaDocente);
            this.Controls.Add(this.grbEdicionDocente);
            this.Controls.Add(this.grbNavegacionDocente);
            this.Controls.Add(this.grbDatosDocente);
            this.Name = "FrmDocentes";
            this.Text = "ADMINISTRACIÓN DE DOCENTES";
            this.Load += new System.EventHandler(this.FrmDocentes_Load);
            this.grbBusquedaDocente.ResumeLayout(false);
            this.grbBusquedaDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).EndInit();
            this.grbEdicionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.ResumeLayout(false);
            this.grbNavegacionDocente.PerformLayout();
            this.grbDatosDocente.ResumeLayout(false);
            this.grbDatosDocente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaDocente;
        private System.Windows.Forms.DataGridView grdDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.GroupBox grbEdicionDocente;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.GroupBox grbNavegacionDocente;
        private System.Windows.Forms.Label lblnRegistrosDocente;
        private System.Windows.Forms.Button btnUltimoDocente;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.Button btnAnteriorDocente;
        private System.Windows.Forms.Button btnPrimeroDocente;
        private System.Windows.Forms.GroupBox grbDatosDocente;
        private System.Windows.Forms.Label idDocente;
        private System.Windows.Forms.Label lblTelefonoDocente;
        private System.Windows.Forms.TextBox txtTelefonoDocente;
        private System.Windows.Forms.Label lblDireccionDocente;
        private System.Windows.Forms.TextBox txtDireccionDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblCodigoDocente;
        private System.Windows.Forms.TextBox txtCodigoDocente;
        private System.Windows.Forms.Label lblIdDocente;
        private System.Windows.Forms.TextBox txtEspecialidadDocente;
        private System.Windows.Forms.TextBox txtDuiDocente;
        private System.Windows.Forms.Label lblCorreoDocente;
        private System.Windows.Forms.Label lblEspecialidadDocente;
        private System.Windows.Forms.Label lblDuiDocente;
        private System.Windows.Forms.TextBox txtCorreoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dui;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.ComboBox cboBuscarDocentes;
    }
}