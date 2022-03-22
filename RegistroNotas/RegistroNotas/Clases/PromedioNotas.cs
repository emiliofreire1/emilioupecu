using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroNotas.Clases
{
	public class PromedioNotas
	{
		double Promedio;
		public double PromediarNotas(double Nota1, double Nota2)
		{
			Promedio = Math.Round((Nota1 + Nota2) / 2, 0);
			return Promedio;
		}
	}
}
