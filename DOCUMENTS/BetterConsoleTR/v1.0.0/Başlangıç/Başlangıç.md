# BetterConsoleTR ile Başlangıç

BetterConsoleTR'ye hoş geldiniz! Bu kılavuz, kütüphaneyi hızlı bir şekilde kullanmaya başlamanıza ve temel özelliklerini keşfetmenize yardımcı olacaktır.

## Ön Koşullar

*   .NET Framework 4.8 veya üzeri

## Kurulum

1.  **DLL Dosyasını İndirin:** `BetterConsolePlugin.dll` dosyasını [Releases](LINK_TO_RELEASES) sayfasından indirin.
2.  **Referans Ekleme:** DLL dosyasını .NET projenize referans olarak ekleyin.
3.  **Namespace'i İçe Aktarın:** Kod dosyanıza aşağıdaki satırı ekleyin:

    ```csharp
    using BetterConsolePlugin;
    ```

## Temel Kullanım

### Renkli Metin Yazdırma

```csharp
using BetterConsolePlugin;
using System;

GelismisKonsol konsol = new GelismisKonsol();
konsol.Yaz("Merhaba, Dünya!", Olay.Bilgi, ConsoleColor.Yesil);
```

Bu kod parçacığı, "Merhaba, Dünya!" metnini konsola yeşil renkte, "BILGI" olay ayracı ile yazdıracaktır.

### Tablo Oluşturma

```csharp
using BetterConsolePlugin;

Tablo tablo = new Tablo();
tablo.BaslikEkle("Ad", "Yaş", "Şehir");
tablo.SatirEkle("Ahmet", 30, "İstanbul");
tablo.SatirEkle("Ayşe", 25, "Ankara");
tablo.Yazdir();
```

Bu kod, üç sütunlu ve iki satırlı basit bir tablo oluşturacak ve görüntüleyecektir.

### Menü Oluşturma

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

List<MenuOgesi> menuOgeleri = new List<MenuOgesi>()
{
    new MenuOgesi("Oyunu Başlat", () => Console.WriteLine("Oyun başlatılıyor..."), "Yeni bir oyun başlatır"),
    new MenuOgesi("Çıkış", () => Environment.Exit(0), "Uygulamadan çıkar")
};

MenuOlustur menu = new MenuOlustur(menuOgeleri);
menu.MenuOlustur();
```

Bu kod, iki seçenekli temel bir menü oluşturacaktır: "Oyunu Başlat" ve "Çıkış".

## Diğer Özellikleri Keşfetme

BetterConsoleTR, konsol uygulamalarınızı geliştirmek için daha birçok özellik sunar. Daha fazla bilgi edinmek için her sınıfın dökümanasyonunu inceleyin:

*   [GelismisKonsol](GelismisKonsol.md)
*   [Olay](Olay.md)
*   [AyracTuru](AyracTuru.md)
*   [Tablo](Tablo.md)
*   [MenuOgesi](MenuOgesi.md)
*   [MenuOlustur](MenuOlustur)

## Katkıda Bulunma

BetterConsoleTR'ye katkıda bulunmak isterseniz, [CONTRIBUTING.md](LINK_TO_CONTRIBUTING_DOC) dosyasını okuyun.

BetterConsoleTR'yi kullandığınız için teşekkürler!
