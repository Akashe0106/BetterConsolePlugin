# Olay (Event) Enum'ı: Konsol Çıktılarınızı Anlamlandırın

## Açıklama

`Olay` (İngilizce'de `Event`) enum'ı, konsol uygulamalarınızdaki çıktıları zenginleştirmek ve anlam katmak için tasarlanmış güçlü bir araçtır. Bu enum, uygulamanızın çalışma zamanında karşılaştığı farklı durumları kategorize etmenizi sağlar: bilgilendirme mesajları, hatalar, uyarılar, başarılı işlemler, kullanıcıdan girdi beklentileri, hata ayıklama bilgileri ve kritik durumlar. `Olay` enum'ını `GelismisKonsol` sınıfının `Yaz` metoduyla birlikte kullanarak, konsol çıktılarınıza anında bir bağlam kazandırabilir ve kullanıcılarınızın (veya sizin) uygulamanızın durumunu hızlıca anlamasını sağlayabilirsiniz.

## Neden Olay Enum'ını Kullanmalısınız?

*   **Okunabilirlik:** Konsol çıktılarınızı daha düzenli ve kolay okunabilir hale getirir.
*   **Anlaşılabilirlik:** Mesajların ne anlama geldiğini ve uygulamanızın hangi durumda olduğunu net bir şekilde belirtir.
*   **Hata Ayıklama:** Hata ayıklama süreçlerinizi kolaylaştırır, hataların kaynağını ve önemini hızlıca belirlemenize yardımcı olur.
*   **Loglama:** Loglama sistemleriniz için tutarlı ve anlamlı çıktılar sağlar.
*   **Kullanıcı Deneyimi:** Kullanıcılarınıza uygulamanızın durumu hakkında net ve öz bilgiler sunarak daha iyi bir deneyim yaşatır.

## Değerler

| Değer    | Açıklama                                                                                             | Örnek Mesaj                                 | Konsol Çıktısı Örneği             |
| :------- | :----------------------------------------------------------------------------------------------------- | :------------------------------------------ | :-------------------------------- |
| `Bilgi`  | Uygulama veya sistem hakkında genel bilgileri temsil eder.                                          | "Uygulama başarıyla başlatıldı."            | `[BILGI] Uygulama başlatıldı.`   |
| `Hata`   | Beklenmedik bir sorun veya hata oluştuğunu belirtir.                                                | "Bir dosya okuma hatası oluştu."            | `[HATA] Bir dosya okuma hatası.`    |
| `Uyari`  | Potansiyel bir sorun veya risk olduğunu işaret eder.                                                   | "Disk alanı kritik seviyeye ulaştı."        | `[UYARI] Disk alanı kritik seviyede.` |
| `Basarili` | Bir işlemin başarıyla tamamlandığını gösterir.                                                         | "Veritabanı bağlantısı başarıyla sağlandı." | `[BASARILI] Veritabanı bağlandı.`    |
| `Soru`   | Kullanıcıdan bir girdi veya onay bekleyen durumları temsil eder.                                         | "Devam etmek istiyor musunuz? (E/H)"       | `[SORU] Devam etmek istiyor musunuz?`  |
| `Debug`  | Geliştirme ve hata ayıklama sırasında kullanılan bilgileri içerir.                                      | "Değişken 'isim' değeri: 'Ahmet'"          | `[DEBUG] Değişken 'isim' değeri: 'Ahmet'` |
| `Kritik` | Uygulamanın kararlılığını veya çalışmasını ciddi şekilde etkileyebilecek durumları belirtir.             | "Bellek yetersiz hatası!"                   | `[KRITIK] Bellek yetersiz hatası!`     |
| `Test`   | Test süreçlerinde kullanılan bilgileri içerir.                                                      | "Veritabanı bağlantı testi başarılı."       | `[TEST] Veritabanı bağlantı testi.`     |

## Kullanım

`Olay` enum'ını `GelismisKonsol` sınıfının `Yaz` metodu ile birlikte kullanmak oldukça kolaydır. Sadece yazdırmak istediğiniz mesajı ve ilgili `Olay` türünü belirtmeniz yeterlidir.

```csharp
using BetterConsolePlugin;

GelismisKonsol konsol = new GelismisKonsol();

// Bilgi mesajı yazdırma
konsol.Yaz("Uygulama başlatılıyor...", Olay.Bilgi);

// Hata mesajı yazdırma
konsol.Yaz("Bir hata oluştu!", Olay.Hata);

// Uyarı mesajı yazdırma
konsol.Yaz("Disk alanı azalıyor.", Olay.Uyari);
```
