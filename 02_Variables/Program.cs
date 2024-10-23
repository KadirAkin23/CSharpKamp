using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Double Değişkenler

			//double number;
			//number = 4.85;

			//Console.WriteLine(number);

			//         Console.WriteLine("***** Fiyat Listesi *****");
			//         Console.WriteLine();

			//         double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

			//         applePrice = 14.85;
			//         orangePrice = 20.95;
			//         strawberryPrice = 45;
			//         potatoPrice = 9.74;
			//         tomatoPrice = 6.88;

			//         Console.WriteLine("---- Elma Birim Fiyatı :" +applePrice +  "TL");
			//         Console.WriteLine("---- Portakal Birim Fiyatı : " +orangePrice + "TL");
			//Console.WriteLine("---- çilek Birim Fiyatı : " + strawberryPrice + "TL");
			//Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + "TL");
			//Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + "TL");

			//         Console.WriteLine();
			//         Console.WriteLine();

			//         double appleGram , orangeGram , strawberryGram , potatoGram , tomatoGram;

			//         appleGram = 1.245;
			//         orangeGram = 2.650;
			//         strawberryGram = 0.750;
			//         potatoGram = 4.859;
			//         tomatoGram = 3.745;

			//         double appleTotalPrice = appleGram * applePrice;
			//         double orangeTotalPrice = orangeGram * orangePrice;
			//         double strawberryTotalPrice = strawberryGram * strawberryPrice;
			//         double potatoTotalPrice = potatoGram * potatoPrice;
			//         double tomatoTotalPrice = tomatoGram * tomatoPrice;

			//         Console.WriteLine("---------------------------------------------------------");
			//Console.WriteLine();
			//Console.WriteLine("Toplam Fİyat");
			//         Console.WriteLine();
			//         Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fİyatı: " + applePrice + "TL" + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice + "TL");
			//Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fİyatı: " + orangePrice + "TL" + " - Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice + "TL");
			//Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fİyatı: " + strawberryPrice + "TL" + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice + "TL");
			//Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fİyatı: " + potatoPrice + "TL" + " - Gramaj: " + potatoGram + " Toplam Tutar: " + potatoTotalPrice + "TL");
			//Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fİyatı: " + tomatoPrice + "TL" + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice + "TL");


			//         double shoppingTotlPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

			//         Console.WriteLine();
			//         Console.WriteLine();
			//         Console.WriteLine("Alışveriş Toplam Tutarı :" +shoppingTotlPrice + "TL");





			#endregion

			#region Char Değişkenler

			//ABCDEFGH
			//DEF...
			//toplantı saat 20.00'DE
			// " '

			//char symbol;
			//symbol = 'a';

			//Console.WriteLine(symbol);

			#endregion

			#region Klavyeden Veri Girişleri String Değişkenler

			//Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
			//         Console.WriteLine();

			//string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge , passengerIdentityNumber;

			//         Console.Write("Yolcu Adı: ");
			//passengerName = Console.ReadLine();

			//         Console.Write("Yolcu Soyadı: ");
			//passengerSurname = Console.ReadLine();

			//         Console.Write("İlçe Bilgisi: ");
			//         passengerDistrict = Console.ReadLine();

			//         Console.Write("Şehir Bilgisi: ");
			//         passengerCity = Console.ReadLine();

			//         Console.Write("Yaş Bilgisi: ");
			//         passengerAge = Console.ReadLine();

			//         Console.Write("Kimlik Numarası: ");
			//         passengerIdentityNumber = Console.ReadLine();

			//         Console.WriteLine();

			//         Console.WriteLine("--------------------");
			//         Console.WriteLine("Yolcu Adı Soyadı: " +passengerName + " " + passengerSurname);
			//         Console.WriteLine("Yolcu ikamet Adresi: " + passengerDistrict + "/" + passengerCity);
			//         Console.WriteLine("Yolcu Yaş Bilgisi: " + passengerAge);
			//         Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentityNumber);


			#endregion

			#region Klavyeden Tam Sayı Girişleri ve Dönüşümler

			//ABC12D

			//         int shoesPrice, computerPrice, chairPrice, tvPrice;

			//         shoesPrice = 1000;
			//         computerPrice = 20000;
			//         chairPrice = 5000;
			//         tvPrice = 12000;

			//         int shoesCount, computerCount, chairCount , tvCount;

			//         Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
			//         shoesCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
			//computerCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
			//chairCount = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen Aldığınız Tv Sayısını Giriniz: ");
			//tvCount = int.Parse(Console.ReadLine());

			//         Console.WriteLine();
			//         Console.WriteLine();

			//         int shoesTotalPrice = shoesCount * shoesPrice;
			//         int computerTotalPrice = computerCount * computerPrice;
			//         int chairTotalPrice = chairCount * chairPrice;
			//         int tvTotalPrice = tvCount * tvPrice;

			//         Console.WriteLine("Toplam Ayakkabı Fiyatı: " + shoesTotalPrice + "TL");
			//Console.WriteLine("Toplam Bilgisayar Fiyatı: " + computerTotalPrice + "TL");
			//Console.WriteLine("Toplam Sandalye Fiyatı: " + chairTotalPrice + "TL");
			//Console.WriteLine("Toplam Televizyon Fiyatı: " + tvTotalPrice + "TL");



			#endregion

			#region Klavyeden Ondalıklı Sayı İşlemleri

			//double exam1, exam2 ,exam3 ,result;

			//         Console.Write("Lütfen Birnci Sınav Notunu Giriniz: ");
			//exam1 = double.Parse(Console.ReadLine());

			//Console.Write("Lütfen İkinci Sınav Notunu Giriniz: ");
			//exam2 = double.Parse(Console.ReadLine());

			//Console.Write("Lütfen Üçüncü Sınav Notunu Giriniz: ");
			//exam3 = double.Parse(Console.ReadLine());

			//result = (exam1 + exam2 + exam3) / 3;

			//         Console.WriteLine();
			//         Console.WriteLine("Sınav Not Ortalaması: " + result);



			#endregion

			#region Klavyeden Karakter Girişleri

			//char gender;

   //         Console.WriteLine("Lütfen Cinsiyet Seçiniz: ");
			//gender = char.Parse(Console.ReadLine());

   //         Console.WriteLine("Seçtiğiniz Cinsiyet: " +gender);

            #endregion



            Console.Read();









        }
	}
}
