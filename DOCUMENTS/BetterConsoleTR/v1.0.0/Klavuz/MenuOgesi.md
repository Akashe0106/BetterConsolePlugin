# MenuOgesi Sınıfı: Etkileşimli Konsol Menülerinin Temel Taşı

## Açıklama

`MenuOgesi` (İngilizce'de `MenuItem`) sınıfı, .NET konsol uygulamalarınızda kullanıcı dostu ve etkileşimli menüler oluşturmanızı sağlayan temel bir yapı taşıdır. Bu sınıf, her bir menü öğesinin benzersiz özelliklerini tanımlamanıza olanak tanır: Kullanıcıya gösterilecek metin, menü öğesinin amacını açıklayan ayrıntılı bir açıklama ve menü öğesi seçildiğinde gerçekleştirilecek güçlü bir eylem. `MenuOgesi` sınıfını kullanarak, kullanıcılarınızın uygulamalarınızla kolayca etkileşim kurmasını sağlayabilir, karmaşık işlemleri basitleştirebilir ve konsol uygulamalarınıza modern bir dokunuş katabilirsiniz.

## Neden MenuOgesi Sınıfını Kullanmalısınız?

*   **Gelişmiş Kullanıcı Deneyimi:** Konsol uygulamalarınıza sezgisel ve kolayca gezilebilir menüler ekleyerek kullanıcı deneyimini önemli ölçüde iyileştirin. Kullanıcılarınız, karmaşık komutlar veya hatırlaması zor kısayollar yerine, basit menü seçenekleriyle uygulamalarınızla etkileşim kurabilir.
*   **Artırılmış Etkileşim:** Kullanıcılarınızın uygulamalarınızla doğrudan etkileşim kurmasını sağlayarak, uygulamalarınızın daha ilgi çekici ve kullanıcı odaklı olmasını sağlayın. Menüler aracılığıyla kullanıcılarınız, istedikleri işlemleri kolayca seçebilir ve uygulamalarınızın sunduğu tüm özelliklerden faydalanabilir.
*   **Basitleştirilmiş İş Akışları:** Karmaşık işlemleri menüler aracılığıyla basitleştirerek, kullanıcılarınızın iş akışını kolaylaştırın. Menüler, karmaşık komut satırı araçlarının kullanımını basitleştirerek, kullanıcılarınızın daha az çaba ile daha fazla iş yapmasını sağlar.
*   **Esneklik ve Özelleştirme:** Menü öğelerinin metinlerini, açıklamalarını ve eylemlerini özelleştirerek menülerinizi uygulamanızın özel ihtiyaçlarına göre uyarlayın. Bu sayede, her bir menü öğesini uygulamanızın işlevselliği ve tasarımına mükemmel şekilde entegre edebilirsiniz.
*   **Mükemmel Organizasyon:** Uygulamanızın işlevlerini düzenli bir şekilde menüler altında gruplandırarak, kullanıcılarınıza kolay bir genel bakış sunun. Bu sayede, kullanıcılarınız uygulamalarınızın sunduğu tüm özelliklere hızlıca erişebilir ve aradıkları işlemleri kolayca bulabilir.

## Özellikler

*   **Metin (Text):** Menü öğesinin konsolda kullanıcıya gösterilecek metnini temsil eden, açıklayıcı ve anlamlı bir `string` değeridir.
    *   Tür: `string`
*   **Aciklama (Description):** Menü öğesinin ne işe yaradığını, hangi işlemi gerçekleştireceğini veya hangi sonuçları üreteceğini açıklayan, isteğe bağlı ve bilgilendirici bir `string` değeridir.
    *   Tür: `string?` (nullable string)
*   **Eylem (Action):** Menü öğesi seçildiğinde sihirli bir şekilde çalıştırılacak eylemi temsil eden, güçlü ve esnek bir `Action` delegesidir. Bu delege, herhangi bir parametre almayan ve herhangi bir değer döndürmeyen bir metodu temsil eder.
    *   Tür: `Action`

## Yapıcı Metot (Constructor): Menü Öğelerinizi Yaratın

### MenuOgesi (MenuItem) Yapıcı Metodu: Yeni Bir Menü Öğesine Hayat Verin

Yeni bir `MenuOgesi` sınıfı örneği oluşturarak, etkileşimli konsol menülerinizin temelini atın. Bu yapıcı metot, menü öğenizin metnini, eylemini ve isteğe bağlı açıklamasını tanımlamanıza olanak tanır.

```csharp
public MenuOgesi(string metin, Action eylem, string aciklama = null)
```

*   **Parametreler:**
    *   `metin` (string): Menü öğesinin konsolda görüntülenecek metnini temsil eden, kullanıcı dostu ve anlaşılır bir `string` değeridir. Bu parametre zorunludur.
    *   `eylem` (Action): Menü öğesi seçildiğinde gerçekleştirilecek eylemi temsil eden, güçlü ve esnek bir `Action` delegesidir. Bu parametre zorunludur.
    *   `aciklama` (string?, isteğe bağlı): Menü öğesinin ne işe yaradığını, hangi işlemi gerçekleştireceğini veya hangi sonuçları üreteceğini açıklayan, isteğe bağlı ve bilgilendirici bir `string` değeridir. Bu parametre `null` olabilir. Varsayılan değeri `null`'dır.

## Kullanım

Daha farklı kullanımlarını [MenuOlustur.md](MenuOlustur.md)'de bulabilirsiniz.
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
MenuOlustur menu = new MenuOlustur(menuOgeleri);
menu.MenuOlustur();
```

*   **Ek Notlar:**

    *   `MenuOgesi` sınıfını kullanarak, farklı türlerde eylemler gerçekleştiren menü öğeleri oluşturabilirsiniz (örneğin, dosya açma, kaydetme, yazdırma, ağ bağlantısı kurma vb.).
    *   Menü öğelerinizin açıklamalarını kullanarak, kullanıcılarınıza menü seçenekleri hakkında daha fazla bilgi verebilirsiniz.
    *   Menülerinizi daha da özelleştirmek için, farklı renkler, simgeler veya animasyonlar kullanabilirsiniz.
    *   Alt menüler oluşturarak, menülerinizi daha düzenli ve anlaşılır hale getirebilirsiniz.
    *   Kullanıcılarınızın tercihlerine göre menülerinizi dinamik olarak değiştirebilirsiniz (örneğin, dil seçeneğine göre).
    *   Menülerinizi klavye kısayollarıyla (örneğin, Ctrl+S, Ctrl+O) daha hızlı ve kolay bir şekilde erişilebilir hale getirebilirsiniz.


