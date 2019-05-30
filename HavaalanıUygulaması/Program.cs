using HavaalanıKutuphanesi;
using System;

namespace HavaalanıUygulaması
{
	class Program
	{
		const int koltukSayisi = 20;
		const int businessClassKoltukSayisi = 8;
		const int economyClassKoltukSayisi = 12;
		static string[] koltuklar = new string[koltukSayisi];
	

		static void Main(string[] args)
		{
			KarsilamaEkrani();
			Helper.Bekle();
			Helper.EkraniTemizle();
			for (; ; )
			{
				SınıfSecimi();
				Helper.Bekle();
				Helper.EkraniTemizle();
			}
		}
		static void KarsilamaEkrani()
		{
			Helper.EkranaYaz("*************************************************");
			Helper.EkranaYaz("Havaalanı Rezervasyon Uygulamasına Hoşgeldiniz.");
			Helper.EkranaYaz("************************************************");

		}

		static void SınıfSecimi()
		{
			string secim = "";
			Helper.EkranaYaz(" 1. Business Class bölümü için 1 tuşuna basın.\n 2. Economy Class bölümü için 2 tuşuna basın.");
		
			do
			{
				secim = Console.ReadKey(true).KeyChar.ToString();

			} while (secim != "1" && secim != "2");
			if (secim == "1")
			{
				Helper.EkraniTemizle();
				Helper.EkranaYaz("Business Class bölümünde kalan boş koltuklar: ");

				for (int i = 0; i <8; i++)
				{
					Helper.EkranaYaz((1+i)+ "-" +koltuklar[i]);
				}
			}
			else
			{
				Helper.EkraniTemizle();
				Helper.EkranaYaz("Economy Class bölümünde kalan boş koltuklar: ");

				for (int i = 8; i < 20; i++)
				{
					Helper.EkranaYaz((1+i)+ "-"+ koltuklar[i]);
				}
			}
			int kullanıcınınSectigiKoltuk = Helper.KontrolluSayiAl("","");

			//Business
			if (secim=="1" && kullanıcınınSectigiKoltuk<9 && kullanıcınınSectigiKoltuk>0 && koltuklar[kullanıcınınSectigiKoltuk-1]!=null)
			{
				Helper.EkraniTemizle();
				Helper.EkranaYaz("Seçilen koltuk numarası: " + kullanıcınınSectigiKoltuk);
				Helper.EkranaYaz(kullanıcınınSectigiKoltuk + " numaralı koltuğu daha önce " + koltuklar[kullanıcınınSectigiKoltuk - 1] + "isimli yolcuya rezerve ettiniz!");
				Helper.EkranaYaz("Boş olan koltuklar: ");

				for (int i = 1; i <=8; i++)
				{
					if (koltuklar[i]==null)
					{
						
						Helper.EkranaYaz(koltuklar[i]);
					}
				}
			}
			else if(secim=="1" && kullanıcınınSectigiKoltuk < 9 && kullanıcınınSectigiKoltuk > 0 && koltuklar[kullanıcınınSectigiKoltuk - 1] == null)
			{
				Helper.EkraniTemizle();
				Helper.EkranaYaz("Lütfen yolcunun adını ve soyadını yazınız.");
				string yolcuBilgileri = Helper.EkrandanOku();
				koltuklar[kullanıcınınSectigiKoltuk - 1]=yolcuBilgileri;
				Helper.EkranaYaz(kullanıcınınSectigiKoltuk + " numaralı koltuk " + yolcuBilgileri + " adına ayrılmıştır. ");
				Helper.EkranaYaz("İyi uçuşlar dileriz...");

			}
			//Economy
			else if (secim == "2" && kullanıcınınSectigiKoltuk < 20 && kullanıcınınSectigiKoltuk > 8 && koltuklar[kullanıcınınSectigiKoltuk - 1] != null)
			{
				Helper.EkraniTemizle();
				Helper.EkranaYaz("Seçilen koltuk numarası: " + kullanıcınınSectigiKoltuk);
				Helper.EkranaYaz(kullanıcınınSectigiKoltuk + " numaralı koltuğu daha önce " + koltuklar[kullanıcınınSectigiKoltuk - 1] + " isimli yolcuya rezerve edilmiştir!");

				for (int i = 9; i <21 ; i++)
				{
					if (koltuklar[i] == null)
					{
						Helper.EkranaYaz(i + 1);
					}
				}
			}
			
			else if (secim == "2" && kullanıcınınSectigiKoltuk < 21 && kullanıcınınSectigiKoltuk > 8 && koltuklar[kullanıcınınSectigiKoltuk - 1] == null)
			{
				Helper.EkraniTemizle();
				Helper.EkranaYaz(" Lütfen yolcunun adını ve soyadını yazınız. ");
				string yolcuBilgileri = Helper.EkrandanOku();
				koltuklar[kullanıcınınSectigiKoltuk - 1] = yolcuBilgileri;
				Helper.EkranaYaz(kullanıcınınSectigiKoltuk + " numaralı koltuk " + yolcuBilgileri + " adına ayrılmıştır. ");
				Helper.EkranaYaz("İyi uçuşlar dileriz...");

			}

			else
			{
				Helper.EkranaYaz("Bütün koltuklarımız doludur. Bir sonraki uçak 4 saat sonradır. ");
			}
		}
		
	}
}
