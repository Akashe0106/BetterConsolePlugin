# AyracTuru (BracketType) Enum'ı: Olay Çıktılarınızı Kişiselleştirin

## Açıklama

`AyracTuru` (İngilizce'de `BracketType`) enum'ı, `GelismisKonsol` sınıfı ile birlikte kullanılarak olay tabanlı konsol çıktılarında kullanılan ayraçların türünü belirlemenizi sağlar. Bu enum, konsol uygulamalarınızın görünümünü kişiselleştirmenize ve marka imajınıza uygun hale getirmenize olanak tanır.

## Neden AyracTuru Enum'ını Kullanmalısınız?

*   **Görsel Çeşitlilik:** Konsol çıktılarınızı daha çeşitli ve ilgi çekici hale getirir.
*   **Marka Kimliği:** Uygulamanızın marka kimliğiyle uyumlu ayraçlar kullanarak tutarlı bir görünüm sağlar.
*   **Kullanıcı Tercihleri:** Kullanıcılarınızın tercihlerine göre ayraç türünü değiştirme imkanı sunar.
*   **Okunabilirlik:** Ayraç türünü değiştirerek belirli olay türlerini daha kolay fark edilmesini sağlayabilirsiniz.

## Değerler

| Değer          | Açıklama                                                                 | Örnek Çıktı     |
| :------------- | :----------------------------------------------------------------------- | :-------------- |
| `Bos`         | Ayraç kullanılmaz.                                                         | `BILGI Mesaj`   |
| `Kare`         | Köşeli ayraçlar kullanılır: `[]`                                        | `[BILGI] Mesaj` |
| `Kivrimli`     | Küme ayraçları kullanılır: `{}`                                        | `{BILGI} Mesaj` |
| `Koseli`       | Yuvarlak ayraçlar kullanılır: `()`                                      | `(BILGI) Mesaj` |
| `Cizgi`        | Dikey çizgi ayraçlar kullanılır: `\|\|`                                    | `\|BILGI\| Mesaj` |
| `Tirnak`       | Tek tırnak ayraçlar kullanılır: `''`                                    | `'BILGI' Mesaj` |
| `CiftTirnak`   | Çift tırnak ayraçlar kullanılır: `""`                                    | `"BILGI" Mesaj` |
| `BuyukKucuk`   | Büyüktür/küçüktür ayraçları kullanılır: `<>`                              | `<BILGI> Mesaj` |

## Kullanım

`AyracTuru` enum'ını `GelismisKonsol` sınıfının `VarsayilanAyracTuru` özelliği ile birlikte kullanabilirsiniz. Bu sayede, tüm olay çıktıları için varsayılan ayraç türünü belirleyebilirsiniz.

```csharp
using BetterConsolePlugin;

GelismisKonsol konsol = new GelismisKonsol();

// Varsayılan ayraç türünü küme ayraçları olarak ayarla
konsol.VarsayilanAyracTuru = AyracTuru.Kivrimli;

// Bilgi mesajı yazdır (küme ayraçları ile)
konsol.Yaz("Uygulama başlatılıyor...", Olay.Bilgi); // {BILGI} Uygulama başlatılıyor...

// Varsayılan ayraç türünü çizgi ayraçlar olarak ayarla
konsol.VarsayilanAyracTuru = AyracTuru.Cizgi;

// Hata mesajı yazdır (çizgi ayraçlar ile)
konsol.Yaz("Bir hata oluştu!", Olay.Hata); // |HATA| Bir hata oluştu!
