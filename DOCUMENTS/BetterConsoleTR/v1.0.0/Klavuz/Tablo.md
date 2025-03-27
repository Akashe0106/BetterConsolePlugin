
# Tablo Sınıfı: Verilerinizi Konsolda Sanata Dönüştürün

## Açıklama

`Tablo` (İngilizce'de `Table`) sınıfı, .NET konsol uygulamalarınızda verilerinizi etkileyici ve kolay anlaşılır bir şekilde sunmanın anahtarıdır. Sadece bir araç değil, aynı zamanda verilerinizi görsel bir şölene dönüştüren bir sanat eseridir! Bu sınıf, başlıklar ve satırlar içeren tablolar oluşturmanıza, sütun genişliklerini otomatik olarak ayarlamanıza, farklı renkler kullanarak tablonuzun estetiğini artırmanıza ve hatta özel biçimlendirme seçenekleriyle verilerinizi daha anlamlı hale getirmenize olanak tanır. Karmaşık veri kümelerini analiz etmek, dikkat çekici raporlar oluşturmak veya kullanıcılarınıza net ve öz bilgiler sunmak istediğinizde, `Tablo` sınıfı vazgeçilmez yardımcınız olacaktır.

## Neden Tablo Sınıfını Kullanmalısınız?

*   **Görsel Çekicilik:** Verilerinizi sıkıcı listeler yerine, göze hitap eden ve akılda kalıcı tablolara dönüştürün.
*   **Anlaşılabilirlik:** Karmaşık veri kümelerini düzenli bir şekilde sunarak, kullanıcılarınızın bilgiyi hızla kavramasını sağlayın.
*   **Profesyonel İzlenim:** Konsol uygulamalarınıza profesyonel bir dokunuş katın ve kullanıcılarınıza kaliteli bir deneyim sunun.
*   **Veri Analizi:** Verilerinizi görsel olarak analiz ederek, önemli eğilimleri ve ilişkileri kolayca keşfedin.
*   **Esneklik:** Metin, sayı, tarih ve daha fazlası gibi farklı veri türlerini destekleyin ve verilerinizi istediğiniz gibi biçimlendirin.
*   **Özelleştirme:** Başlık ve veri renklerini, sütun genişliklerini ve diğer biçimlendirme seçeneklerini özelleştirerek tablonuzun görünümünü tam olarak kontrol edin.

## Özellikler

*   **Basliklar:** Tablonun başlıklarını tanımlayan, okunabilirliği artıran ve verilerinizi anlamlı bir şekilde kategorize eden bir `string` dizisidir.
    *   Tür: `string[]`
*   **Veriler:** Tablonun kalbini oluşturan, her biri bir satırı temsil eden ve farklı veri türlerini içeren `object` dizilerinden oluşan bir listedir.
    *   Tür: `List<object[]>`
*   **BaslikRengi:** Tablonuzun başlıklarına canlılık katan, okunabilirliği artıran ve tablonuzun genel estetiğini iyileştiren bir renktir.
    *   Tür: `ConsoleColor?` (nullable ConsoleColor)
    *   Varsayılan Değer: `ConsoleColor.Cyan`
*   **VeriRengi:** Tablonuzdaki verilere hayat veren, okunabilirliği artıran ve verilerinizi vurgulamanıza olanak tanıyan bir renktir.
    *   Tür: `ConsoleColor?` (nullable ConsoleColor)
    *   Varsayılan Değer: `ConsoleColor.White`

## Metotlar

### BaslikEkle Metodu: Tablonuza Ruh Katın

Tablonuza anlam ve yapı kazandıran başlıkları eklemek için kullanılır. Bu metot, tablonuzun içeriğini tanımlayan ve kullanıcılarınıza yol gösteren başlıkları oluşturmanıza olanak tanır.

```csharp
public void BaslikEkle(params string[] basliklar)
```

*   **Parametreler:**
    *   `basliklar` (string[]): Tablonuzun başlıklarını temsil eden `string` değerlerinden oluşan bir dizi. `params` anahtar kelimesi sayesinde, metodu çağırırken başlıkları virgülle ayırarak kolayca ekleyebilirsiniz.
*   **İstisnalar:**
    *   `ArgumentException`: Eğer eklemeye çalıştığınız başlıkların sayısı, mevcut verilerinizle uyumlu değilse, bu istisna fırlatılır.

### SatirEkle Metodu: Verilerinizi Canlandırın

Tablonuza yeni veriler ekleyerek içeriğini zenginleştirmenizi sağlar. Bu metot, verilerinizi düzenli bir şekilde tablonuza eklemenize ve kullanıcılarınıza sunmanıza olanak tanır.

```csharp
public void SatirEkle(params object[] satirVerileri)
```

*   **Parametreler:**
    *   `satirVerileri` (object[]): Tablonuza eklenecek verileri temsil eden `object` değerlerinden oluşan bir dizi. `params` anahtar kelimesi sayesinde, metodu çağırırken verileri virgülle ayırarak kolayca ekleyebilirsiniz.
*   **İstisnalar:**
    *   `ArgumentException`: Eğer eklemeye çalıştığınız veri satırının sütun sayısı, tablonuzun başlıklarıyla uyumlu değilse, bu istisna fırlatılır.

### Yazdir Metodu: Şaheserinizi Sergileyin

Oluşturduğunuz tabloyu konsolda görüntüleyerek, verilerinizi etkileyici bir şekilde sunmanızı sağlar. Bu metot, tablonuzun başlıklarını, verilerini ve biçimlendirmesini konsola yazdırarak, kullanıcılarınızın bilgiyi kolayca kavramasına yardımcı olur.

```csharp
public void Yazdir()
```

*   **Parametreler:** Yok
*   **İstisnalar:** Yok

## Kullanım

```csharp
using BetterConsolePlugin;

// Yeni bir tablo oluşturun
Tablo tablo = new Tablo();

// Tablonuza başlıklar ekleyin
tablo.BaslikEkle("Ad", "Yaş", "Şehir", "Meslek");

// Tablonuza veriler ekleyin
tablo.SatirEkle("Ahmet Yılmaz", 30, "İstanbul", "Mühendis");
tablo.SatirEkle("Ayşe Kaya", 25, "Ankara", "Öğretmen");
tablo.SatirEkle("Mehmet Demir", 40, "İzmir", "Doktor");

// Başlık rengini ayarlayın
tablo.BaslikRengi = ConsoleColor.Yellow;

// Veri rengini ayarlayın
tablo.VeriRengi = ConsoleColor.Green;

// Tablonuzu konsola yazdırın
tablo.Yazdir();
```

*   **Ek Notlar:**

    *   `Tablo` sınıfını kullanarak farklı veri kaynaklarından (veritabanları, dosyalar, API'ler vb.) alınan verileri kolayca görüntüleyebilirsiniz.
    *   Sütun genişlikleri otomatik olarak ayarlanır, ancak isterseniz özel bir biçimlendirme uygulayarak sütun genişliklerini manuel olarak da kontrol edebilirsiniz.
    *   Tablonuzun görünümünü daha da özelleştirmek için farklı karakterler (örneğin, çizgi karakterleri) kullanarak hücreler arası ayraçlar oluşturabilirsiniz.
    *   `System.Reflection` kütüphanesini kullanarak, nesnelerin özelliklerini dinamik olarak tabloya aktarabilirsiniz.
    *   Tablonuzu oluşturduktan sonra, verileri filtreleyebilir, sıralayabilir veya özetleyebilirsiniz.
    *   Tablonuzu farklı formatlarda (örneğin, CSV, HTML) dışa aktarmak için ek kütüphaneler kullanabilirsiniz.

Bu örnek, `Tablo` sınıfını kullanarak nasıl etkileyici ve düzenli tablolar oluşturabileceğinizi göstermektedir. Kendi yaratıcılığınızı kullanarak, farklı veri türlerini, biçimlendirme seçeneklerini ve renkleri bir araya getirebilir ve konsol uygulamalarınızda unutulmaz bir görsel deneyim yaratabilirsiniz!
