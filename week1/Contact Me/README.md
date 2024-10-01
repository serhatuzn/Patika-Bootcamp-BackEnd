# Patika-Bootcamp-Backend

[TR]Merhaba

[EN]Hello

[TR] Bu projede, Patika+ Bootcamp'te bulunma nedenimi bir C# konsol uygulaması ile ifade eden basit bir program oluşturdum.

[EN] In this project, I created a simple C# console application that expresses why I am attending the Patika+ Bootcamp.

## Proje Açıklaması        //        Project Description

Bu uygulama, bir C# konsol programı olup, kullanıcıya adımı ve Patika'nın sağladığı eğitim ve network sayesinde hedeflerimi yazdırıyor.

This application is a C# console program that prints my name and my goals, which I aim to achieve through the education and network provided by Patika.

### Kullanılan Teknolojiler  //  Technologies Used

- C#
- .NET SDK

## Kod  // Code

Aşağıda, uygulamada kullanılan C# kodu bulunmaktadır:

Below is the C# code used in the application:

```csharp
using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serhat Uzun\nPatika'nın sağladığı eğitim ve network sayesinde kendimi daha çok geliştirip sektöre patika eşliğinde bilgili ve tecrübeli şekilde girmek istiyorum.");
        }
    }
}
