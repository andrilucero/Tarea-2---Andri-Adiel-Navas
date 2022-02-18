using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2___Andri_Adiel_Navas
{
	public class Ejercicio1
	{
		public static void Main()
		{
			byte num1;
			Console.WriteLine("¿Cuál es tu edad?");
			num1 = Convert.ToByte(Console.ReadLine());
			ushort result = Convert.ToUInt16(num1);

			Console.WriteLine("No aparentas tener" + result + "años");

			byte nume1, nume2;
			Console.WriteLine("Ingrese 2 numeros de 2 cifras para multiplicarlos:");
			nume1 = Convert.ToByte(Console.ReadLine());
			nume2 = Convert.ToByte(Console.ReadLine());
			int resul3 = nume1 * nume2;
			Console.WriteLine(resul3);

			long numer1, numer2, rest, sum, product;
			Console.WriteLine("Ingrese el primer numero a evaluar");
			numer1 = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo numero a evaluar");
			numer2 = Convert.ToInt64(Console.ReadLine());
			sum = numer1 + numer2;
			rest = numer1 - numer2;
			product = numer1 / numer2;
			Console.WriteLine("La suma de los numeros es: ", sum);
			Console.WriteLine("La resta de los numeros es: ", rest);
			Console.WriteLine("El producto de los numeros es: ", product);

		}
	}
