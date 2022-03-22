using AccesoDatos;
using Microsoft.VisualBasic.FileIO;
using RegistroNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroNotas.Formulario
{
	public partial class FrmRegistroUsuarios : Form
	{
		public FrmRegistroUsuarios()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Verifica si el archivo ya fue creado de acuerdo al docente
			AUsuarios aUsuarios = new AUsuarios();
			aUsuarios.RegistraUsuarios(textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text);
			
			TextReader Leer = new StreamReader(@"D:\EmilioUPS\usuarios.csv");
			richTextBox1.Text = Leer.ReadToEnd();
			Leer.Close();
		}
	}
}
