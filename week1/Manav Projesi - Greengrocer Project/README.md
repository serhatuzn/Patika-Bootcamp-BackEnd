# Manav / Greengrocer

**Greengrocer** uygulaması, kullanıcıların çeşitli meyve ve sebzeleri satın almasını sağlayan basit bir konsol uygulamasıdır. Bu uygulama, Switch-Case yapısını kullanarak meyve fiyatlarını belirler ve kullanıcıdan alınan girdi doğrultusunda işlem yapar.  

**Greengrocer** is a simple console application that allows users to purchase various fruits and vegetables. This application uses the Switch-Case structure to determine fruit prices and processes user input accordingly.

## Özellikler / Features

- Kullanıcıdan hangi meyveyi satın almak istediğini sorar.  
- Asks the user which fruit they want to buy.
  
- Seçilen meyvenin fiyatını ekrana yazdırır.  
- Displays the price of the selected fruit on the screen.

- Büyük/küçük harf duyarlılığını ortadan kaldırmak için kullanıcı girdisi normalleştirilmiştir.  
- User input is normalized to eliminate case sensitivity.

## Kullanılan Diller ve Teknolojiler / Languages and Technologies Used

- C#

## Kurulum / Installation

1. Uygulamayı indirin veya klonlayın.  
   Download or clone the application.
  
2. Visual Studio veya uygun bir C# IDE'si ile projeyi açın.  
   Open the project with Visual Studio or a suitable C# IDE.
  
3. Programı çalıştırın.  
   Run the program.

## Kullanım / Usage

Uygulama çalıştırıldığında, kullanıcıdan hangi meyveyi satın almak istediği sorulur. Kullanıcıdan alınan girdiye göre, meyvenin fiyatı ekrana yazdırılır. Aşağıda bir örnek çıktı verilmiştir:  

When the application is run, it asks the user which fruit they want to buy. Depending on the input received from the user, the price of the fruit is displayed on the screen. Below is an example output:


## Kullanıcı Girdisinin Normalleştirilmesi / Normalization of User Input

Kullanıcıdan alınan meyve ismi, `ToUpper` veya `ToLower` metotları ile normalleştirilmiştir. Bu sayede, büyük veya küçük harf kullanımı fark etmeksizin uygulama çalışır.  

The fruit name received from the user is normalized using the `ToUpper` or `ToLower` methods. This allows the application to work regardless of the use of uppercase or lowercase letters.

