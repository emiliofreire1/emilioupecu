using Microsoft.VisualBasic.FileIO;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace RegistroNotas.Formulario
{
	public partial class FrmGraficos : Form
	{
		public FrmGraficos()
		{
			InitializeComponent();
		}

		private void FrmGraficos_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var path = @"D:\EmilioUPS\Notasgerman freire.csv";
			openFileDialog1.ShowDialog();
			path = openFileDialog1.FileName;
			if (string.IsNullOrEmpty(path))
			{
				MessageBox.Show("Archivo no existe");
			}
			else 
			{ 
				int i = 0;
				using (TextFieldParser csvReader = new TextFieldParser(path))
				{
					csvReader.CommentTokens = new string[] { "#" };
					csvReader.SetDelimiters(new string[] { ";" });
					csvReader.HasFieldsEnclosedInQuotes = true;
					csvReader.ReadLine(); //Lee Line por linea el archivo csv
					while (!csvReader.EndOfData)
					{
						DgvNotas.Rows.Add(1);
						string[] fields = csvReader.ReadFields(); //separa las columnas por cada linea
						DgvNotas.Rows[i].Cells["Nombres"].Value = fields[0];
						DgvNotas.Rows[i].Cells["Nota1"].Value = fields[1];
						DgvNotas.Rows[i].Cells["Nota2"].Value = fields[2];
						DgvNotas.Rows[i].Cells["Promedio"].Value = fields[4];
						i++;
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			chart1.Series.Clear();
			chart1.Titles.Clear();
			// Arreglos del Grafico
			string[] seriesArray = { "Nota1", "Nota 2", "Promedio" };
			int[] pointsArray = { Convert.ToInt32(DgvNotas.CurrentRow.Cells["Nota1"].Value), Convert.ToInt32(DgvNotas.CurrentRow.Cells["Nota2"].Value), Convert.ToInt32(DgvNotas.CurrentRow.Cells["Promedio"].Value) };
			// Se modifica la Paleta de Colores a utilizar por el control.
			this.chart1.Palette = ChartColorPalette.SeaGreen;
			// Se agrega un titulo al Grafico.
			this.chart1.Titles.Add(DgvNotas.CurrentRow.Cells["Nombres"].Value.ToString());
			// Agregar las Series al Grafico.
			for (int i = 0; i < seriesArray.Length; i++)
			{
				// Aqui se agregan las series o Categorias.
				Series series = this.chart1.Series.Add(seriesArray[i]);
				// Aqui se agregan los Valores.
				series.Points.Add(pointsArray[i]);
			}
		}
	}
}
