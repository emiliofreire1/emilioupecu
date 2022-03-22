using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroNotas.Clases
{
	public class SumaNotas
	{ 
		int Suma;
		public int SumarNotas(int Nota1, int Nota2)
		{
			Suma = Nota1 + Nota2;
			return Suma;
		}
	}
}
