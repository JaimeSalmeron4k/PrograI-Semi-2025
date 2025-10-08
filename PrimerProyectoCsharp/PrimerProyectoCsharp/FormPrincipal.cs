using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyectoCsharp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocentes objDocentes = new FrmDocentes();
            objDocentes.MdiParent = this;
            objDocentes.Show();
        }
       
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaterias objMaterias = new FrmMaterias();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPeriodos objPeriodos = new FrmPeriodos();
            objPeriodos.MdiParent = this;
            objPeriodos.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNotas objNota = new FrmNotas();
            objNota.MdiParent = this;
            objNota.Show();
        }
    }
}
