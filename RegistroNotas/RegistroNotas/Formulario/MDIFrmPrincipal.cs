using RegistroNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroNotas.Formulario
{
	public partial class MDIFrmPrincipal : Form
	{
		public MDIFrmPrincipal()
		{
			InitializeComponent();
		}

		private void MDIFrmPrincipal_Load(object sender, EventArgs e)
		{
		}

		private void MDIFrmPrincipal_Activated(object sender, EventArgs e)
		{
			if (Variables.RES == "Ok")
			{
				accesoSistemaToolStripMenuItem.Enabled = false;
				registroNotasToolStripMenuItem.Enabled = true;
				graficarNotasToolStripMenuItem.Enabled = true;
				registroDeNotasToolStripMenuItem.Enabled = true;
			}
		}

		private void accesoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmAccesoSistema AccesoSistema = new FrmAccesoSistema();
			AccesoSistema.MdiParent = this;
			AccesoSistema.Show();
		}

		private void registroNotasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmRegistroNotas RegistroNotas = new FrmRegistroNotas();
			RegistroNotas.MdiParent = this;
			RegistroNotas.Show();
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (salirToolStripMenuItem.Text == "Salir")
			{
				if (MessageBox.Show("Desea Salir del Sistema", "Registro Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Close();
			}
			else
			{
				if (MessageBox.Show("Do you want to exit system", "Registro Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					this.Close();
			}
		}

		private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			sistemaToolStripMenuItem.Text = "System";
			accesoSistemaToolStripMenuItem.Text = "LogIn";
			salirToolStripMenuItem.Text = "Exit";

			registroDeNotasToolStripMenuItem.Text = "Record Notes";
			registroNotasToolStripMenuItem.Text = "Record Notes";
			graficarNotasToolStripMenuItem.Text = "Graph Notes";
		}

		private void españolToolStripMenuItem_Click(object sender, EventArgs e)
		{
			sistemaToolStripMenuItem.Text = "Sistema";
			accesoSistemaToolStripMenuItem.Text = "Acceso Sistema";
			salirToolStripMenuItem.Text = "Salir";

			registroDeNotasToolStripMenuItem.Text = "Registro de Notas";
			registroNotasToolStripMenuItem.Text = "Registro Notas";
			graficarNotasToolStripMenuItem.Text = "Graficar Notas";
		}

		private void graficarNotasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmGraficos FGraficos = new FrmGraficos();
			FGraficos.MdiParent = this;
			FGraficos.Show();
		}

		private void registroUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FrmRegistroUsuarios FrmUsuarios = new FrmRegistroUsuarios();
			FrmUsuarios.MdiParent = this;
			FrmUsuarios.Show();
		}
	}
}
