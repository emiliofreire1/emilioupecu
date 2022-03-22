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

namespace RegistroNotas.Formulario
{
	public partial class FrmAccesoSistema : Form
	{
		public FrmAccesoSistema()
		{
			InitializeComponent();
		}

		private void FrmAccesoSistema_Load(object sender, EventArgs e)
		{

        }

		private void BtnIngreso_Click(object sender, EventArgs e)
		{
            var path = @"D:\EmilioUPS\usuarios.csv";
            using (TextFieldParser csvReader = new TextFieldParser(path))
            {
                csvReader.CommentTokens = new string[] { "#" };
                csvReader.SetDelimiters(new string[] { ";" });
                csvReader.HasFieldsEnclosedInQuotes = true;
                csvReader.ReadLine(); //Lee Line por linea el archivo csv
                while (!csvReader.EndOfData)
                {
                    string[] fields = csvReader.ReadFields(); //separa las columnas por cada linea
                    Variables.Cedula = fields[1];
                    Variables.Clave = fields[3];

                    if (Variables.Cedula == MskCI.Text && Variables.Clave == TxtClave.Text)
                    {
                        this.Close();
                        Variables.RES = "Ok";
                        MessageBox.Show("DATOS CORRECTOS");
                        break;
                    }
                    else
                        Variables.RES = "ERROR";
                }

                if (Variables.RES == "ERROR")
                    MessageBox.Show("DATOS INCORRECTOS");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtClave.Text = null;
            MskCI.Text = null;
		}
	}
}
