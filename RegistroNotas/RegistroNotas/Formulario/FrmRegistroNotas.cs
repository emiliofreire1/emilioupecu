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
	public partial class FrmRegistroNotas : Form
	{
		public FrmRegistroNotas()
		{
			InitializeComponent();
		}

		private void BtnRegistrar_Click(object sender, EventArgs e)
		{
			//Verifica si el archivo ya fue creado de acuerdo al docente
			if (!File.Exists(@"D:\EmilioUPS\Notas" + Variables.Nombres + ".csv"))
			{
				TextWriter Escribe = new StreamWriter(@"D:\EmilioUPS\Notas\RUTAS.csv");
				Escribe.Close();
			}
			//graba los registros de notas en el archivo de acuerdo al docente
			StreamWriter agregar = File.AppendText(@"D:\EmilioUPS\Notas" + Variables.Nombres + ".csv");
			agregar.WriteLine(TxtNombres.Text + ";" + TxtNota1.Text + ";" + TxtNota2.Text + ";" + TxtSuma.Text + ";" + TxtPromedio.Text + "; " + TxtObservacion.Text);
			agregar.Close();

			//lee el archivo notas y lo presenta en el richtextbox
			TextReader Leer = new StreamReader(@"D:\EmilioUPS\Notas" + Variables.Nombres + ".csv");
			RTxtNotas.Text = Leer.ReadToEnd();
			Leer.Close();

		}

		private void TxtNota1_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TxtNota1.Text))
				TxtNota1.Text = "0";
			else
			{
				if (int.Parse(TxtNota1.Text) >= 0 && int.Parse(TxtNota1.Text) <= 100)
					TxtNota2.Focus();
				else
				{
					MessageBox.Show("Notas Erroneas");
					TxtNota1.Focus();
				}
			}
		}

		private void TxtNota2_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TxtNota2.Text))
				TxtNota2.Text = "0";
			else
			{
				if (int.Parse(TxtNota2.Text) >= 0 && int.Parse(TxtNota2.Text) <= 100)
				{
					SumaNotas SumNotas = new SumaNotas();
					PromedioNotas PromNotas = new PromedioNotas();
					BtnRegistrar.Focus();
					//calcula la suma de las notas
					TxtSuma.Text = Convert.ToString(SumNotas.SumarNotas(int.Parse(TxtNota1.Text), int.Parse(TxtNota2.Text)));
					//Calcula el promedio de las notas
					TxtPromedio.Text = Convert.ToString(PromNotas.PromediarNotas(int.Parse(TxtNota1.Text), int.Parse(TxtNota2.Text)));
					if (double.Parse(TxtPromedio.Text) >= 70)
						TxtObservacion.Text = "APROBADO";
					else
						TxtObservacion.Text = "REPROBADO";

				}
				else
				{
					MessageBox.Show("Notas Erroneas");
					TxtNota2.Focus();
				}
			}
		}
	}
}
