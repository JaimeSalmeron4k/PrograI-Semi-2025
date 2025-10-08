namespace PrimerProyectoCsharp
{
    partial class FrmNotas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblidNota;
            System.Windows.Forms.Label lblMateria;
            System.Windows.Forms.Label lblPeriodo;
            System.Windows.Forms.Label lblFecha;
            this.db_academicaDataSet = new PrimerProyectoCsharp.Db_academicaDataSet();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new PrimerProyectoCsharp.Db_academicaDataSetTableAdapters.notasTableAdapter();
            this.tableAdapterManager = new PrimerProyectoCsharp.Db_academicaDataSetTableAdapters.TableAdapterManager();
            this.idNotaLabel1 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.periodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.periodosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dnotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnotasTableAdapter = new PrimerProyectoCsharp.Db_academicaDataSetTableAdapters.dnotasTableAdapter();
            this.dnotasDataGridView = new System.Windows.Forms.DataGridView();
            this.materiasTableAdapter = new PrimerProyectoCsharp.Db_academicaDataSetTableAdapters.materiasTableAdapter();
            this.materiasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materiasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.periodosTableAdapter = new PrimerProyectoCsharp.Db_academicaDataSetTableAdapters.periodosTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblidNota = new System.Windows.Forms.Label();
            lblMateria = new System.Windows.Forms.Label();
            lblPeriodo = new System.Windows.Forms.Label();
            lblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblidNota
            // 
            lblidNota.AutoSize = true;
            lblidNota.Location = new System.Drawing.Point(54, 103);
            lblidNota.Name = "lblidNota";
            lblidNota.Size = new System.Drawing.Size(21, 13);
            lblidNota.TabIndex = 1;
            lblidNota.Text = "ID:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new System.Drawing.Point(54, 132);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new System.Drawing.Size(58, 13);
            lblMateria.TabIndex = 3;
            lblMateria.Text = "MATERIA:";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new System.Drawing.Point(397, 129);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new System.Drawing.Size(59, 13);
            lblPeriodo.TabIndex = 5;
            lblPeriodo.Text = "PERIODO:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(54, 172);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(45, 13);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "FECHA:";
            // 
            // db_academicaDataSet
            // 
            this.db_academicaDataSet.DataSetName = "Db_academicaDataSet";
            this.db_academicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "notas";
            this.notasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dnotasTableAdapter = null;
            this.tableAdapterManager.docentesTableAdapter = null;
            this.tableAdapterManager.materiasTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = this.notasTableAdapter;
            this.tableAdapterManager.periodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrimerProyectoCsharp.Db_academicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idNotaLabel1
            // 
            this.idNotaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notasBindingSource, "idNota", true));
            this.idNotaLabel1.Location = new System.Drawing.Point(117, 103);
            this.idNotaLabel1.Name = "idNotaLabel1";
            this.idNotaLabel1.Size = new System.Drawing.Size(200, 23);
            this.idNotaLabel1.TabIndex = 2;
            this.idNotaLabel1.Text = "label1";
            // 
            // cboMateria
            // 
            this.cboMateria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiasBindingSource1, "nombre", true));
            this.cboMateria.DataSource = this.materiasBindingSource;
            this.cboMateria.DisplayMember = "nombre";
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(117, 129);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(252, 21);
            this.cboMateria.TabIndex = 4;
            this.cboMateria.ValueMember = "idMateria";
            this.cboMateria.SelectedValueChanged += new System.EventHandler(this.cboMateria_SelectedValueChanged);
            // 
            // materiasBindingSource1
            // 
            this.materiasBindingSource1.DataMember = "materias";
            this.materiasBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.periodosBindingSource, "periodo", true));
            this.cboPeriodo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.periodosBindingSource1, "idPeriodo", true));
            this.cboPeriodo.DataSource = this.periodosBindingSource2;
            this.cboPeriodo.DisplayMember = "periodo";
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(460, 129);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(200, 21);
            this.cboPeriodo.TabIndex = 6;
            this.cboPeriodo.ValueMember = "idPeriodo";
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.cboPeriodo_SelectedIndexChanged);
            // 
            // periodosBindingSource
            // 
            this.periodosBindingSource.DataMember = "periodos";
            this.periodosBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource1
            // 
            this.periodosBindingSource1.DataMember = "periodos";
            this.periodosBindingSource1.DataSource = this.db_academicaDataSet;
            // 
            // periodosBindingSource2
            // 
            this.periodosBindingSource2.DataMember = "periodos";
            this.periodosBindingSource2.DataSource = this.db_academicaDataSet;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(117, 168);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 8;
            // 
            // dnotasBindingSource
            // 
            this.dnotasBindingSource.DataMember = "dnotas";
            this.dnotasBindingSource.DataSource = this.db_academicaDataSet;
            // 
            // dnotasTableAdapter
            // 
            this.dnotasTableAdapter.ClearBeforeFill = true;
            // 
            // dnotasDataGridView
            // 
            this.dnotasDataGridView.AllowUserToAddRows = false;
            this.dnotasDataGridView.AllowUserToDeleteRows = false;
            this.dnotasDataGridView.AutoGenerateColumns = false;
            this.dnotasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dnotasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.idNota,
            this.idMateria,
            this.alumno,
            this.lab1,
            this.lab2,
            this.parcial,
            this.nota_final});
            this.dnotasDataGridView.DataSource = this.dnotasBindingSource;
            this.dnotasDataGridView.Location = new System.Drawing.Point(44, 207);
            this.dnotasDataGridView.Name = "dnotasDataGridView";
            this.dnotasDataGridView.Size = new System.Drawing.Size(652, 274);
            this.dnotasDataGridView.TabIndex = 9;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // materiasBindingSource2
            // 
            this.materiasBindingSource2.DataMember = "materias";
            this.materiasBindingSource2.DataSource = this.db_academicaDataSet;
            // 
            // materiasBindingSource3
            // 
            this.materiasBindingSource3.DataMember = "materias";
            this.materiasBindingSource3.DataSource = this.db_academicaDataSet;
            // 
            // periodosTableAdapter
            // 
            this.periodosTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(689, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 33);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "idDetalle";
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.ReadOnly = true;
            this.idDetalle.Visible = false;
            // 
            // idNota
            // 
            this.idNota.DataPropertyName = "idNota";
            this.idNota.HeaderText = "idNota";
            this.idNota.Name = "idNota";
            this.idNota.ReadOnly = true;
            this.idNota.Visible = false;
            // 
            // idMateria
            // 
            this.idMateria.DataPropertyName = "idMateria";
            this.idMateria.HeaderText = "idMateria";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            this.idMateria.Visible = false;
            // 
            // alumno
            // 
            this.alumno.DataPropertyName = "nombre";
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            this.alumno.Width = 250;
            // 
            // lab1
            // 
            this.lab1.DataPropertyName = "lab1";
            this.lab1.HeaderText = "LAB1";
            this.lab1.Name = "lab1";
            // 
            // lab2
            // 
            this.lab2.DataPropertyName = "lab2";
            this.lab2.HeaderText = "LAB2";
            this.lab2.Name = "lab2";
            // 
            // parcial
            // 
            this.parcial.DataPropertyName = "parcial";
            this.parcial.HeaderText = "PARCIAL";
            this.parcial.Name = "parcial";
            // 
            // nota_final
            // 
            this.nota_final.DataPropertyName = "nf";
            this.nota_final.HeaderText = "NF";
            this.nota_final.Name = "nota_final";
            this.nota_final.ReadOnly = true;
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dnotasDataGridView);
            this.Controls.Add(lblidNota);
            this.Controls.Add(this.idNotaLabel1);
            this.Controls.Add(lblMateria);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(lblPeriodo);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(lblFecha);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnotasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Db_academicaDataSet db_academicaDataSet;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private Db_academicaDataSetTableAdapters.notasTableAdapter notasTableAdapter;
        private Db_academicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idNotaLabel1;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource dnotasBindingSource;
        private Db_academicaDataSetTableAdapters.dnotasTableAdapter dnotasTableAdapter;
        private System.Windows.Forms.DataGridView dnotasDataGridView;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private Db_academicaDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
        private System.Windows.Forms.BindingSource materiasBindingSource1;
        private System.Windows.Forms.BindingSource materiasBindingSource2;
        private System.Windows.Forms.BindingSource materiasBindingSource3;
        private System.Windows.Forms.BindingSource periodosBindingSource;
        private Db_academicaDataSetTableAdapters.periodosTableAdapter periodosTableAdapter;
        private System.Windows.Forms.BindingSource periodosBindingSource1;
        private System.Windows.Forms.BindingSource periodosBindingSource2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota_final;
    }
}