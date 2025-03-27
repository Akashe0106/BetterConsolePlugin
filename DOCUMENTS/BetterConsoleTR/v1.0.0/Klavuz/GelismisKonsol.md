# GelismisKonsol Sınıfı

## Açıklama

`GelismisKonsol` sınıfı, .NET projelerinizde konsol uygulamalarını daha zengin, bilgilendirici ve kullanıcı dostu hale getirmenize olanak tanıyan bir araçtır. Bu sınıf, renkli metinler, olay bazlı çıktılar, özelleştirilebilir ayraçlı metinler ve çizgi çizme gibi çeşitli özellikleri sayesinde konsol uygulamalarınızın görünümünü ve kullanılabilirliğini önemli ölçüde artırır. Bu sınıf, özellikle loglama, hata ayıklama, kullanıcı bilgilendirme ve etkileşimli menüler gibi senaryolarda büyük kolaylık sağlar.

## Özellikler

### Varsayılan Metin Rengi (VarsayilanMetinRengi)

*   **Açıklama:** Konsola yazdırılan metinlerin varsayılan rengini belirler. `Yaz` metodunda herhangi bir renk belirtilmediği durumlarda bu özellik tarafından belirlenen renk kullanılır.
*   **Tür:** `ConsoleColor` (System.Console namespace'inden)
*   **Varsayılan Değer:** `Console.ForegroundColor` (Konsolun başlangıçtaki varsayılan metin rengi)
*   **Kullanım:**

    ```csharp
    GelismisKonsol konsol = new GelismisKonsol();
    konsol.VarsayilanMetinRengi = ConsoleColor.Green; // Varsayılan rengi yeşil yapar
    konsol.Yaz("Bu metin yeşil renkte yazılacaktır.");
    ```

### Varsayılan Ayraç Rengi (VarsayilanAyracRengi)

*   **Açıklama:** Olay bazlı çıktılarda kullanılan ayraçların (örneğin, `[HATA]`, `[BILGI]`) varsayılan rengini belirler. Bu renk, `Yaz` metodunda bir olay türü belirtildiğinde, olayın etrafındaki ayraçların rengi olarak kullanılır.
*   **Tür:** `ConsoleColor`
*   **Varsayılan Değer:** `Console.ForegroundColor`
*   **Kullanım:**

    ```csharp
    GelismisKonsol konsol = new GelismisKonsol();
    konsol.VarsayilanAyracRengi = ConsoleColor.Yellow; // Ayraç rengini sarı yapar
    konsol.Yaz("Bir uyarı mesajı.", Olay.Uyari); // [UYARI] ayracı sarı renkte olacaktır.
    ```

### Varsayılan Satır Atla (VarsayilanSatirAtla)

*   **Açıklama:** `Yaz` metodu kullanıldığında, metnin yazdırılmasının ardından otomatik olarak bir sonraki satıra geçilip geçilmeyeceğini belirler. Bu özellik, konsol çıktılarının düzenini kontrol etmek için kullanılır.
*   **Tür:** `bool` (true veya false)
*   **Varsayılan Değer:** `false` (Yeni satıra geçilmez)
*   **Kullanım:**

    ```csharp
    GelismisKonsol konsol = new GelismisKonsol();
    konsol.VarsayilanSatirAtla = true; // Her metin yazdırıldıktan sonra yeni satıra geçilir.
    konsol.Yaz("Bu metin bir satırda...");
    konsol.Yaz("...ve bu metin diğer satırda olacaktır.");
    ```

### Varsayılan Ayraç Türü (VarsayilanAyracTuru)

*   **Açıklama:** Olay bazlı çıktılarda kullanılan ayraçların şeklini belirler (köşeli parantez, küme parantezi, vb.). Bu özellik, konsol çıktılarının görünümünü kişiselleştirmenizi sağlar.
*   **Tür:** `AyracTuru` (Özel bir enum)
*   **Varsayılan Değer:** `AyracTuru.Kare` (Köşeli parantezler: `[]`)
*   **Kullanım:**

    ```csharp
    GelismisKonsol konsol = new GelismisKonsol();
    konsol.VarsayilanAyracTuru = AyracTuru.Kivrimli; // Ayraçları küme parantezi yapar: {}
    konsol.Yaz("Bir bilgi mesajı.", Olay.Bilgi); // {INFO} şeklinde yazdırılır.
    ```

## Metotlar

### Yaz Metodu

Konsola metin yazdırır. Bu metot, metin rengi, olay türüne göre ayraçlar ve yeni satıra geçme gibi çeşitli seçenekler sunar.

```csharp
public void Yaz(string metin, Olay? olay = null, ConsoleColor? metinRengi = null, bool? satirAtla = null)
```

*   **Parametreler:**
    *   `metin` (string): Konsola yazdırılacak metin. Bu parametre zorunludur ve null veya boş olamaz.
    *   `olay` (Olay?, isteğe bağlı): Metne eşlik eden olay türü. Bu parametre null olabilir. Olay türü belirtilirse, metnin solunda olay türünü belirten bir ayraç gösterilir.
    *   `metinRengi` (ConsoleColor?, isteğe bağlı): Metnin rengi. Bu parametre null olabilir. Belirtilmezse `VarsayilanMetinRengi` özelliği kullanılır.
    *   `satirAtla` (bool?, isteğe bağlı): Metnin sonuna yeni satır karakteri eklenip eklenmeyeceği. Bu parametre null olabilir. Belirtilmezse `VarsayilanSatirAtla` özelliği kullanılır.
*   **İstisnalar:**
    *   `ArgumentNullException`: Eğer `metin` parametresi null ise bu istisna fırlatılır.
*   **Kullanım Örnekleri:**

    ```csharp
    using BetterConsolePlugin;

    GelismisKonsol konsol = new GelismisKonsol();

    // Basit metin yazdırma
    konsol.Yaz("Merhaba, konsol!");

    // Renkli metin yazdırma
    konsol.Yaz("Bu metin kırmızı renkte.", null, ConsoleColor.Red);

    // Olaylı metin yazdırma (varsayılan ayraç türü ile)
    konsol.Yaz("Bir hata oluştu!", Olay.Hata);

    // Olaylı metin yazdırma (özel ayraç türü ve rengi ile)
    konsol.VarsayilanAyracRengi = ConsoleColor.Cyan;
    konsol.VarsayilanAyracTuru = AyracTuru.Kivrimli;
    konsol.Yaz("Bir uyarı mesajı.", Olay.Uyari, ConsoleColor.Yellow);

    // Metin yazdırma ve yeni satıra geçme
    konsol.VarsayilanSatirAtla = true;
    konsol.Yaz("Bu metin bir satırda.");
    konsol.Yaz("Bu metin diğer satırda.");
    ```

### CizgiCiz Metodu

Konsola belirtilen renkte ve karakterde yatay bir çizgi çizer. Bu metot, konsol çıktılarında görsel ayraçlar oluşturarak bilgileri daha düzenli sunmanıza yardımcı olur.

```csharp
public void CizgiCiz(ConsoleColor renk, char karakter = '-')
```

*   **Parametreler:**
    *   `renk` (ConsoleColor): Çizginin rengi. Bu parametre zorunludur.
    *   `karakter` (char, isteğe bağlı): Çizgiyi oluşturan karakter. Bu parametre isteğe bağlıdır ve varsayılan değeri '-' (tire) karakteridir.
*   **Kullanım Örnekleri:**

    ```csharp
    using BetterConsolePlugin;

    GelismisKonsol konsol = new GelismisKonsol();

    // Sarı renkte çizgi çizme (varsayılan karakter ile)
    konsol.CizgiCiz(ConsoleColor.Yellow);

    // Kırmızı renkte yıldızlardan oluşan çizgi çizme
    konsol.CizgiCiz(ConsoleColor.Red, '*');
    ```

*   **Ek Notlar:**

    *   `CizgiCiz` metodu, konsol çıktılarında bölümler arası görsel ayrım sağlamak için kullanılabilir.
    *   Farklı karakterler kullanarak daha yaratıcı çizgi stilleri oluşturabilirsiniz.
    *   Çizgi rengini ve karakterini, uygulamanızın temasına veya belirli olaylara göre dinamik olarak değiştirebilirsiniz.

