﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Void Metotlar

			//()
			//Geriye Değer Dödürmeyen Metotlar
			//Customer --> Listele,ekle,sil,güncelle

			//void CustomerList()
			//{
			//  Console.WriteLine("Ali Yıldız");
			//	Console.WriteLine("Ayşe Yıldız");
			//	Console.WriteLine("Hakan Öztürk");
			//	Console.WriteLine("Merve Çınar");
			//}

			//CustomerList();

			//----------------------------------------------------------------------

			//void Sum()
			//{
			//	int x = 1;
			//	int y = 2;
			//	int z = x + y;
			//             Console.WriteLine(z);
			//         }

			//Sum();




			#endregion

			#region Geriye Değer Döndürmeyen String Parametreli Metotlar

			//void WriteMethod(string customerName)
			//{
			// Console.WriteLine(customerName);
			//}

			//WriteMethod("Mehmet Yıldırım");


			//-------------------------------------------------------------------

			//void customerName (string name ,string surName)
			//{
			//   Console.WriteLine("Müşteri: " + name + " " + surName);
			//}

			//customerName("Mehmet", "Yıldız");
			//customerName("Ayşegül", "Kaya");

			#endregion

			#region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

			//void Sum(int number1, int number2, int number3)
			//{
			//	int result = number1 + number2 + number3;
			//  Console.WriteLine(result);
			//}

			//Sum(4, 5, 6);

			#endregion

			#region Geriye Değer Döndüren Metotlar

			//string CustomerName()
			//{
			//	return "Buse Yıldız";
			//}

			//CustomerName();

			//---------------------------------------------------------

			//string studentCard()
			//{
			//	string name = "Ali";
			//	string surname = "Kaya";

			//	return name + " " + surname;
			//}

			// Console.WriteLine(studentCard());


			#endregion

			#region Geriye Değer Döndüren String Parametreli Metotlar

			//string CountryCard (string countryName, string capital, string flagColor)
			//{
			//	string cardInfo = "Ülke: " + countryName + " - Başkent: "+ capital + " - Bayrak Rengi: " + flagColor;
			//	return cardInfo;
			//}

			//         string x, y, z;
			//         Console.Write("Ülke Adını Giriniz: ");
			//x = Console.ReadLine();

			//         Console.Write("Başkenti Giriniz: ");
			//y = Console.ReadLine();

			//Console.Write("Bayrak Rengi: ");
			//z = Console.ReadLine();

			//         Console.WriteLine(CountryCard(x,y,z));

			//         Console.WriteLine("Türkiye", "Ankara", "Kırmızı-Beyaz");

			#endregion

			#region Geriye Değer Döndüren İnt Parametreli Metotlar

			//int Sum(int number1, int number2)
			//{
			//	int result = number1 + number2;
			//	return result;
			//}

			// Console.WriteLine(Sum(23,42));

			#endregion

			#region Örnek Uygulama 

			//string ExamResult(string student, int exam1, int exam2, int exam3)
			//{
			//	int result = (exam1 + exam2 + exam3) / 3;

			//	if (result >= 50)
			//	{
			//		return student + "İsimli Öğrenci Sınavı Geçti" + "Ortalama: " + result;
			//  }
			//	else
			//	{
			//		return student + "İsimli Öğrenci Sınavı Geçemedi" + "Ortalama: " + result;
			//	}
			//}

			//Console.WriteLine(ExamResult("Ali",25,41,55));
			//Console.WriteLine(ExamResult("Ayşe", 25, 41, 85));

			#endregion




			Console.Read();

















		}
	}
}