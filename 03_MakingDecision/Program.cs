using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region If Else

			//         Console.Write("Lütfen Şifreyi Griniz: ");
			//string password = Console.ReadLine();

			//if (password == "abcd" )
			//{
			//             Console.WriteLine("Şifre Doğru");
			//         }
			//else
			//{
			//             Console.WriteLine("Şifre Yanlış");
			//         }


			//string capital, country;
			//Console.Write("Başkenti Giriniz: ");
			//capital = Console.ReadLine();
			//Console.Write("Ülkeyi Giriniz: ");
			//country = Console.ReadLine();

			//if (capital == "ankara" & country == "türkiye")
			//{
			//    Console.WriteLine("Veriler Doğrulandı");
			//}
			//else
			//{
			//    Console.WriteLine("Verdiğiniz Bilgiler Yanlış");
			//}


			//int number;

			//Console.Write("Bir Sayı Giriniz: ");
			//number = int.Parse(Console.ReadLine());

			//if (number == 5)
			//{
			//    Console.WriteLine("Sayı Doğru");
			//}
			//else
			//{
			//    Console.WriteLine("Sayı Yanlış");
			//}


			//int examp1, examp2, examp3, avarage;
			//string result = "";

			//Console.Write("Sınav 1: ");
			//examp1 = int.Parse(Console.ReadLine());

			//Console.Write("Sınav 2: ");
			//examp2 = int.Parse(Console.ReadLine());

			//Console.Write("Sınav 3: ");
			//examp3 = int.Parse(Console.ReadLine());

			//avarage = (examp1 + examp2 + examp3) / 3;

			//Console.WriteLine("Sınav Ortalaması: " + avarage);

			//if (avarage > 0 & avarage <= 50)
			//{
			//	result = "Sınav Ortalaması: Kötü";
			//}
			//if (avarage > 50 & avarage <= 70)
			//{
			//	result = "Sınav Ortalaması: Orta";
			//}
			//if (avarage > 70 & avarage <= 84)
			//{
			//	result = "Sınav Ortalaması: İyi";
			//}
			//if (avarage > 84 & avarage <= 100)
			//{
			//	result = "Sınav Ortalaması: Çok iyi";
			//}

			//Console.WriteLine(result);


			//string city;
			//         Console.Write("Lütfen Şehir Girişi Yapınız: ");
			//city = Console.ReadLine();

			//if (city == "adana" | city == "" | city == "bursa"  | city == "trabzon")
			//{
			//             Console.WriteLine("Şehir Mevcut");
			//         }
			//else
			//{
			//             Console.WriteLine("Şehir Mevcut Değil");
			//         }


			//Console.Write("Kullanıcı Adınızı Giriniz: ");
			//string username = Console.ReadLine();

			//if (username != "kadir")
			//{
			//    Console.WriteLine("Kullanıcı Doğru Değil");
			//}
			//else
			//{
			//    Console.WriteLine("Giriş Başarılı");
			//}

			#endregion


			#region Mod İşlemleri

			//int number;
			//number = 26;
			//int result = number % 5;
			//Console.WriteLine(result);


			//Console.Write("Lütfen 1.Sayıyı Giriniz: ");
			//int number1 = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen 2.Sayıyı Giriniz: ");
			//int number2 = int.Parse(Console.ReadLine());

			//int result = number1 % number2;

			//Console.WriteLine("1.Sayının 2.Sayıya Bölümünden Kalan: "+result);

			//Console.Write("Sayı Giriniz: ");
			//int number = int.Parse(Console.ReadLine());

			//if (number %2 == 0)
			//{
			//    Console.WriteLine("Sayı Çifttir");
			//}
			//else
			//{
			//    Console.WriteLine("Sayı Tektir");
			//}

			#endregion


			#region Char Değişlenler İle Karar Yapıları

			//char team;
			//Console.Write("Lütfen Takım Sembolünü Giriniz: ");
			//team = char.Parse(Console.ReadLine());

			//if (team == 'f' | team == 'F')
			//{
			//    Console.WriteLine("Fenerbaçe");
			//}
			//if (team == 'b' | team == 'B')
			//{
			//    Console.WriteLine("Beşiktaş");
			//}

			#endregion


			#region Örnek Proje Uygulaması

			//Console.WriteLine("----- Menü Seçim Listesi -----");
			//Console.WriteLine();
			//Console.WriteLine("1 - Tatlılar");
			//Console.WriteLine("2 - Yemekler");
			//Console.WriteLine("3 - İçecekler");
			//Console.WriteLine();


			//string food;
			//Console.Write("Lütfen İstedğiniz Menüyü Seçiniz: ");
			//food = (Console.ReadLine());
			//         Console.WriteLine();

			//         if (food == "1")
			//{
			//	Console.WriteLine("----------Tatlı Menüsü----------");
			//             Console.WriteLine("1- Baklava");
			//             Console.WriteLine("2- Künefe");
			//             Console.WriteLine("3- Sütlaç");
			//         }

			//if (food == "2")
			//{
			//	Console.WriteLine("----------Yemek Menüsü----------");
			//	Console.WriteLine("1- Fasulye");
			//	Console.WriteLine("2- Pilav");
			//	Console.WriteLine("3- Musakka");
			//}

			//if (food == "3")
			//{
			//	Console.WriteLine("----------İçecek Menüsü----------");
			//	Console.WriteLine("1- Pepsi");
			//	Console.WriteLine("2- Fanta");
			//	Console.WriteLine("3- Niğde Gazoz" +
			//		"");
			//}

			#endregion


			#region Switch Case

			//Console.Write
			//	("Lütfen Ay Girişi Yapınız: ");
			//int monthNumber = int.Parse(Console.ReadLine());

			//switch (monthNumber)
			//{
			//	case 1:
			//		Console.WriteLine("Ocak"); break;
			//	case 2:
			//                 Console.WriteLine("Şubat"); break;
			//	case 3:
			//		Console.WriteLine("Mart"); break;
			//	case 4:
			//		Console.WriteLine("Nisan"); break;
			//	case 5:
			//		Console.WriteLine("Mayıs"); break;
			//	case 6:
			//		Console.WriteLine("Haziran"); break;
			//	case 7:
			//		Console.WriteLine("Temmuz"); break;
			//	case 8:
			//		Console.WriteLine("Ağustos"); break;
			//	case 9:
			//		Console.WriteLine("Eylül"); break;
			//	case 10:
			//		Console.WriteLine("ŞEkimubat"); break;
			//	case 11:
			//		Console.WriteLine("Kasım"); break;
			//	case 12:
			//		Console.WriteLine("Aralık"); break;				

			//	default:
			//                 Console.WriteLine("Lütfen 1-12 Arasında Sayı Giriniz");
			//                 break;
			//}


			#endregion


			#region Switch Case Hesap Makinesi Yapımı

			//int number1,number2,result;
			//char symbol;

   //         Console.Write("1.Sayıyı Giriniz: ");
			//number1 = int.Parse(Console.ReadLine());

			//Console.Write("2.Sayıyı Giriniz: ");
			//number2 = int.Parse(Console.ReadLine());

			//Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz: ");
			//symbol = char.Parse(Console.ReadLine());

			//switch (symbol)
			//{
			//	case '+':
   //                 result = number1 + number2;
   //                 Console.WriteLine("Toplam :"+ result);
   //                 break;
			//	case '-':
			//		result = number1 - number2;
   //                 Console.WriteLine("Kalan :" + result);
   //                 break;
			//	case '*':
			//		result = number1 * number2;
   //                 Console.WriteLine("Çarpan: "+ result);
   //                 break;
			//	case '/':
			//		result = number1 / number2;
   //                 Console.WriteLine("Bölen: "+ result);
   //                 break;

   //             default:
			//		break;
			//}

			#endregion




			Console.Read();







		}
	}
}
