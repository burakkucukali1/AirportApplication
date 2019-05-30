using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaalanıKutuphanesi
{
	public class Helper
	{
		public static char KlavyedenKarakterOku()
		{
			ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			return keyInfo.KeyChar;
		}
		public static void EkraniTemizle()
		{
			Console.Clear();
		}
		public static void Bekle()
		{
			Console.ReadKey();
		}
		public static void EkranaYaz(int sayi)
		{
			EkranaYaz(sayi.ToString());
		}

		public static void EkranaYaz(string metin)
		{
			Console.WriteLine(metin);
		}
		public static void EkranaYaz(int[] sayilar)
		{
			for (int i = 0; i < sayilar.Length; i++)
			{
				EkranaYaz(sayilar[i] + " ");
			}
		}
		public static void SatirBasiYap()
		{
			Console.WriteLine();
		}
		public static string EkrandanOku()
		{
			return Console.ReadLine();
		}
		public static void DiziyeElemanEkle(ref string[,] dizi, string birinciBoyutDegeri, string ikinciBoyutDegeri)
		{
			string[,] yeniDizi = new string[dizi.GetLength(0) + 1, dizi.GetLength(1)];
			DiziKopyala(dizi, yeniDizi);

			yeniDizi[dizi.GetLength(0), 0] = birinciBoyutDegeri;
			yeniDizi[dizi.GetLength(0), 1] = ikinciBoyutDegeri;

			dizi = yeniDizi;
		}
		public static void DiziKopyala(string[,] kaynakDizi, string[,] hedefDizi)
		{
			for (int i = 0; i < kaynakDizi.GetLength(0); i++)
			{
				for (int j = 0; j < kaynakDizi.GetLength(1); j++)
				{
					hedefDizi[i, j] = kaynakDizi[i, j];
				}
			}
		}
		public static int KontrolluSayiAl(string istekMesaji, string hataMesaji)
		{
			EkranaYaz(istekMesaji);
			string input = EkrandanOku();
			int sayi;
			bool donustuMu = int.TryParse(input, out sayi);
			if (donustuMu)
			{
				return sayi;
			}
			EkranaYaz(hataMesaji);
			SatirBasiYap();
			return KontrolluSayiAl(istekMesaji, hataMesaji);
		}
	}
}