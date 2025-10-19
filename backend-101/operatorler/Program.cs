// Atama ve İşlemli Atama
int a = 10;
int b = a; // Atama işlemi
b += 5; // İşlemli atama    
Console.WriteLine($"a: {a}, b: {b}"); // a: 10, b: 15 

// Mantıksal Operatörler && ve || 
bool x = true;
bool y = false; 
Console.WriteLine(x && y); // false
Console.WriteLine(x || y); // true  
Console.WriteLine(y && !y); // true

// Karşılaştırma Operatörleri ==, !=, <, >, <=, >=
int m = 5;
int n = 10;
Console.WriteLine(m == n); // false
Console.WriteLine(m != n); // true
Console.WriteLine(m < n); // true
Console.WriteLine(m > n); // false
Console.WriteLine(m <= n); // true
Console.WriteLine(m >= n); // false

// Aritmetik Operatörler +, -, *, /, %
int p = 20;
int q = 3;
Console.WriteLine(p + q); // 23
Console.WriteLine(p - q); // 17
Console.WriteLine(p * q); // 60
Console.WriteLine(p / q); // 6
Console.WriteLine(p % q); // 2