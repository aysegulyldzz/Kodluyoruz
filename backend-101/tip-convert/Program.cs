// Implicit ve Explicit Dönüşümler
byte a = 10;
short b = a; // Implicit dönüşüm, byte -> short or short -> int ayrıca işlem gerektirmez, veri kaybı olmaz, çünkü short, byte'dan daha geniş bir veri tipidir
Console.WriteLine(b); // Çıktı: 10

int c = 1000;
byte d = (byte)c; // herhangi bir veri tipini byte'a dönüştürmek için explicit dönüşüm kullanılır int -> byte  
Console.WriteLine(d); // Çıktı: 232 (1000'in byte karşılığı)
// burada veri kaybı yaşanabilir, çünkü int, byte'dan daha geniş bir veri tipidir ve dönüştürmek için fonksiyon veya cast kullanılır

// System.Convert sınıfı ile dönüşüm
int e = 12345;
string f = Convert.ToString(e); // int -> string dönüşümü
Console.WriteLine(f); // Çıktı: "12345"

// .ToString() metodu ile dönüşüm
double g = 3.14;
string h = g.ToString(); // double -> string dönüşümü   
Console.WriteLine(h); // Çıktı: "3.14"

// Parse metodu ile dönüşüm
string i = "456";
int j = int.Parse(i); // string -> int dönüşümü
Console.WriteLine(j); // Çıktı: 456

// TryParse metodu ile dönüşüm
string t = "123";
try
{
    int s = int.Parse(t);
    Console.WriteLine(s); // Çıktı: 123
}
catch (FormatException ex)
{
    Console.WriteLine("Hata: " + ex.Message);
}

// TryParse metodu ile dönüşüm, hata kontrolü
string m = "abc";
try
{
    int n = int.Parse(m); // Hatalı dönüşüm, "abc" sayısal bir değer değil
}
catch (FormatException ex)
{
    Console.WriteLine("Hata: " + ex.Message); // Çıktı: Hata: Input string was not in a correct format.
}

// Try-Catch-Finally bloğu ile hata yönetimi hata türleri örnekleri
try
{
    int k = int.Parse("xyz"); // Hatalı dönüşüm, "xyz" sayısal bir değer değil
}
catch (FormatException ex)
{
    Console.WriteLine("Format Hatası: " + ex.Message); // Çıktı: Format Hatası: Input string was not in a correct format.
}
catch (OverflowException ex)
{
    Console.WriteLine("Taşma Hatası: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Genel Hata: " + ex.Message);
}
finally
{
    Console.WriteLine("Hata yönetimi bloğu tamamlandı.");
}