using System;
namespace Tarea_2___Andri_Adiel_Navas
{
	public class Ejercicios
	{
		public static void Main()
		{
			byte num1;
			Console.WriteLine("\n¿Cuál es tu edad?\n");
			num1 = Convert.ToByte(Console.ReadLine());
			ushort result = Convert.ToUInt16(num1);

			Console.WriteLine("\nNo aparentas tener\n" + result + "\naños\n");

			byte nume1, nume2;
			Console.WriteLine("\nIngrese 2 numeros de 2 cifras para multiplicarlos:\n");
			nume1 = Convert.ToByte(Console.ReadLine());
			nume2 = Convert.ToByte(Console.ReadLine());
			int resul3 = nume1 * nume2;
			Console.WriteLine(resul3);

			long numer1, numer2, rest, sum, product;
			Console.WriteLine("\nIngrese el primer numero a evaluar:\n");
			numer1 = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("\nIngrese el segundo numero a evaluar:\n");
			numer2 = Convert.ToInt64(Console.ReadLine());
			sum = numer1 + numer2;
			rest = numer1 - numer2;
			product = numer1 / numer2;
			Console.WriteLine("\nLa suma de los numeros es: \n" + sum); Console.ReadLine();
			Console.WriteLine("\nLa resta de los numeros es: \n" + rest); Console.ReadLine();
			Console.WriteLine("\nEl producto de los numeros es: \n" + product); Console.ReadLine();

		}
	}
}
