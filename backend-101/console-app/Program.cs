using System.Collections.Concurrent;

// Kodluyoruz Ödevleri

// Değişken Tanımlama ve Veri Tipleri
byte byteDeger = 255;                           // 0 ile 255 arasında değer alabilir 1 baytlık bir veri tipidir.
short shortDeger = 32767;                       // -32768 ile 32767 arasında değer alabilir 1 baytlık bir veri tipidir.    
ushort ushortDeger = 65535;                     // 0 ile 65535 arasında değer alabilir // 2 baytlık bir veri tipidir.
Int16 int16Deger = 32767;                       // -32768 ile 32767 arasında değer alabilir // 2 baytlık bir veri tipidir.
Int32 int32Deger = 2147483647;                  // -2147483648 ile 2147483647 arasında değer alabilir // 4 baytlık bir veri tipidir.
Int64 int64Deger = 2147483647;                  // -2147483648 ile 2147483647 arasında değer alabilir // 4 baytlık bir veri tipidir.
uint uintDeger = 4294967295;                    // 0 ile 4294967295 arasında değer alabilir // 4 baytlık bir veri tipidir.
long longDeger = 9223372036854775807;           // -9223372036854775808 ile 9223372036854775807 arasında değer alabilir // 8 baytlık bir veri tipidir.
ulong ulongDeger = 18446744073709551615;        // 0 ile 18446744073709551615 arasında değer alabilir // 8 baytlık bir veri tipidir.
float floatDeger = 3.402823e38f;                // 1.5 x 10^-45 ile 3.4 x 10^38 arasında değer alabilir // 4 baytlık bir veri tipidir.
double doubleDeger = 1.7976931348623157e308;    // 5.0 x 10^-324 ile 1.7 x 10^308 arasında değer alabilir // 8 baytlık bir veri tipidir.
decimal decimalDeger = 79228162514264337593543950335m; // 1.0 x 10^-28 ile 7.9 x 10^28 arasında değer alabilir // 16 baytlık bir veri tipidir.
char charDeger = 'A';                           // Tek bir karakteri tutabilir // 2 baytlık bir veri tipidir.
string stringDeger = "Merhaba Dünya";           // Birden fazla karakteri tutabilir // 2 baytlık bir veri tipidir.
bool boolDeger = true;                          // true veya false değerini tutabilir // 1 baytlık bir veri tipidir.
DateTime tarihDeger = DateTime.Now;             // Tarih ve saat bilgisini tutabilir // 8 baytlık bir veri tipidir.
object objectDeger = "Bu bir nesnedir";         // Herhangi bir veri tipini tutabilir // 4 baytlık bir veri tipidir.

Console.WriteLine("Byte Değer: " + byteDeger);
Console.WriteLine("Short Değer: " + shortDeger);
Console.WriteLine("UShort Değer: " + ushortDeger);
Console.WriteLine("Int16 Değer: " + int16Deger);
Console.WriteLine("Int32 Değer: " + int32Deger);
Console.WriteLine("Int64 Değer: " + int64Deger);
Console.WriteLine("UInt Değer: " + uintDeger);
Console.WriteLine("Long Değer: " + longDeger);
Console.WriteLine("ULong Değer: " + ulongDeger);
Console.WriteLine("Float Değer: " + floatDeger);
Console.WriteLine("Double Değer: " + doubleDeger);
Console.WriteLine("Decimal Değer: " + decimalDeger);
Console.WriteLine("Char Değer: " + charDeger);
Console.WriteLine("String Değer: " + stringDeger);
Console.WriteLine("Bool Değer: " + boolDeger);
Console.WriteLine("DateTime Değer: " + tarihDeger);
Console.WriteLine("Object Değer: " + objectDeger);
Console.WriteLine("Program sonlandı.");

string isim = "Ahmet";
string soyisim = "Yılmaz";
Console.WriteLine(isim + " " + soyisim);
Console.WriteLine($"İsim: {isim}, Soyisim: {soyisim}"); // String interpolation kullanımı

int sayi1 = 20;
int sayi2 = 10;
int toplam = sayi1 + sayi2;
int fark = sayi1 - sayi2;
int carpim = sayi1 * sayi2;
int bolum = sayi1 / sayi2;
Console.WriteLine("Toplam: " + toplam);
Console.WriteLine("Fark: " + fark);
Console.WriteLine("Çarpım: " + carpim);
Console.WriteLine("Bölüm: " + bolum);

bool bool1 = 13 > 10;
bool bool2 = 5 < 3;
Console.WriteLine("13 > 10: " + bool1);
Console.WriteLine("5 < 3: " + bool2);


int deger = 2;
deger = deger + 2; // deger artık 4 oldu
// int deger = 4; // Bu değişken zaten tanımlandığı için hata verecektir.

string str20 = "20";
int int20 = 20;
string yenideger = str20 + int20.ToString(); // str20 ve int20 string olarak birleştirildi
Console.WriteLine("Yeni Değer: " + yenideger); // 2020 olarak çıktısını verir
int converted = int20 + Convert.ToInt32(str20); // str20'yi int'e dönüştürerek toplama işlemi yapıldı
Console.WriteLine("Toplam Değer: " + converted); // 40 olarak çıktısını verir
int parsdeger = int20 + int.Parse(str20); // str20'yi int'e parse ederek toplama işlemi yapıldı
Console.WriteLine("Parse Değer: " + parsdeger); // 40 olarak çıktısını verir

string tarih = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine("Tarih: " + tarih); // Güncel tarihi gösterir
string tarih2 = DateTime.Now.ToString("MM/dd/yyyy");
Console.WriteLine("Tarih 2: " + tarih2); // Güncel tarihi farklı formatta gösterir
string tarih3 = DateTime.Now.ToString("yyyy-MM-dd");    
Console.WriteLine("Tarih 3: " + tarih3); // Güncel tarihi farklı formatta gösterir
string hour = DateTime.Now.ToString("HH:mm:ss");
Console.WriteLine("Saat: " + hour); // Güncel saati gösterir

// Kullanıcıdan veri alma ve koşullu ifadeler

Console.Write("Arabanız var mı? (true/false): ");
bool araba = Convert.ToBoolean(Console.ReadLine());
Console.Write("Ehliyetiniz var mı? (true/false): ");
bool ehliyet = Convert.ToBoolean(Console.ReadLine());


if (araba == true && ehliyet == true)
{
    Console.WriteLine("Araba kullanabilirsiniz.");
}
else if (araba == true || ehliyet == true)
{
    Console.WriteLine("Yakında araba kullanabilirsiniz.");
}
else
{
    Console.WriteLine("Arabanız ve ehliyetiniz yok, araba kullanamazsınız.");
}

Console.WriteLine("Program sonlandı.");
Console.ReadLine(); // Programın hemen kapanmaması için


Console.Write("Okula gidiyor musunuz? (true/false): ");
bool okulaGit = Convert.ToBoolean(Console.ReadLine());
Console.Write("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas < 18)
{
    Console.WriteLine("Yaşınız küçük, askere gitme.");
}
else
{
    if (okulaGit == true)
    {
        Console.WriteLine("Okulu bitir askere git.");
    }
    else
    {
        Console.WriteLine("Askere git.");
    }
}

Console.WriteLine("Program sonlandı.");
Console.ReadLine(); // Programın hemen kapanmaması için