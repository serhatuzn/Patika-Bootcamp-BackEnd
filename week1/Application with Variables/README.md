# User Purchase Registration Console Application / Kullanıcı Satın Alma Kayıt Konsol Uygulaması

This is a simple C# console application that collects user information such as T.C. Identity Number, name, surname, phone number, age, and calculates the total amount spent on two purchases. It also calculates the reward points based on the total amount spent.  

Bu, kullanıcının T.C. Kimlik Numarası, ad, soyad, telefon numarası, yaş gibi bilgilerini toplayan ve iki ürün satın alımına göre toplam harcamayı hesaplayan basit bir C# konsol uygulamasıdır. Ayrıca, toplam harcama üzerinden %10'luk bir ödül puanı hesaplar.

## Project Description / Proje Açıklaması

The application prompts the user to input their personal information (T.C. Identity Number, name, surname, phone number, age) and the prices of two products they purchased. It then calculates the total amount spent and computes a 10% reward point based on the total.

Uygulama, kullanıcının kişisel bilgilerini (T.C. Kimlik Numarası, ad, soyad, telefon numarası, yaş) ve satın aldığı iki ürünün fiyatını girmesini ister. Ardından toplam harcamayı hesaplar ve toplamın %10'u kadar bir ödül puanı hesaplar.

### Features / Özellikler:
- User input collection (T.C. ID, name, surname, phone number, age)  
  Kullanıcı bilgileri toplama (T.C. Kimlik, ad, soyad, telefon numarası, yaş)

- Calculation of total purchase amount from two product prices  
  İki ürün fiyatından toplam harcama hesaplama

- Calculation of reward points based on 10% of the total purchase  
  Toplam harcamanın %10'una göre ödül puanı hesaplama

- Output of user registration details and reward points  
  Kullanıcı kayıt bilgileri ve ödül puanlarının çıktısı

### Technologies Used / Kullanılan Teknolojiler

- C#
- .NET SDK

## How to Run the Project / Projeyi Çalıştırma

1. Clone the repository / Depoyu klonlayın:
    ```bash
    git clone https://github.com/serhatuzun/purchase-registration.git
    ```

2. Open the project in Visual Studio or any other C# IDE.  
   Projeyi Visual Studio veya başka bir C# geliştirme ortamında açın.

3. Run the application / Uygulamayı çalıştırın.

4. Enter the requested information in the console.  
   Konsola istenen bilgileri girin.

## Code Example / Kod Örneği

Here is a snippet of the C# code used in the project:  
Projedeki C# kodunun bir kısmı aşağıda verilmiştir:

```csharp
Console.WriteLine("Please enter the following information:");
Console.Write("T.C. Identity Number: ");
string TC = Console.ReadLine();

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Surname: ");
string surname = Console.ReadLine();

Console.Write("Phone Number: ");
string number = Console.ReadLine();

Console.Write("Age: ");
string age = Console.ReadLine();

Console.Write("Price of First Product: ");
int buy1 = int.Parse(Console.ReadLine());

Console.Write("Price of Second Product: ");
int buy2 = int.Parse(Console.ReadLine());

int total = buy1 + buy2;
double points = total * 0.10;

Console.WriteLine($"Total amount spent: {total} and earned 10% reward points: {points} TL.");
