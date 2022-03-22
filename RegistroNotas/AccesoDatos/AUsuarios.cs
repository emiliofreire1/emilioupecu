using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
	public class AUsuarios
	{
		public string RES;
		public string RegistraUsuarios(String Nombres, String Cedula, String Numero, string Placa)
		{
			if (!File.Exists(@"D:\EmilioUPS\usuarios.csv"))
			{
				TextWriter Escribe = new StreamWriter(@"D:\EmilioUPS\usuarios.csv");
				Escribe.Close();
				StreamWriter agregarEN = File.AppendText(@"D:\EmilioUPS\usuarios.csv");
				agregarEN.WriteLine("NOMBRES" + ";" + "CEDULA" + ";" + "NUMERO" + ";" + "PLACA");
				agregarEN.Close();
			}

			//VALIDACION DE USUARIOS Y CONTRASEÑAS
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
					string cedula = fields[1];
					string placa = fields[3];

					if (cedula == Cedula && placa == Placa)
					{
						RES = "YA EXISTE";
						break;
					}
					else
						RES = "NO EXISTE";
				}


				if (RES == "NO EXISTE")
				{
					//graba los registros de notas en el archivo de acuerdo al docente
					StreamWriter agregar = File.AppendText(@"D:\EmilioUPS\usuarios.csv");
					agregar.WriteLine(Nombres + ";" + Cedula + ";" + Numero + ";" + Placa);
					agregar.Close();
				}
			}
			return "";
		}
	}
}
