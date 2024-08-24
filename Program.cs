namespace HomeWork_18_08_2024_WithProgramMain;

class Program
{
    static void Main(string[] args)
    {
        #region 1) int tipinde değişkenler

            //int number1 = 20;
            //int number2 = 15;

            //int total = number1 + number2;
            //Console.WriteLine("Toplam Sayı: " + total);
            
        #endregion
        #region 2) double tipinde değişkenler

            //double number = 5.5;

            //double karesi = number * number;

            //Console.WriteLine("Karesi: " + karesi);
            
        #endregion
        #region 3) string
            //string isim = "Furkan";

            //int age = 26;

            //Console.WriteLine("Benim adım " + isim + " ve ben " + age + " yaşındayım.");

        #endregion
        #region 4) char ASCII değeri
            //char harf = 'G';
            //int asciiDeger = (int)harf;
            //Console.WriteLine("Harf: " + harf);
            //Console.WriteLine("ASCII Değeri" + " " + asciiDeger);
        #endregion
        #region 5) bool tipinde değerler
            //bool case1 = true;
            //bool case2 = false;
            //Console.WriteLine("İlk case: " + case1);
            //Console.WriteLine("İkinci case: " + case2);
        #endregion
        #region 6) byte tipinde değişkenler
            //byte number =  255;
            //int intNumber = number;

            //Console.WriteLine("Byte: " + number);
            //Console.WriteLine("Integer: " + intNumber);
            
        #endregion
        #region 7) byte casting 
            //int hataliSayi = 12342156789;
            //byte hataliSayi1 = (byte)hataliSayi;
            //Console.WriteLine(hataliSayi1);
            //Not: Casting durumu oluşmuştur. Byte değerinden fazla
            //bir sayı çıktı alınmaya çalışılmıştır.
        #endregion
        #region 8) double 3.14
            //double sayiPi = 3.14;
            //int sayiInt = (int)sayiPi;
            //Console.WriteLine("Double sayı: " + sayiPi);
            //Console.WriteLine("Integer: " + sayiInt);
            
        #endregion
        #region 9) string parse
            //string sayi = "36";
            //int sayiInt = int.Parse(sayi);
            //Console.WriteLine("String: " + sayi);
            //Console.WriteLine("Integer " + sayiInt);

            // NOT: Geçersiz bir sayı veya expression olsaydı TryParse metodu ile kullanılıp 
            //hata önlenebilirdi. 
        #endregion
        #region 10) int ortalama hesap
        //int number1 = 5;

        //int number2 = 10;

        //int number3 = 15;

        //double numberOrtalama = (number1 + number2 + number3) / 3;

        //Console.WriteLine("Bu sayıların ortalaması: " + numberOrtalama);
            
        #endregion
        #region 11) decimal

            //decimal ilkPara = 7.75m;
            //decimal ikinciPara = 3.55m;

            //decimal toplamPara = ilkPara + ikinciPara;

            //Console.WriteLine("Toplam Para: " + toplamPara);
            
        #endregion
        #region 12) float 
            //float number1 = 1.23f;
            //double number2 = (double)number1;

            //Console.WriteLine("Float Değer: " + number1);
            //Console.WriteLine("Double Değer: " + number2);
        #endregion
        #region 13) long / int
            //long number1 = 5783867687234234;
            //int numberInt = (int)number1;

            //Console.WriteLine("Long Değer: " + number1);
            //Console.WriteLine("Int Değer: " + numberInt);

        #endregion
        #region 14) string ad soyad
            //string isim = "Furkan";
            //string soyIsim = "Demir";

            //string isimSoyIsim = isim + " " + soyIsim;

            //Console.WriteLine("İsim Soy İsim: " + isimSoyIsim);
        #endregion
        #region 15) string bool

            //string degisken = "True";

            //bool boolean = bool.Parse(degisken);
            
            //Console.WriteLine("Bool Değer: " + boolean);
            
        #endregion
        #region 16) double float?
            //double piNumber = 3.14159;
            //float piFloat = (float)piNumber;

            //Console.WriteLine("Double Değer: " + piNumber);
            //Console.WriteLine("Float Değer: " + piFloat);
        #endregion
        #region 17) sizeof

            //byte byteNumber = 36;
            //short shortNumber = 36;
            //int intNumber = 36;
            //long longNumber = 36;

            //Console.WriteLine("BYTE kapladığı alan: " + sizeof(byte) + " byte");
            //Console.WriteLine("SHORT kapladığı alan: " + sizeof(short) + " short");
            //Console.WriteLine("INT kapladığı alan: " + sizeof(int) + " int");
            //Console.WriteLine("LONG kapladığı alan: " + sizeof(long) + " long");



            //SIZEOF KULLANIMI NOTLAR (https://learn.microsoft.com/tr-tr/dotnet/csharp/language-reference/operators/sizeof)
            //Console.WriteLine(sizeof(byte));  // output: 1
            //Console.WriteLine(sizeof(double));  // output: 8
            
        #endregion
        #region 18) string karakter sayısı
        
            string cumle = "Karakter sayısını .Length komutu ile bulabiliriz!";
            int karakterSayisi = cumle.Length;

            Console.WriteLine("Bu cümledeki toplam karakter sayısı " + karakterSayisi);

            //NOTLAR
            //.Length özelliği, toplam karakter sayısını çıktı olarak verir. String'in uzunluğu ölçülür.
            
        #endregion
    }
}
