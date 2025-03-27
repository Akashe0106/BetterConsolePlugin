# MenuOlustur (MenuCreate) Sınıfı: Konsol Uygulamalarınız İçin Etkileyici ve Kullanıcı Dostu Menüler Oluşturun

## Açıklama

`MenuOlustur` (İngilizce'de `MenuCreate`) sınıfı, .NET konsol uygulamalarınızda etkileşimli ve kullanımı kolay menüler oluşturmanızı sağlayan güçlü bir araçtır. Bu sınıf, menü öğelerini düzenlemenizi, menü başlıklarını ayarlamanızı, menü öğelerinin görünümünü özelleştirmenizi ve kullanıcı girişlerini kolayca yönetmenizi sağlayarak konsol uygulamalarınızın kullanıcı deneyimini önemli ölçüde geliştirir. `MenuOlustur` sınıfı, sadece bir menü oluşturucu değil, aynı zamanda kullanıcılarınızla etkileşim kurmanın ve uygulamalarınızın işlevselliğini kolayca erişilebilir hale getirmenin bir yoludur.

## Neden MenuOlustur Sınıfını Kullanmalısınız?

*   **Gelişmiş Kullanıcı Deneyimi:** Konsol uygulamalarınıza sezgisel ve kullanımı kolay menüler ekleyerek kullanıcı deneyimini en üst düzeye çıkarın. Kullanıcılarınız, karmaşık komutlar veya ezberlenmesi zor kısayollar yerine, basit menü seçenekleriyle uygulamalarınızla etkileşim kurabilir.
*   **Kolay Menü Yönetimi:** Menü öğelerinizi kolayca oluşturun, düzenleyin ve yönetin. Menülerinizi dinamik olarak değiştirebilir, yeni öğeler ekleyebilir, mevcut öğeleri güncelleyebilir veya silebilirsiniz.
*   **Özelleştirilebilir Görünüm:** Menü öğelerinin renklerini, yazı tiplerini, simgelerini ve diğer görsel özelliklerini özelleştirerek menülerinizi uygulamanızın tasarımına ve marka kimliğine uygun hale getirin.
*   **Esnek Eylem Yönetimi:** Menü öğeleri seçildiğinde gerçekleştirilecek eylemleri kolayca tanımlayın ve yönetin. Menü öğelerinize farklı türlerde eylemler atayabilir, kullanıcı girişlerini alabilir ve uygulamanızın davranışını dinamik olarak değiştirebilirsiniz.
*   **Hızlı Entegrasyon:** `MenuOlustur` sınıfını mevcut .NET projelerinize kolayca entegre edin ve kısa sürede etkileşimli menüler oluşturmaya başlayın.

## Özellikler

*   **Ogeler (Items):** Menüde görüntülenecek `MenuOgesi` nesnelerinin listesini temsil eder.
    *   Tür: `List<MenuOgesi>`
*   **SecimRengi (SelectionColor):** Seçili menü öğesinin rengini belirler.
    *   Tür: `ConsoleColor?` (nullable ConsoleColor)
    *   Varsayılan Değer: `ConsoleColor.Yellow`
*   **NormalOgeRengi (NormalItemColor):** Seçili olmayan menü öğelerinin rengini belirler.
    *   Tür: `ConsoleColor?` (nullable ConsoleColor)
    *   Varsayılan Değer: `ConsoleColor.White`

## Metotlar

### MenuOlustur (Create) Metodu: Menünüzü Oluşturun ve Görüntüleyin

Menüyü oluşturur, kullanıcıya seçenekleri sunar ve seçilen seçeneğe göre eylemi gerçekleştirir.

```csharp
public void MenuOlustur()
```

*   **Parametreler:** Yok
*   **İstisnalar:** Yok

## Yapıcı Metot (Constructor): Menünüzün Temelini Atın

### MenuOlustur (MenuCreate) Yapıcı Metodu: Yeni Bir Menü Oluşturun

Yeni bir `MenuOlustur` sınıfı örneği oluşturarak, etkileşimli konsol menülerinizin temelini atın. Bu yapıcı metot, menü öğelerinizi, seçili öğenin rengini ve normal öğelerin rengini tanımlamanıza olanak tanır.

```csharp
public MenuOlustur(List<MenuOgesi> ogeler, ConsoleColor? secimRengi = null, ConsoleColor? normalOgeRengi = null)
```

*   **Parametreler:**
    *   `ogeler` (List<MenuOgesi>): Menüde görüntülenecek `MenuOgesi` nesnelerinin listesini temsil eder. Bu parametre zorunludur.
    *   `secimRengi` (ConsoleColor?, isteğe bağlı): Seçili menü öğesinin rengini belirler. Bu parametre `null` olabilir. Varsayılan değeri `ConsoleColor.Yellow`'dur.
    *   `normalOgeRengi` (ConsoleColor?, isteğe bağlı): Seçili olmayan menü öğelerinin rengini belirler. Bu parametre `null` olabilir. Varsayılan değeri `ConsoleColor.White`'dır.

## Kullanım

### 1. Örnek: Temel Menü Oluşturma

Bu örnek, en temel menü oluşturma senaryosunu göstermektedir. Menü öğeleri tanımlanır, bir listeye eklenir ve ardından `MenuOlustur` sınıfı kullanılarak menü oluşturulur ve görüntülenir.

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// Menü öğelerini tanımlayın
List<MenuOgesi> ogeler = new List<MenuOgesi>()
{
    new MenuOgesi("Oyunu Başlat", () => Console.WriteLine("Oyun başlatılıyor..."), "Yeni bir oyun başlatır"),
    new MenuOgesi("Ayarları Yap", () => Console.WriteLine("Ayarlar menüsü açılıyor..."), "Oyun ayarlarını düzenlemenizi sağlar"),
    new MenuOgesi("Çıkış", () => Environment.Exit(0), "Uygulamadan çıkar")
};

// Menüyü oluşturun ve görüntüleyin
MenuOlustur menu = new MenuOlustur(ogeler);
menu.MenuOlustur();
```

### 2. Örnek: Özelleştirilmiş Renklere Sahip Menü Oluşturma

Bu örnek, menü öğelerinin renklerini özelleştirerek menünüzün görünümünü nasıl iyileştirebileceğinizi göstermektedir. Seçili öğe için farklı bir renk ve normal öğeler için farklı bir renk belirleyebilirsiniz.

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// Menü öğelerini tanımlayın (aynı öğeler kullanılabilir)
List<MenuOgesi> ogeler = new List<MenuOgesi>()
{
    new MenuOgesi("Oyunu Başlat", () => Console.WriteLine("Oyun başlatılıyor..."), "Yeni bir oyun başlatır"),
    new MenuOgesi("Ayarları Yap", () => Console.WriteLine("Ayarlar menüsü açılıyor..."), "Oyun ayarlarını düzenlemenizi sağlar"),
    new MenuOgesi("Çıkış", () => Environment.Exit(0), "Uygulamadan çıkar")
};

// Menüyü özelleştirilmiş renklerle oluşturun ve görüntüleyin
MenuOlustur renkliMenu = new MenuOlustur(ogeler, ConsoleColor.Green, ConsoleColor.Gray);
renkliMenu.MenuOlustur();
```

### 3. Örnek: Açıklamasız Menü Öğeleriyle Menü Oluşturma

Bu örnek, menü öğelerinin açıklamalarını kullanmadan nasıl menü oluşturabileceğinizi göstermektedir. Açıklama, menü öğesinin ne işe yaradığını veya ne yaptığını belirtmek için kullanılan isteğe bağlı bir özelliktir.

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// Açıklamasız menü öğeleri içeren bir liste tanımlayın
List<MenuOgesi> basitOgeler = new List<MenuOgesi>()
{
    new MenuOgesi("Seçenek 1", () => { Console.WriteLine("Seçenek 1 çalıştı!"); }),
    new MenuOgesi("Seçenek 2", () => { Console.WriteLine("Seçenek 2 çalıştı!"); }),
    new MenuOgesi("Çıkış", () => { Environment.Exit(0); })
};

// Bu öğelerle bir menü oluşturun ve görüntüleyin
MenuOlustur basitMenu = new MenuOlustur(basitOgeler);
basitMenu.MenuOlustur();
```

### 4. Örnek: Gelişmiş Menü Öğeleriyle Menü Oluşturma

```csharp
using BetterConsolePlugin;
using System;
using System.Collections.Generic;

// 1. Adım: Menü öğelerinizi oluşturun
MenuOgesi menuOgesi1 = new MenuOgesi(
    "Oyunu Başlat", // Menü öğesinin metni
    () => Console.WriteLine("Oyun başlatılıyor..."), // Menü öğesi seçildiğinde çalıştırılacak eylem
    "Yeni bir oyun başlatır" // Menü öğesinin açıklaması
);

MenuOgesi menuOgesi2 = new MenuOgesi(
    "Ayarları Yap", // Menü öğesinin metni
    () => Console.WriteLine("Ayarlar menüsü açılıyor..."), // Menü öğesi seçildiğinde çalıştırılacak eylem
    "Oyun ayarlarını düzenlemenizi sağlar" // Menü öğesinin açıklaması
);

MenuOgesi menuOgesi3 = new MenuOgesi(
    "Çıkış", // Menü öğesinin metni
    () => Environment.Exit(0), // Menü öğesi seçildiğinde çalıştırılacak eylem
    "Uygulamadan çıkar" // Menü öğesinin açıklaması
);

// 2. Adım: Menü öğelerinizi bir listeye ekleyin
List<MenuOgesi> menuOgeleri = new List<MenuOgesi>()
{
    menuOgesi1,
    menuOgesi2,
    menuOgesi3
};

// 3. Adım: MenuOlustur sınıfını kullanarak menünüzü oluşturun ve görüntüleyin
MenuOlustur menu = new MenuOlustur(
    menuOgeleri, // Menü öğeleri listesi
    ConsoleColor.Green, // Seçili öğenin rengi
    ConsoleColor.Gray // Normal öğelerin rengi
);
menu.MenuOlustur();
```

*   **Ek Notlar:**

    *   `MenuOlustur` sınıfını kullanarak, farklı türlerde menüler oluşturabilirsiniz (örneğin, dikey menüler, yatay menüler, alt menüler vb.).
    *   Menü öğelerinizin renklerini, yazı tiplerini ve simgelerini özelleştirerek menülerinizi daha çekici hale getirebilirsiniz.
    *   Kullanıcılarınızın tercihlerine göre menülerinizi dinamik olarak değiştirebilirsiniz (örneğin, dil seçeneğine göre).
    *   Menülerinizi klavye kısayollarıyla (örneğin, yukarı ok, aşağı ok, Enter) daha hızlı ve kolay bir şekilde erişilebilir hale getirebilirsiniz.
    *   Menülerinizi fare tıklamalarıyla da kontrol edilebilir hale getirebilirsiniz (konsol uygulaması destekliyorsa).
    *   Menülerinizi farklı platformlarda (örneğin, Windows, Linux, macOS) tutarlı bir şekilde görüntüleyebilirsiniz.
